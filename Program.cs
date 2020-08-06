using System;

namespace MilesToFeet
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            
            float miles = 4.5f;
            const int MILES_RATIO = 5280;
            const int INCHES_RATIO = 63360;

            Console.WriteLine("{0:F2} miles = {1} feet", miles, miles * MILES_RATIO);
            Console.WriteLine("{0:F2} miles = {1} inches", miles, miles * INCHES_RATIO);

            Console.WriteLine("*********************************************************");
            Console.ReadLine();
        }
    }
}
