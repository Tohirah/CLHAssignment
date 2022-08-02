using System;

namespace No3
{
    class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine("Hello World!");
            Console.WriteLine("Enter the number");
            int LastNum = int.Parse(Console.ReadLine());

            Console.WriteLine("The last number is " + NumWords(LastNum));

        }
        public static string NumWords(int a)
            {
                int lastNum = a % 10;
                string words = "";

                switch(lastNum)
                {
                    case 0:
                    words = "Zero";
                    break;
                    case 1:
                    words = "One";
                    break;
                    case 2:
                    words = "Two";
                    break;
                    case 3:
                    words = "Three";
                    break;
                    case 4:
                    words = "Four";
                    break;
                    case 5:
                    words = "Five";
                    break;
                    case 6:
                    words = "Six";
                    break;
                    case 7:
                    words = "Seven";
                    break;
                    case 8:
                    words = "Eight";
                    break;
                    case 9:
                    words = "Nine";
                    break;
                    default:
                    Console.WriteLine("Invalid input");
                    break;
                }
                return words;
            }
    }
}
