using System;

namespace No4
{
    class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine("Hello World!");

            bool isDefault = false;
            string response = "no";
            do
                {
                Console.WriteLine("Types a number from 2 to 14 to guess the number or alphabet on the card ");
                int cardnum = int.Parse(Console.ReadLine());

                switch(cardnum)
                {
                    case 2:
                    cardnum = 2;
                    break;
                    case 3:
                    cardnum = 3;
                    break;
                    case 4:
                    cardnum = 4;
                    break;
                    case 5:
                    cardnum = 5;
                    break;
                    case 6:
                    cardnum = 6;
                    break;
                    case 7:
                    cardnum = 7;
                    break;
                    case 8:
                    cardnum = 8;
                    break;
                    case 9:
                    cardnum = 9;
                    break;
                    case 10:
                    cardnum = 10;
                    break;
                    case 11:
                    cardnum = 'J';
                    break;
                    case 12:
                    cardnum = 'Q';
                    break;
                    case 13:
                    cardnum = 'K';
                    break;
                    case 14:
                    cardnum = 'A';
                    break;
                    default:
                    isDefault = true;
                    Console.WriteLine("Invalid input");
                    break;
                }
                if(isDefault)
                {
                    Console.WriteLine("Do you want to play again?");
                    response = Console.ReadLine().ToLower();
                }
                else
                {
                    Console.WriteLine("Types a number from 1 to 4 to guess the shape on the card ");
                    int cardshapenum = int.Parse(Console.ReadLine());

                    string cardshape = "";

                switch(cardshapenum)
                {
                    case 1:
                    cardshape = "club";
                    break;
                    case 2:
                    cardshape = "diamond";
                    break;
                    case 3:
                    cardshape = "heart";
                    break;
                    case 4:
                    cardshape = "spades";
                    break;
                    default:
                    isDefault = true;
                    Console.WriteLine("Invalid input");
                    break;
                }
                if(isDefault)
                {
                    Console.WriteLine("Do you want to play again?");
                    response = Console.ReadLine().ToLower();
                }
                else
                {
                    Console.WriteLine("The guessed card is " + cardnum + ", " + cardshape);
                    Console.WriteLine("Do you want to play again?");
                    response = Console.ReadLine().ToLower();
                }
                }

            } while(response == "yes");

        }
    }
}
