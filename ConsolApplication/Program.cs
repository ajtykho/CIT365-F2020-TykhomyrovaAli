using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace ConsolApplication
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //CreateHostBuilder(args).Build().Run();

            Console.WriteLine(
                "What's your name?");
            string yourName = Console.ReadLine();
            Console.WriteLine("Where are you from?");
            string yourLocation = Console.ReadLine();
            string result = $"My name is {yourName}, I am from {yourLocation}.";
            Console.WriteLine(result);

            Console.ReadKey();


        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}
