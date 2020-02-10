using Autofac;
using Data.Context;
using IoC;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using SystemConfig;

namespace Api
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            AppSettings.Configure(configuration);
        }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddEntityFrameworkSqlite()
                .AddDbContext<EfCrudContext>();

            services.AddControllers();
        }

        public void ConfigureContainer(ContainerBuilder builder)
        {
            ContainerConfiguration.Configure(builder);
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseRouting();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });

            ConfigureContext.Configure();
        }
    }
}
