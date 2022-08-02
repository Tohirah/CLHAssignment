using System;

namespace No6
{
    class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine("Hello World!");

            int[] greaterIndex = new int[] {2,3,4,5,6,2};

        Console.WriteLine("The index of the number " + greaterIndex[FirstDiffBtwIndex(greaterIndex)] + " is " + FirstDiffBtwIndex(greaterIndex));
        }

        public static int FirstDiffBtwIndex(int[] diffArray)
            {
                for(int i = 0; i < diffArray.Length; i++)
                    {
                        if(i == 0 && diffArray[i] > diffArray[i+1])
                            {
                                return i;
                            }
                            
                        else if(i == diffArray.Length - 1 && diffArray[i] > diffArray[i-1])
                            {
                                return i;
                            }
                            
                        else if(i > 0 && i < diffArray.Length - 1 && diffArray[i] > diffArray[i-1] && diffArray[i] > diffArray[i+1])
                            {
                                return i;
                            }
                    }
                 return -1;
                        
            }
    }
}
