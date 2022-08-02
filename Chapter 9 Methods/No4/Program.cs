using System;

namespace No4
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            int[] myArray = new int[] {4, 5, 6, 7, 8, 1, 7, 6, 4, 1, 5};

            Console.WriteLine("which number do you want to check?");
            int checkNum = int.Parse(Console.ReadLine());

            int returnCount = CountNum(myArray, checkNum);

            Console.WriteLine("The number " + checkNum + " appeared " + returnCount + " times");
        }
        public static int CountNum(int[] newArray, int a)
        {
            int count = 0;
            for(int i = 0; i < newArray.Length; i++)
                {
                    if(newArray[i] == a)
                        {
                            count++;
                        }
                }
            return count;
        }
    }
}
