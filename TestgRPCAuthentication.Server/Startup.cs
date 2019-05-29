using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using Grpc;
using Grpc.Core;
using Greet;
using TestgRPCAuthentication.ServerService.Services;
using System.IdentityModel.Tokens.Jwt;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using IdentityServer4.AccessTokenValidation;
using Grpc.Core.Interceptors;

namespace TestgRPCAuthentication.ServerService
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

            services.AddAuthorization(options =>
            {
                options.AddPolicy("protectedScope", policy =>
                {
                    policy.RequireClaim("scope", "grpc_protected_scope");
                });
            });

            services.AddAuthorization();

            services.AddAuthentication(IdentityServerAuthenticationDefaults.AuthenticationScheme)
                .AddIdentityServerAuthentication(options =>
                {
                    options.Authority = InternalIdentityUrl;
                    options.ApiName = "ProtectedGrpc";
                    options.ApiSecret = "grpc_protected_secret";
                    options.RequireHttpsMetadata = false;
                });
            
            // Start GRPC Server Service
            StartGrpcServer(services);
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseAuthentication();
            app.UseCors();

            app.UseMvc();
        }

        private void StartGrpcServer(IServiceCollection services)
        {
            var server = new Server
            {
                Services =
                    {
                        Greeter.BindService(new GreeterService()).Intercept(new ServerCallContextInterceptor(x => { }))
                    },
                Ports = { new ServerPort("localhost", 50051, ServerCredentials.Insecure) }
            };
            server.Start();

            Console.WriteLine($"gRPC server service listening on 0.0.0.0:50051");
        }
    }
}
