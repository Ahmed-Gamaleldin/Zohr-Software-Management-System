using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using ZohrChangeSystem.Data;

namespace ZohrChangeSystem
{
    public class Startup
    {
        private readonly IConfiguration _config;
        public Startup(IConfiguration config)
        {
            _config = config;
        }
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {


            services.AddDbContext<ZohrContext>(cfg =>
            {
                cfg.UseSqlServer(_config.GetConnectionString("ZohrConnectionString"));
            });

            services.AddMvc()
                .AddJsonOptions(opt => opt.SerializerSettings.ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore);
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {


            app.UseDefaultFiles();
            app.UseStaticFiles();
            app.UseMvc(cfg =>
            {
                cfg.MapRoute("Default",
                  "{controller}/{action}/{id?}",
                  new { controller = "Home", Action = "Index" });
            });


        }
    }
}
