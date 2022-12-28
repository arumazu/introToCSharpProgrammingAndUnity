using System;

namespace ConsoleApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // Temperature Conversions
            // Converting temperatures from Fahrenheit to Celsius and back again.

            double temperature;
            Console.Write("Enter temperature (F): ");
            temperature = double.Parse(Console.ReadLine());

            // To convert from Fahrenheit to Celsius:
            // Begin by subtracting 32 from the Fahrenheit temperature.
            // Divide the answer by 9.
            // Finally, multiply by 5 to get the Celsius temperature.
            temperature = ((temperature - 32) / 9) * 5;
            Console.WriteLine(temperature + " C");

            // To go convert Celsius to Fahrenheit:
            // Begin by multiplying the Celsius temperature by 9.
            // Divide the answer by 5.
            // Finally, add 32 to get the Fahrenheit temperature.
            temperature = ((temperature * 9) / 5) + 32;
            Console.WriteLine(temperature + " F");
        }
    }
}