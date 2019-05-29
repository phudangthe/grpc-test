using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Greet;
using Grpc.Core;
using Grpc.Core.Interceptors;
using TestgRPCAuthentication.WebApi1.GrpcServices;
using static Greet.Greeter;

namespace TestgRPCAuthentication.WebApi1.Controllers{
    public class TestGrpcService : ITestGrpcService{
        private readonly GreeterClient _grpcClientService;
        private readonly ApiService _apiService;

        public TestGrpcService(GreeterClient grpcClientService, ApiService apiService)
        {
            _grpcClientService = grpcClientService;
            _apiService = apiService;
        }
        public async Task<List<string>> GetValues(){
            CallOptions callOptions = new CallOptions(await this.GetToken());
            return _grpcClientService.GetValues(new Google.Protobuf.WellKnownTypes.Empty(), callOptions).Values.ToList<string>();
        }
        public async Task<string> Hello(string name){
            CallOptions callOptions = new CallOptions(await this.GetToken());
            return _grpcClientService.SayHello(new HelloRequest() { Name = name }, callOptions).Message;
        }

        private async Task<Metadata> GetToken(){
            var token = await _apiService.GetAccessTokenAsync();

            var tokenValue = "Bearer " + token;
            return new Metadata
            {
                { "Authorization", tokenValue },
                { "CallerId", _apiService.ApiName }
            };            
        }
    }
}