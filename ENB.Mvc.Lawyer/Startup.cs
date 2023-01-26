using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
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
using AspNetCoreHero.ToastNotification;
using Microsoft.Extensions.Logging;
using Microsoft.AspNetCore.Identity;
using LawyerOffice.Entities;
using ENB.Mvc.Lawyer.Factory;

namespace ENB.Mvc.Lawyer
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
            services.AddDbContext<OfficeLawyerContext>(s => s.UseSqlServer(Configuration.GetConnectionString("LawyerConnectionstring")),
                   contextLifetime: ServiceLifetime.Transient,
                   optionsLifetime: ServiceLifetime.Transient);
            services.AddAutoMapper(typeof(LawyerProfile));
            services.AddScoped<IMapper, Mapper>();
            services.AddScoped<ILawyerRepository, LawyerRepository>();
            services.AddScoped<ICaseRepository, CaseRepository>();
            services.AddScoped<IUnitOfWorkFactory, EFUnitOfWorkFactory>();
            services.AddScoped<IDataContextStorageContainer<OfficeLawyerContext>, DataContextFactory>();
            services.AddIdentity<ApplicationUser, IdentityRole>(
                opt =>
                {
                    opt.Password.RequiredLength = 7;
                    opt.Password.RequireDigit = false;
                    opt.Password.RequireUppercase = false;
                })
                 .AddEntityFrameworkStores<OfficeLawyerContext>();

            services.AddScoped<IUserClaimsPrincipalFactory<ApplicationUser>, CustomClaimsFactory>();

            services.AddNotyf(config => 
            { config.DurationInSeconds = 10; config.IsDismissable = true; config.Position = NotyfPosition.TopRight; });
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
            }
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthentication();
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
