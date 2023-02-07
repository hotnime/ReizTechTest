using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int MINUTES_PER_HOUR = 60;
            const int DEGREES_IN_CIRCLE = 360;

            int hours, minutes;

            Console.Write("Enter the hours (0-12): ");
            hours = int.Parse(Console.ReadLine());
            while (hours < 0 || hours > 12)
            {
                Console.WriteLine("Invalid input. Hours must be between 0 and 12.");
                Console.Write("Enter the hours (0-12): ");
                hours = int.Parse(Console.ReadLine());
            }

            Console.Write("Enter the minutes (0-60): ");
            minutes = int.Parse(Console.ReadLine());
            while (minutes < 0 || minutes > 60)
            {
                Console.WriteLine("Invalid input. Minutes must be between 0 and 60.");
                Console.Write("Enter the minutes (0-60): ");
                minutes = int.Parse(Console.ReadLine());
            }

            double hourAngle = 0.5 * (MINUTES_PER_HOUR * hours + minutes);
            double minuteAngle = 6 * minutes;
            double angle = Math.Abs(hourAngle - minuteAngle);

            if (angle > DEGREES_IN_CIRCLE / 2)
            {
                angle = DEGREES_IN_CIRCLE - angle;
            }

            Console.WriteLine($"The lesser angle between the hour and minute arrows is {angle} degrees.");     
        }
    }
}
