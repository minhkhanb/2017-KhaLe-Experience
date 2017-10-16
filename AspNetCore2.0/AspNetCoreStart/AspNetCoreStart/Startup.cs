using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;

using ExceptionHandling;
using Microsoft.Extensions.Configuration;

namespace AspNetCoreStart
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddSingleton<IException, FileExceptionHandler>();
            services.AddMvc();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            //app.Run(async (context) =>
            //{
            //    await context.Response.WriteAsync("Hello World!");
            //});
            /*:todo*/
            //app.UseMvc(routes => {
            //    routes.MapRoute(
            //        name: "default",
            //        template: "{controller}/{action}/{id?}",
            //        defaults: new { controller = "Home", action = "Index" }
            //        );
            //});
            //app.UseStaticFiles();
            var configur = new ConfigurationBuilder();
            configur.SetBasePath(System.IO.Directory.GetCurrentDirectory());
            IConfiguration config = configur.AddJsonFile("Config.json").Build();

            string str = config["Data:Key1"];

            app.UseAuthorization();
            app.UseAuthentication();
            app.Run(Myresponse);
        }
        public Task Myresponse(HttpContext con)
        {
            return con.Response.WriteAsync("Hello .net core 2.0");
        }
    }
}
