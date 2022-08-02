using System;

namespace No17
{
    class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine("Hello World!");

            Console.WriteLine("Enter the first number");
            int num1 = int.Parse(Console.ReadLine());


            Console.WriteLine("Enter the second number");
            int num2 = int.Parse(Console.ReadLine());

            //to find LCM
            int lcm = 0;
            if(num1 > num2)
            {
                lcm = num1;
            }
            else{
                lcm = num2;
            }
            do{
                if(lcm % num1 == 0 && lcm % num2 == 0)
                {
                    Console.WriteLine("The LCM of " + num1 + " and " + num2 + " is " + lcm);
                    break;
                }
                lcm++;
            }while(true);

        }
    }
}
