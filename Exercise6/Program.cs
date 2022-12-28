using System;

namespace ConsoleApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // Prompt for and get an angle in degrees and store it in a float variable.
            //Calculate and display the cosine and sine of the angle.
            float angle;
            float cosine;
            float sine;

            //Read angle in degree
            Console.Write("Enter angle: ");
            angle = float.Parse(Console.ReadLine());

            // Convert to radian
            angle = angle * (float)Math.PI / 180;

            //Write Cos in radian
            cosine = (float)Math.Cos(angle);
            Console.WriteLine("Cos: " + cosine);

            // Write Sin in radian
            sine = (float)Math.Sin(angle);
            Console.WriteLine("Sin: " + sine);

        }
    }
}