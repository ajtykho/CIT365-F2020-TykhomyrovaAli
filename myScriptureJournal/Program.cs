using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using myScriptureJournal.Data;
using MyScriptureJournal.Models;
using RazorPagesScripture.Models;
using MyScriptureJournal;
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Hosting;

namespace myScriptureJournal
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var host = CreateWebHostBuilder(args).Build();

            using (var scope = host.Services.CreateScope())
            {
                var services = scope.ServiceProvider;

                try
                {
                    var context = services.
                        GetRequiredService<myScriptureJournalContext>();
                    context.Database.Migrate();
                    SeedData.Initialize(services);
                }
                catch (Exception ex)
                {
                    var logger = services.GetRequiredService<ILogger<Program>>();
                    logger.LogError(ex, "An error occurred seeding the DB.");
                }
            }

            host.Run();
        }
        public static IHostBuilder CreateWebHostBuilder(string[] args) =>
       Host.CreateDefaultBuilder(args).ConfigureWebHostDefaults(webBuilder =>
           {
               webBuilder.UseStartup<Startup>();
           });


    }
}

