using System;

namespace YieldOperator
{
    class Program
    {
        static void Main(string[] args)
        {
            Week week = new Week();

            Console.WriteLine("Europe week:");

            foreach (var d in week)
            {
                Console.WriteLine(d);
            }

            Console.WriteLine("\nAmerican week:");

            foreach (var d in week.GetAmericanWeek())
            {
                Console.WriteLine(d);
            }

            Console.Read();
        }
    }
}
