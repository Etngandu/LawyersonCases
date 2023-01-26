using ENB.Blazor.Lawyer.HttpRepository;
using LawyerOffice.Data.EF;
using LawyerOffice.Infrastructure.DataContextStorage;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Radzen;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace ENB.Blazor.Lawyer
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            var builder = WebAssemblyHostBuilder.CreateDefault(args);
            builder.RootComponents.Add<App>("#app");

            builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri("http://localhost:40927/api/") });
            builder.Services.AddScoped<ILawyerHttpRepository, LawyerHttpRepository>();
            builder.Services.AddScoped<ICaseHttpRepository, CaseHttpRepository>();
           // builder.Services.AddScoped<IDataContextStorageContainer<OfficeLawyerContext>, DataContextFactory>();
            builder.Services.AddScoped<NotificationService>();

            await builder.Build().RunAsync();
        }
    }
}
