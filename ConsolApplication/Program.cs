using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.VisualBasic.CompilerServices;

namespace ConsolApplication
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //Get to know you program

            //input: name and where from
            //output: your name and location in a sentence using console input

            Console.WriteLine(
                "What's your name?");
            string yourName = Console.ReadLine();
            Console.WriteLine($"Hello {yourName}! Where are you from?");

            string yourLocation = Console.ReadLine();
            string result = $"My name is {yourName}, I am from {yourLocation}.\r\n Press any key to continue...\r\n";

            Console.WriteLine(result);

            //wait until key press to continue
            Console.ReadKey();

            //Christmas countdown

            //output: how many days until Christmas

            //get current date and create christams date
            DateTime currentDate = DateTime.Today;
            DateTime christmas = new DateTime(2020, 12, 25);
            string stringDate = DateTime.Now.ToString("dd-MM-yyyy");

            //output current date, no time
            Console.WriteLine($"Today's date is {stringDate}");

            //subtract the two dates
            string countdown = (christmas - currentDate).TotalDays.ToString();

            //output Christmas countdown
            Console.WriteLine($"Only {countdown} day(s) until Christmas!\n");

            //Code from textbook

            //variables
            double width, height, woodLength, glassArea;
            string widthString, heightString;

            //Prompt the User for measurements

            //width prompt
            Console.WriteLine("Please Enter the Width: ");
            widthString = Console.ReadLine();

            //height prompt
            Console.WriteLine("Please Enter the Height: ");
            heightString = Console.ReadLine();

            //convert strings to doubles
            width = double.Parse(widthString);
            height = double.Parse(heightString);

            //calculations for area
            woodLength = 2 * (width + height) * 3.25;
            glassArea = 2 * (width * height);

            //Return and Report to the end users their calculations
            Console.WriteLine($"\nThe length of the wood is {woodLength} feet.\r\n The area of the glass is {glassArea} square meters.");


            //Wait until keypress to end the program
            Console.WriteLine("Hit any key to exit.");
            Console.ReadKey();


        }

        
    }
}
