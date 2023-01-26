using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LawyerOffice.Data.EF;
using LawyerOffice.Infrastructure;
using LawyerOffice.Entities.Repositories;
using LawyerOffice.Data.EF.Repositories;
using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using LawyerOffice.Infrastructure.DataContextStorage;

namespace LawyerOfficeMvc
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
            services.AddControllersWithViews();
            // services.AddScoped(s => new OfficeLawyerContext(Configuration.GetConnectionString("OfficeLawyerContext")));
            //services.AddDbContext<OfficeLawyerContext>(s => s.UseSqlServer("Server=(localdb)\\MSSQLLocalDB;Database=LawyerEFCore;Trusted_Connection=True;MultipleActiveResultSets=true;"),
            //       contextLifetime:ServiceLifetime.Transient,
            //       optionsLifetime:ServiceLifetime.Transient);
            services.AddAutoMapper(typeof(LawyerProfile));
            services.AddScoped<IMapper, Mapper>();
            services.AddTransient<ILawyerRepository, LawyerRepository>();
            services.AddTransient<ICaseRepository, CaseRepository>();
            services.AddTransient<IUnitOfWorkFactory, EFUnitOfWorkFactory>();
           // services.AddTransient<IUnitOfWork, EFUnitOfWork>();
            services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();
            services.AddSingleton<IconfigManager, ConfigManager>();
            services.AddDbContextFactory<OfficeLawyerContext, CDataContextFactory>(
                options => options.UseSqlServer("Server=(localdb)\\MSSQLLocalDB;Database=LawyerEFCore;Trusted_Connection=True;MultipleActiveResultSets=true;"),
                  ServiceLifetime.Scoped                  
                  );
          
            
           
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }
            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
