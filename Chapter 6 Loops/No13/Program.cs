using System;

namespace No13
{
    class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine("Hello World!");

            Console.WriteLine("Enter the binary digits");
            int BinaryNum = int.Parse(Console.ReadLine());

            string BinaryString = BinaryNum.ToString();
            double sumBinary = 0;
            double BinaryDigits = 0;
            int k = 0;
            
            for(int i = BinaryString.Length - 1; i >= 0; i--)
            {
                if(int.Parse(BinaryString[i].ToString()) >= 2)
                    {
                        Console.WriteLine("This number is not in base 2");
                        sumBinary = 0;
                        break;
                    }
                    
                else
                    {
                                BinaryDigits = int.Parse(BinaryString[i].ToString()) * Math.Pow(2, k);
                                k++;
                        sumBinary +=BinaryDigits;
                            
                    }
            }
            Console.WriteLine(sumBinary);
            
        }
    }
}
