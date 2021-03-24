using Data;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.OpenApi.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllers();
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "WebAPI", Version = "v1" });
            });
            services.AddScoped<DataContext>();

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "WebAPI v1"));
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            //app.UseMyMiddleware();
            app.UseMiddleware<MyMiddleware>();

            // Įsiterpia
            //app.Use(
            //    (c, next) =>
            //    {
            //        Console.WriteLine();
            //        return next();
            //    });

            // Užbaigia
            //app.Run(
            //    (c) =>
            //    {
            //        return c.Response.CompleteAsync();
            //    });

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
                endpoints.MapControllerRoute( name: "default", pattern: "{**id}", defaults: new { controller = "Utility", action= "Get"});
                
                endpoints.Map(pattern: "coffe",
                    async (context) =>
                    {
                        context.Response.StatusCode = 418;
                        var sw = new StreamWriter(context.Response.Body);
                        sw.Write(
                        @"
                            <h1>I am a teapot</h1>
                            <h3>I don't make coffe</h3>
                        ");
                        await sw.FlushAsync();
                        await context.Response.CompleteAsync();
                    });


                //endpoints.MapControllerRoute( name: "default", pattern: "api/v2/{controller}/{action}/{id?}");
                //endpoints.MapDefaultControllerRoute();
            });
        }
    }
}
