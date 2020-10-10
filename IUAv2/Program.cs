using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using IUAv2.Data;
using IUAv2.Models;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace IUAv2
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var host = CreateHostBuilder(args).Build();//.Run();

            //Intializer App Secrets
            var configuration = host.Services.GetService<IConfiguration>();
            var hosting = host.Services.GetService<IWebHostEnvironment>();

            var secrets = configuration.GetSection("Secrets").Get<AppSecrets>();
            DbInit.appSecrets = secrets;


            using (var scope = host.Services.CreateScope())
                DbInit.SeedUsersAndRoles(scope.ServiceProvider).Wait();
            host.Run();

        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}
