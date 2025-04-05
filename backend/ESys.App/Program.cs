using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using System;
using System.Reflection;

namespace ESys.App
{
    public class Program
    {
        public static void Main(string[] args)
        {
            using var host = CreateHostBuilder(args)
                .Build();
#if DEBUG
            host.Start();
            Console.ReadLine();
            host.StopAsync().Wait();
#else
            host.Run();
# endif
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .Inject((b, c) =>
                {
#if DEBUG
                    c.AutoRegisterBackgroundService = false;
#endif
                })
                .ConfigureAppConfiguration((hostingContext, config) =>
                {
                    config.SetBasePath(AppContext.BaseDirectory);
                })
#if PRODUCTION
                .UseWindowsService()
#endif
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder
                      .Inject()
                      .UseContentRoot(System.IO.Path.GetDirectoryName(Assembly.GetEntryAssembly().Location))
#if PRODUCTION
                      .UseKestrel(opt =>
                      {
                          opt.ConfigureEndpointDefaults(options =>
                          {
                              //���Ի������𣬷�https��Ҫע��
                              options.UseHttps();
                          });
                      })
#endif
                      .UseStartup<Startup>();


                });
    }
}
