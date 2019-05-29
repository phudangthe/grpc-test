using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace TestgRPCAuthentication.WebApi1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TestApiController : ControllerBase
    {
        HttpClient _client;

        public TestApiController(HttpClient client){
            _client = client;
        }
        
        // GET api/values
        [HttpGet]
        public async Task<IEnumerable<string>> Get()
        {
            var accessToken = await HttpContext.GetTokenAsync("access_token");
            Console.Write(accessToken);

            var response = await _client.GetAsync("http://localhost:5002/api/values");
            var results = await response.Content.ReadAsAsync<List<string>>();
            return results;
        }
    }
}
