using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Greet;
using Grpc.Core;
using Grpc.Core.Interceptors;
using IdentityModel.Client;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using TestgRPCAuthentication.WebApi1.Controllers;
using TestgRPCAuthentication.WebApi1.GrpcServices;
using static Greet.Greeter;

namespace TestgRPCAuthentication.WebApi1
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        private string InternalIdentityUrl
        {
            get
            {
                return Configuration.GetValue<string>("IdentityUrl:Internal");
            }
        }

        private string ExternalIdentityUrl
        {
            get
            {
                return Configuration.GetValue<string>("IdentityUrl:External");
            }
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_1);

            services.AddSingleton<HttpClient>();
            services.AddSingleton<ApiService>();
            services.AddScoped<ITestGrpcService, TestGrpcService>();

            RegisterGrpcClientServices(services);
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseMvc();
        }

        private void RegisterGrpcClientServices(IServiceCollection services)
        {
            var channel = new Channel("localhost", 50051,
                ChannelCredentials.Insecure);

            services.AddSingleton(new GreeterClient(channel.Intercept(
                metadata => {
                    metadata = metadata ?? new Metadata();
                    metadata.Add(new Metadata.Entry("ClientID", "WebApp1"));
                    return metadata;
                }
            )));

            
        }

        public void ClientRequest<TRequest, TResponse>(ClientInterceptorContext<TRequest, TResponse> context)
        where TRequest : class
        where TResponse : class
        {
            Console.Write("ssss");
        }
    }    
}
