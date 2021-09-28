using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Courier

{/// <summary>
/// Question 4
/// Write a sample c# prog for Courier sorting facility
/// </summary>
    class Program
    {
        
        static void Main(string[] args)
        {
            PackageManager pm = new PackageManager();
            bool b = true;

            Console.WriteLine("Welcome to Sorting Facility");
            while(b)
            {
                Console.WriteLine("what would you like to do?");
                Console.WriteLine("1) Receive       2) Dispatch          3)Display all      4)Quit");
                int input = Int32.Parse(Console.ReadLine());

                if (input == 1)
                {
                    Console.WriteLine("Input in tracking id");
                    int tempID = Int32.Parse(Console.ReadLine());
                    //add other params in seq.

                    pm.Receive(tempID);
                }
                else if (input == 2)
                {
                    Console.WriteLine("Input in tracking id");
                    int tempID = Int32.Parse(Console.ReadLine());

                    pm.Dispatch(tempID);
                }
                else if (input == 3)
                {
                    pm.DisplayAll();
                }
                else
                {
                    Console.WriteLine("Closing application");
                    b = false;
                }
            }
            
        }
    }
}
