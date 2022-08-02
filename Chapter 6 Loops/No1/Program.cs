using System;

namespace No1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine("Hello World!");

            Console.WriteLine("Enter desired number");
            int numN = int.Parse(Console.ReadLine());

            for (int i = 1; i <= numN; i++)
                {
                    Console.WriteLine(i);
                }
        }
    }
}
