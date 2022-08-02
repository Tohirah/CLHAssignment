using System;

namespace No8
{
    class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine("Hello World!");

            int[] myArray = new int[] {11, 8, 5, 10, 2};

            int smallest = 1;

            for(int j = 0; j < myArray.Length; j++)
                {
                    for(int i = j+1; i < myArray.Length; i++)
                    {
                        if(myArray[i] > myArray[j])
                        {
                            smallest = myArray[i];
                            myArray[i] = myArray[j];
                            myArray[j] = smallest; 
                        }
                    }

                }
            for(int j = 0; j < myArray.Length; j++)
                {
                Console.WriteLine(myArray[j]);
                }
        }
    }
}
