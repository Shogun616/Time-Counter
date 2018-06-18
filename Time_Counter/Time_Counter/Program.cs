using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Time_Counter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Add in time in minutes: ");
            string input = Console.ReadLine();

            int Hour = int.Parse(input) / 60;
            int Minute = int.Parse(input) - (Hour * 60);

            string HourText = Hour == 1 ? "Hour" : "Hours";
            string MinuteText = Minute == 1 ? "Minute" : "Minutes";

            Console.WriteLine("Its " + Hour + " " + HourText + " " + "And " + Minute + " " + MinuteText);

            Console.WriteLine("Enter any key to exit...");
            Console.ReadLine();
        }
    }
}
