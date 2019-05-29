using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TestgRPCAuthentication.WebApi1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TestGrpcController : ControllerBase
    {
        private readonly ITestGrpcService _testGrpcService;
        public TestGrpcController(ITestGrpcService testGrpcService){
            _testGrpcService = testGrpcService;
        }

        // GET api/values
        [HttpGet("values")]
        public async Task<List<string>> Get()
        {
            return await _testGrpcService.GetValues();
        }

        [HttpGet]
        [Route("hello")]
        public async Task<string> Hello(string name)
        {
            return await _testGrpcService.Hello(name);
        }
    }
}
