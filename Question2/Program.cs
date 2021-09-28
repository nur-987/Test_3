using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question2
{
    /// <summary>
    /// Qustion2 
    /// Delegates
    /// </summary>
    
    delegate void MyDelegate(int x, out int);

    class Program
    {
        static void Main(string[] args)
        {
            FirstClass myClass = new FirstClass();
            MyDelegate myDel = new MyDelegate(myClass.Print);
            myDel += myClass.Print2;
            myDel += myClass.Print3;

            //not sure how to allow delegate to accept multiple types. 
        }
    }
    class FirstClass
    {
        public void Print(int i, out int x)
        {
            Console.WriteLine(i);
            x = i + 2;
        }
        public void Print2(string str, out string newS)
        {
            Console.WriteLine(str);
            newS = "Hello" + str;
        }
        public void Print3(double dbl, out double newDbl)
        {
            Console.WriteLine(dbl);
            newDbl = dbl * 100;
        }
    }
}
