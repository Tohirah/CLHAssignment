using System;

namespace No16
{
    class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine("Hello World!");

            Console.WriteLine("Enter the range of the random number");
            int rangeRand = int.Parse(Console.ReadLine());

            for(int i = 1; i <= rangeRand; i++)
                {
                    Random rand = new Random();
                    Console.WriteLine(rand.Next(1, rangeRand));
                }
        }
    }
}
