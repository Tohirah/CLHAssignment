using System;

namespace No5
{
    class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine("Hello World!");

            Console.WriteLine("Enter length of your array");
                int length = int.Parse(Console.ReadLine());
                int[] myArray = new int[length];


                for(int hjk = 0; hjk < myArray.Length; hjk++)
                    {
                        Console.WriteLine("Enter your next number");
                        myArray[hjk] = int.Parse(Console.ReadLine());
                    }
            // int[] myArray = new int[]{3, 2, 3, 4, 2, 2, 4};

            int sameNum = 1;
            int maxSame = 1;
            int bestStart = 0;
            int lastElement = 0;

            for (int i = 0; i < myArray.Length - 1; i++)
            {
                if (myArray[i] + 1 == myArray[i + 1])
                {
                    sameNum++;
                    if (sameNum > maxSame)
                    {
                        maxSame = sameNum;
                        lastElement = i + 1;
                        bestStart = lastElement - maxSame + 1;
                    }
                }
                else sameNum = 1;
            }

            for (int i = bestStart; i < maxSame + bestStart; i++) 
            {
                Console.Write(myArray[i] + " ");
            }
        }
    }
}
