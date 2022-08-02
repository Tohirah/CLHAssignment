using System;

namespace No10
{
    class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine("Hello World!");

            Console.WriteLine("Enter the matrix dimension");
            int matrixDimension = int.Parse(Console.ReadLine());

            for(int y = 1; y <= matrixDimension; y++)
            {
                for(int z = y; z < y + matrixDimension; z++)
                {
                    Console.Write(z + " ");
                }
                Console.WriteLine("");
            }
        }
    }
}
