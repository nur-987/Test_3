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
        public long LotteryNumber { get; private set; }

        public string Name { get; set; }

        public static List<Lottery> SoldLotteries = new List<Lottery>();

        //public Lottery(long lotNum, string name)
        //{
        //    LotteryNumber = lotNum;
        //    Name = name;
        //}

        public event Ticket ticketBought;


        public void Buy()
        {
            //assigns a number
            Random myRandom = new Random();
            long randomNum = myRandom.Next();

            Console.WriteLine("What is your name?");
            string tempName = Console.ReadLine();

            Console.WriteLine("What is your ID?");
            int tempID = Int32.Parse(Console.ReadLine());

            //Gives the num to customer 
            Console.WriteLine("Your lottery number is: " + randomNum);

            Lottery lot = new Lottery();
            lot.LotteryId = tempID;
            lot.LotteryNumber = randomNum;
            lot.Name = tempName;

            //adds to the list of lott bought
            SoldLotteries.Add(lot);

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
            if (SoldLotteries.Count == 20)
            {
                //choose a winner id
                Random myRandom = new Random();
                int winner = myRandom.Next(1, 20);

                //from the winner id => winner name & lottery num
                //search from the list
                foreach (Lottery item in SoldLotteries)
                {
                    if (item.LotteryId == winner)
                    {
                        //raise event that winner was chosen
                        if (WinnerChosen != null)
                        {
                            WinnerChosen.Invoke(winner, item.Name);
                            //should invoke lott number and name
                        }
                    }
                }



            }
            else
            {
                Console.WriteLine("Lotteries not above 20 yet. Cannot choose a winner");
            }
        }
    }


}
