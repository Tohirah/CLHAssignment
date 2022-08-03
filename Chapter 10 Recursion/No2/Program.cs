using System;

namespace No2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine("Hello World!");

            Console.WriteLine("Enter desired number");
            int argPrint = int.Parse(Console.ReadLine());

            Print(argPrint, argPrint);
        }
        public static void Print(int v, int n)
                { 
                    if(v > 1)
                        {
                        for(int i = 1; i <= n; i++)
                            {
                                Console.Write(n-(v-1) + " " + i + "  ");
                            }
                            Console.WriteLine(" ");
                        }
                        if(v == 1)
                        {
                        for(int i = 1; i <= n; i++)
                            {
                                Console.Write(n-(v-1) + " " + i + "  ");
                            }
                            return;
                        }
                    Print(v - 1, n);
                }
    }
}
