using System;

namespace No6
{
    class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine("Hello World!");

            Console.WriteLine("Enter the first factorial");
            int n1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the second factorial");
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
                 int ans = l / k;
                 Console.WriteLine(n1 + "! / " + n2 + "! = " + ans);
            }
            
            else
            {
                Console.WriteLine("First factorial is higher than second factorial");
            }

        }
    }
}
