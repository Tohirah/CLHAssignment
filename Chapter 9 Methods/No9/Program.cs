using System;

namespace No9
{
    class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine("Hello World!");

            Console.WriteLine("Enter length of your array");
                int lenArray = int.Parse(Console.ReadLine());
                int[] myArray = new int[lenArray];

                for(int j = 0; j < myArray.Length; j++)
                    {
                        Console.WriteLine("Enter your number");
                        myArray[j] = int.Parse(Console.ReadLine());
                    }
                
                DescendingNum(myArray);
        }
        public static void DescendingNum(int[] descArray)
        {
            int temp = 0;
            for(int i = 0; i < descArray.Length; i++)
                {
                    for(int j = i + 1; j < descArray.Length; j++)
                        {
                            if(descArray[i] < descArray[j])
                                {
                                    temp = descArray[i];
                                    descArray[i] = descArray[j];
                                    descArray[j] = temp;
                                }
                        }
                }
            for(int i = 0; i < descArray.Length; i++)
                {
                    Console.WriteLine(descArray[i]);
                }        
                
            Console.WriteLine("The biggest number is " + descArray[0]);
        }

    }
}
