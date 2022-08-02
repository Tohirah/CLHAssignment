using System;

namespace No1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            Console.WriteLine("What is your name?");
            string name = Console.ReadLine();

            GreetUser(name);
        }
        public static void GreetUser(string name)
            {
                Console.WriteLine($"Hello {name}!");
                
            }
    }
}
