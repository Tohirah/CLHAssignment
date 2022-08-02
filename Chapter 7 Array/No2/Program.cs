using System;

namespace No2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine("Hello World!");

            Console.WriteLine("Enter the length of the first array");
            int arrayLength1 = int.Parse(Console.ReadLine());

            int[] equalArray1 = new int[arrayLength1];

            // collecting elements of the first array
            for(int j = 0; j < equalArray1.Length; j++)
            {
                Console.WriteLine("Enter array elements for first array");
                equalArray1[j] = int. Parse(Console.ReadLine());
            }

            Console.WriteLine("Enter the length of the second array");
            int arrayLength2 = int.Parse(Console.ReadLine());

            //Second array
            int[] equalArray2 = new int[arrayLength2];

            // collecting elements of the second array
            for(int j = 0; j < equalArray2.Length; j++)
            {
                Console.WriteLine("Enter array elements for second array");
                equalArray2[j] = int.Parse(Console.ReadLine());
            }
            bool equalArray = true;
            if(equalArray1.Length == equalArray2.Length)
                {
                    for(int k = 0; k < equalArray1.Length; k++)
                        {
                            if(equalArray1[k] != equalArray1[k])
                            {
                                equalArray = false;
                                break;
                            }
                        }
                }
            else
                {
                    equalArray = false;
                }
            Console.WriteLine("Are the two arrays equal?: " + equalArray );
        }
    }
}
