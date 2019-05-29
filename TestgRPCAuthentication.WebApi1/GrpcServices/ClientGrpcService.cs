using Greet;
using System;
using Google.Protobuf.WellKnownTypes;
using Grpc.Core;
using System.Collections.Generic;

namespace TestgRPCAuthentication.WebApi1.GrpcServices
{
    public class ClientGrpcService : Greeter.GreeterClient
    {
        public ClientGrpcService(Channel chanel) : base(chanel){
        }
        public override HelloReply SayHello(HelloRequest request, Grpc.Core.CallOptions options){
            return base.SayHello(request, options);
        }

        public override ReturnValues GetValues(Google.Protobuf.WellKnownTypes.Empty request, Grpc.Core.CallOptions options){
            return base.GetValues(request, options);
        }
    }
}