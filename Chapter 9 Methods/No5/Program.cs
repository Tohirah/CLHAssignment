using System;

namespace No5
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
                
                Console.WriteLine(DiffBtwIndex(myArray, 2));
        }
        public static bool DiffBtwIndex(int[] diffArray, int r)
            {
                        if(r == 0 && diffArray[r] > diffArray[r+1])
                                    {
                                        return true;
                                    }
                            
                        else if(r == diffArray.Length - 1 && diffArray[r] > diffArray[r-1])
                                    {
                                        return true;
                                    }
                            
                        else if(r > 0 && r < diffArray.Length - 1 && diffArray[r] > diffArray[r-1] && diffArray[r] > diffArray[r+1])
                                    {
                                        return true;
                                    }
                        else
                            {
                                return false;
                            }
            }

    }
}
