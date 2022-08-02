using System;

namespace No7
{
    class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine("Hello World!");
            Console.Write("Enter number to be reversed: ");
            int reverseNum = int.Parse(Console.ReadLine());

            DoReverse(reverseNum);
        }
        public static void DoReverse(int a)
            {
                int k = 0;
                for(int i = 10; i > 0; a = i)
                    {
                        k = a % 10;
                        i = a / 10;
                        Console.Write(k + " ");
                    }
            }
    }
}
