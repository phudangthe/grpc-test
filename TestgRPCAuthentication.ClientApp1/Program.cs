using Grpc.Core;
using System;
using System.Linq;
using System.Collections.Generic;
using Greet;
using Grpc.Core.Interceptors;
using Microsoft.Extensions.Options;

namespace TestgRPCAuthentication.ClientApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Channel channel = new Channel("localhost:50051", ChannelCredentials.Insecure);
            
            var client = new Greeter.GreeterClient(channel.Intercept(metadata => {
                Console.Write("Phu Dang");
                metadata.Add(new Metadata.Entry("ClientID", "WebApp1"));
                return metadata;
            }));
            String user = "you";

            var header = new Metadata();
            header.Add("ApiName", "ClientApp1");

            var reply = client.SayHello(new HelloRequest { Name = user }, new CallOptions(header));
            Console.WriteLine("Greeting: " + reply.Message);

            var response = client.GetValues(new Google.Protobuf.WellKnownTypes.Empty(), new CallOptions(header));
            Console.WriteLine("Values: " + response.Values);

            channel.ShutdownAsync().Wait();
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}
