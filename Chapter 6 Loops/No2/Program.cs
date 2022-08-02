using System;

namespace No2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine("Hello World!");

            Console.WriteLine("Enter desired number");
            int numDiv = int.Parse(Console.ReadLine());

            int ij = 1;

            while (ij <= numDiv)
                {
                    if( ij % (3 * 7) != 0)
                    {
                        Console.WriteLine(ij);
                         ij++;
                    }
                    else
                    {
                        ij++;
                    }   
                }
        }
    }
}
