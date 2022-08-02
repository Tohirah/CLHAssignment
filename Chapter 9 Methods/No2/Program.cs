using System;

namespace No2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            Console.WriteLine("Enter first number");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter second number");
            int b = int.Parse(Console.ReadLine());

            GetMax(a, b);
            Console.WriteLine("Enter third number");
            int c = int.Parse(Console.ReadLine());            

            int maxNum = GetMax(GetMax(a, b), c);
            Console.WriteLine("The biggest number is " + maxNum);

        }
        public static int GetMax(int a, int b)
            { 
                int max =0;
                if(a > b)
                    {
                        max = a;
                    }
                else
                    {
                        max = b;
                    }
                    return max;
            }
    }
}
