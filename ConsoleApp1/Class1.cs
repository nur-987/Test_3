using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    delegate void Ticket();
    delegate void Winner(int lotNum, string name);

    class Lottery
    {
        public int LotteryId { get; set; }
        public int LotteryNumber { get; private set; }

        public string Name { get; set; }

        public static List<Lottery> SoldLotteries = new List<Lottery>();

        public event Ticket ticketBought;


        public void Buy()
        {
            //assigns a number
            Random myRandom = new Random();
            long randomNum = myRandom.Next();

            //Gives the num to customer 
            Console.WriteLine("Your lottery number is: " + randomNum);

            //adds to the list of lott bought
            SoldLotteries.Add();

            //announces that a ticket has been bought
            if (ticketBought != null)
            {
                ticketBought.Invoke();
            }

        }

        
    }

    class LotteryManager
    {
        public event Winner WinnerChosen;
        public void SelectWinner()
        {
            if(SoldLotteries.Count == 20)
            {
                //choose a winner id
                Random myRandom = new Random();
                int winner = myRandom.Next(1, 20);

                //from the winner id => winner name & lottery num
                //search from the list
                

                //raise event that winner was chosen
                if (WinnerChosen != null)
                {
                    WinnerChosen.Invoke(winner, name);
                                //should invoke lott number and name
                }

            }
            else
            {
                Console.WriteLine("Lotteries not above 20 yet. Cannot choose a winner");
            }
        }
    }


}
