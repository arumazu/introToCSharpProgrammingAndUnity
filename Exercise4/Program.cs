using System;

namespace ConsoleApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // Prompt for and get the altitude for a location as an int.
            // Prompt for and get the altitude for a second location as an int.
            // Calculate and display the altitude change you'd experience moving from the first point to the second point.
            Console.WriteLine("Enter first altitude: ");
            int firstAltitude = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter seconfd altitude: ");
            int secondAltitude = int.Parse(Console.ReadLine());

            Console.Write("Altitude change is: ");
            Console.WriteLine(secondAltitude - firstAltitude);
        }
    }
}