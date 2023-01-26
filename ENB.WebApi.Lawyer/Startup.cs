using AutoMapper;
using LawyerOffice.Data.EF;
using LawyerOffice.Data.EF.Repositories;
using LawyerOffice.Entities.Repositories;
using LawyerOffice.Infrastructure;
using LawyerOffice.Infrastructure.DataContextStorage;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.OpenApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ENB.WebApi.Lawyer
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
            services.AddCors(policy =>
            {
                policy.AddPolicy("CorsPolicy", opt => opt
                    .AllowAnyOrigin()
                    .AllowAnyHeader()
                    .AllowAnyMethod());
            });
            services.AddControllers();

            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo 
                { 
                    Title = "ENB-Lawyers-Cases-Bills-API",
                     Version = "v1",
                     Description= "Lawyers-Cases-Bills API",
                     Contact= new OpenApiContact
                     {
                         Name="Etienne Ngandu Bukasa",
                         Email="etngandu@hotmail.com",
                         Url= new Uri("https://etngandu.be"),
                     },
                     License = new OpenApiLicense
                     {
                         Name="ENB OpenLicence",
                         Url= new Uri("https://etngandu.be"),
                     }

                });
            });

            services.AddDbContext<OfficeLawyerContext>(s => s.UseSqlServer(Configuration.GetConnectionString("LawyerConnectionstring")),
                   contextLifetime: ServiceLifetime.Transient,
                   optionsLifetime: ServiceLifetime.Transient);
            services.AddAutoMapper(typeof(LawyerProfile));
            services.AddScoped<IMapper, Mapper>();
            services.AddSingleton<IHttpContextAccessor,HttpContextAccessor>();
            services.AddScoped<ILawyerRepository, LawyerRepository>();
            services.AddScoped<ICaseRepository, CaseRepository>();
            services.AddScoped<IAsyncCaseRepository, AsyncCaseRepository>();
            services.AddScoped<IAsyncUnitOfWorkFactory,AsyncEFUnitOfWorkFactory>();
            services.AddScoped<IUnitOfWorkFactory, EFUnitOfWorkFactory>();          
            services.AddScoped<IDataContextStorageContainer<OfficeLawyerContext>, DataContextFactory>();

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "ENB.WebApi.Lawyer v1"));
                
            }

            app.UseRouting();
            app.UseCors("CorsPolicy");
            app.UseAuthorization();           

            app.UseEndpoints(endpoints =>
            {                
                endpoints.MapControllers();
            });
        }
    }
}
