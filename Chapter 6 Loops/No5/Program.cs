using System;

namespace No5
{
    class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine("Hello World!");

            Console.WriteLine("Enter number of fibonacci sequence");
            int fibs = int.Parse(Console.ReadLine());

            int fibs1 = 0;
            int fibs2 = 1;
            int k;
            Console.Write(fibs1 + ", " + fibs2 + ", ");

            for(int i = 3; i <= fibs; i++)
            {
                k =  fibs1 + fibs2;
                Console.Write(k + ", ");
                // temp = fibs1;
                fibs1 = fibs2;
                fibs2 = k;
            }
        }
    }
}
