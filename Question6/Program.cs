using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question6
{
    class Program
    {
        static void Main(string[] args)
        {
            MyArray myarry = new MyArray();

            //Console.WriteLine("Which element would you like to see");
            //int i = Int32.Parse(Console.ReadLine());

            //myarry.GetElement(i);

            //Console.WriteLine("Lets divide 2 numbers. Input in first number");
            //int num1 = Int32.Parse(Console.ReadLine());
            //Console.WriteLine("Input in second number");
            //int num2 = Int32.Parse(Console.ReadLine());

            //myarry.Division(num1, num2);

            Console.WriteLine("Type a word");
            string input = Console.ReadLine();
            Console.WriteLine("Type a number");
            
            int j = Int32.Parse(Console.ReadLine());

            myarry.StringCheck(input, j);

            Console.ReadLine();

        }
    }
}
