using System;

namespace No7
{
    class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine("Hello World!");

             Console.WriteLine("Enter the lower number factorial");
            int n1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the higher number factorial");
            int n2 = int.Parse(Console.ReadLine());

            int k = 1;
            int l = 1;

            if(1 < n1 && n1< n2)
            {
                for(int i = n1; i <= n1 && i > 0; i--)
                {
                    k *=i;
                }
            for(int m = n2; m <= n2 && m > 0; m--)
                {
                    l *=m;
                }
            int ans = k * l;
            float newans = ans/(n2 - n1);
            Console.WriteLine(n1 + "! * " + n2 + "! / (" + n2 + "-" + n1 + ") = " + newans);            
            }
            else
            {
                Console.WriteLine("First factorial is higher than second factorial");
            }
        }
    }
}
