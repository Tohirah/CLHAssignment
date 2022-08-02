using System;

namespace New10
{
    class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine("Hello World!");
            Console.WriteLine("Enter the factorial number");
            int nFactorial = int.Parse(Console.ReadLine());
            
            Factorial(nFactorial);
        }
        public static void Factorial(int a)
        {
            long k = 1;
             if(a <= 100)
                {
                    for(int i = a; i <= a && i > 0; i--)
                        {
                            k *=i;
                        }
                    Console.WriteLine("The factorial of " +  a + " is " + k);
                   
                }
            else
                {
                    Console.WriteLine("Invalid Input");
                }
            
            
        }
    }
}
