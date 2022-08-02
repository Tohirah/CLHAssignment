using System;

namespace No11
{
    class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine("Hello World!");

            Console.WriteLine("Enter the desired factorial");
            int factorialRange = int.Parse(Console.ReadLine());

            long factorial = 1;
            int count = 0;

                for(int i = factorialRange; i <= factorialRange && i > 0; i--)
                {
                    factorial *=i;
                }
                for(long checkZero = factorial; checkZero <= factorial; )
                {
                    checkZero = factorial / 10;
                    long newNum = factorial % 10;
                    factorial = checkZero;
                    if (newNum == 0)
                    {
                        count++;
                    }
                    else if(newNum != 0)
                    {
                        break;
                    }
                }
                Console.WriteLine("The number of zeros in this factorial is " + count);

        }
    }
}
