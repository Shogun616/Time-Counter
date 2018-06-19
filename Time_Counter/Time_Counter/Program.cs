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
            Console.Write("Insert the amount of time in minutes: ");
            string input = Console.ReadLine();

            int Year = int.Parse(input) / 518400;
            int Month = int.Parse(input) / 43200;
            int Day = int.Parse(input) / 1440;
            int Hour = (int.Parse(input) - (Day * 1440))/ 60;
            int Minute = (int.Parse(input) - ((Day * 24 * 60) + (Hour * 60)));

            string YearText = Year == 1 ? "Year" : "Years";
            string MonthText = Month == 1 ? "Month" : "Months";
            string DayText = Day == 1 ? "Day" : "Days"; 
            string HourText = Hour == 1 ? "Hour" : "Hours";
            string MinuteText = Minute == 1 ? "Minute" : "Minutes";

            Console.WriteLine("The total time is " + " " + Year + " " + YearText+ " " + " " + Month + " " + MonthText + " " + Day + " " + 
                DayText + " " + Hour + " " + HourText + " " + "And " + Minute + " " + MinuteText);

            Console.WriteLine("Enter any key to exit...");
            Console.ReadLine();
        }
    }
}
