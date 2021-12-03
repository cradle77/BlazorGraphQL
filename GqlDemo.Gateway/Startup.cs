using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Net.Http.Headers;

namespace GqlDemo.Gateway
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddCors();

            services.AddHttpContextAccessor();

            services.AddHttpClient("shares", c => c.BaseAddress = new Uri("https://localhost:5001/graphql/"));

            services.AddHttpClient("investors", (sp, c) => 
            {
                HttpContext context = sp.GetRequiredService<IHttpContextAccessor>().HttpContext;

                if (context.Request.Headers.ContainsKey("Authorization"))
                {
                    c.DefaultRequestHeaders.Authorization =
                        AuthenticationHeaderValue.Parse(
                            context.Request.Headers["Authorization"]
                                .ToString());
                }

                c.BaseAddress = new Uri("https://localhost:5003/graphql/");
            });

            services.AddGraphQLServer()
                .AddRemoteSchema("shares")
                .AddRemoteSchema("investors")
                .AddTypeExtensionsFromFile("./stitching.graphql");
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseCors(config =>
            {
                config.AllowAnyOrigin();
                config.AllowAnyMethod();
                config.AllowAnyHeader();
            });

            app.UseRouting();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapGraphQL();
            });
        }
    }
}
