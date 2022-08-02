using System;

namespace No11
{
    class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine("Hello World!");

            Console.WriteLine("Which operation do you want to perform? - enter 1 for number reverse, 2 for alculating average, 3 for calculating linear coefficient");
            int checkOps = int.Parse(Console.ReadLine());

            switch(checkOps)
            {
                case 1:
                DoReverse();
                break;
                case 2:
                CalcAverage();
                break;
                case 3:                
                LinearEquation();
                break;
                default:
                Console.WriteLine("Invalid input");
                break;
            }

        }
        public static void DoReverse(int a = 1)
            {
                Console.Write("Enter number to be reversed: ");
                a = int.Parse(Console.ReadLine());
                if(1 < a && a <50000000)
                    {
                        int k = 0;
                        for(int i = 10; i > 0; a = i)
                            {
                                k = a % 10;
                                i = a / 10;
                                Console.Write(k + " ");
                            }   
                    }
                else
                {
                    Console.WriteLine("Number is Out of Bound");
                }
                
            }
        public static void CalcAverage(int a = 1)
            {
                Console.WriteLine("How many numbers do you want to check?");
                int NumCount = int.Parse(Console.ReadLine());

                int[] realArray = new int[NumCount];

                for(int i = 0; i < realArray.Length; i++)
                    {
                        Console.WriteLine("Enter next number");
                        realArray[i] = int.Parse(Console.ReadLine());
                    }
                int totalSum = 0;
                foreach(int sumAll in realArray)
                    {
                        totalSum +=sumAll;
                    }
                float AverageNum = totalSum / realArray.Length;
                Console.WriteLine("The average of the numbers is " + AverageNum);
        }
        public static void LinearEquation(int a = 1, int x = 1, int c = 0)
            {
                Console.WriteLine("Enter coefficient a");
                a = int.Parse(Console.ReadLine());

                Console.WriteLine("Enter coefficient x");
                x = int.Parse(Console.ReadLine());

                Console.WriteLine("Enter coefficient b");
                c = int.Parse(Console.ReadLine());

                int calcEquation = 0;
                if(a == 0)
                    {
                        Console.WriteLine("Invalid Input");
                    }
                else
                {
                    calcEquation = (a * x) + c;
                }
                Console.WriteLine("The solution of the Linear Equation is " + calcEquation);
                
            }


    }
}
