using System;

namespace No3
{
    class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine("Hello World!");

            Console.WriteLine("How many numbers do you want to compare");
            int numCount = int.Parse(Console.ReadLine());

            int smallest = 0;
            int largest = 0;

            for(int i = 0; i <= numCount; i++)
                {
                    Console.WriteLine("Enter the next number");
                    int num = int.Parse(Console.ReadLine());
                    if(i == 0)
                    {
                        smallest = num;
                        largest = num;
                    }
                    else if(num < smallest)
                    {
                        smallest = num;
                    }
                    else if(num > largest)
                    {
                        largest = num;
                    }
                }
            Console.WriteLine("The smallest number is " + smallest);
            Console.WriteLine("The largest number is " + largest);

        }
    }
}
