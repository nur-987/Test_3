using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{/// <summary>
/// Question 1
/// Lottery
/// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            Lottery lottery = new Lottery();
            lottery.ticketBought += Lottery_ticketBought;

            LotteryManager manager = new LotteryManager();
            manager.WinnerChosen += Manager_WinnerChosen;

            Console.WriteLine("Would You like to buy a lottery ticket? Y/N");
            string input = Console.ReadLine();
            if (input == "Y")
            {
                Console.WriteLine("Number Generating...." );
                lottery.Buy();
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("To the Manager: Choose a winner");
                manager.SelectWinner();
                Console.ReadLine();
            }


        }

        private static void Manager_WinnerChosen(int lotNum, string name)
        {
            //announces the winner
            Console.WriteLine("Winner is lottery number: " + lotNum);
            Console.WriteLine("Winner is: " + name);
        }

        private static void Lottery_ticketBought()
        {
            //informs the Lottery manager 
            //that a ticket has been bought
            Console.WriteLine("To Manager: A lottery ticket has been bought");

        }
    }
}
