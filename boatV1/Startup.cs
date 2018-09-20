using Boat.Business.Service;
using Boat.Data.DataModel.BoatModule.Interface;
using Boat.Framework.Interface;
using Boat.Framework.Ioc;
using Boat.Framework.Service;
using Castle.Windsor.MsDependencyInjection;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Swashbuckle.AspNetCore.Swagger;
using System;

namespace boatV1
{
    public class Startup
    {
        //  private ILogger logger = IocFacility.Container.Resolve<ILoggerFactory>().CreateLogger(typeof(Startup));

        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public IServiceProvider ConfigureServices(IServiceCollection services)
        {
            //logger.SetGlobalContext("ApplicationName", typeof(Startup).Assembly.GetName().Name);
            services.AddScoped<IService, BoatsService>();
            services.AddScoped<IService, BoatPhotosService>();
            //services.AddScoped<IBoatPhotosService, BoatPhotosService>();
            //services.AddScoped<IBoatsService, BoatsService>();

            services.AddMvc()
                 .SetCompatibilityVersion(CompatibilityVersion.Version_2_1)
                    .AddJsonOptions(x => x.SerializerSettings.ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore)
                    .AddControllersAsServices();

            // Register the Swagger generator, defining 1 or more Swagger documents
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new Info { Title = "My API", Version = "v1" });
            });

            return WindsorRegistrationHelper.CreateServiceProvider(IocFacility.Container, services);
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseHsts();
            }
            //angular allow header
            app.UseCors(x => x.AllowAnyHeader().AllowAnyMethod().AllowAnyOrigin().AllowCredentials());

            app.UseHttpsRedirection();
            app.UseMvc(routes =>
            {
                routes.MapRoute(
                   name: "default",
                   template: "{controller=values}/{action=Get}/{id?}");
            });
            // Enable middleware to serve generated Swagger as a JSON endpoint.
            app.UseSwagger();

            // Enable middleware to serve swagger-ui (HTML, JS, CSS, etc.), 
            // specifying the Swagger JSON endpoint.
            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "My API V1");
            });

            app.UseHttpsRedirection();
        }
    }
}
