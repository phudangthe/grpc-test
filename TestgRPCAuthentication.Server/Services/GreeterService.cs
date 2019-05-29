using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Google.Protobuf.WellKnownTypes;
using Greet;
using Grpc.Core;

namespace TestgRPCAuthentication.ServerService.Services
{
    public class GreeterService : Greeter.GreeterBase
    {
        public override Task<HelloReply> SayHello(HelloRequest request, ServerCallContext context)
        {
            return Task.FromResult(new HelloReply() { Message = $"Hello {request.Name} !!!, this request from {context.RequestHeaders[0].Value}" });
        }

        public override Task<ReturnValues> GetValues(Empty request, ServerCallContext context)
        {
            return Task.FromResult(new ReturnValues() { Values = { context.RequestHeaders.Select(metadata => metadata.Value) } });
        }
    }
}
