using System;

namespace No1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine("Hello World!");

            Console.WriteLine("Enter the nth term");
            int n = int.Parse(Console.ReadLine());

            int k = n;
            NestedLoops(n, k);
        }
        static void NestedLoops(int index, int row)
        {
                if(row == 0)
                {
                    return;
                }

                NestedLoops (index, row - 1);

                for(int m = 1; m <= row; m++)
                {
                    Console.Write(m + " ");
                }
                Console.WriteLine("");
                
               
        }
    }
}
