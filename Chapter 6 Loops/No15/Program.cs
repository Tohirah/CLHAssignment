using System;

namespace No15
{
    class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine("Hello World!");

            Console.WriteLine("Enter the Hexadecimal number");
            string hexNum = Console.ReadLine();

            int DecimalNum = Convert.ToInt32(hexNum, 16);

            Console.WriteLine("The decimal equivalent is " + DecimalNum);
        }
    }
}
