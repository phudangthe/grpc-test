using System.Collections.Generic;
using System.Threading.Tasks;

namespace TestgRPCAuthentication.WebApi1.Controllers{
    public interface ITestGrpcService {
        Task<List<string>> GetValues();
        Task<string> Hello(string name);
    }
}