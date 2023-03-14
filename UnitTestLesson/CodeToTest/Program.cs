using System;

namespace CodeToTest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int timeOfDay = 21;
            Greeting(timeOfDay);

        }

        private static void Greeting(int timeOfDay)
        {
            if (timeOfDay >= 5 && timeOfDay <= 12)
            {
                Console.WriteLine("Good morning!");
            }
            else if (timeOfDay >= 12 && timeOfDay <= 18)
            {
                Console.WriteLine("Good afternoon!");
            }
            else
            {
                Console.WriteLine("Good evening!");
            }
        }
    }
}