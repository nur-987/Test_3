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
    
    delegate void MyDelegate(object x, out object y);

    class Program
    {
        static void Main(string[] args)
        {
            FirstClass myClass = new FirstClass();
            SecondClass myClass2 = new SecondClass();
            ThirdClass myClass3 = new ThirdClass();
            MyDelegate myDel = new MyDelegate(myClass.Print);
            myDel += myClass2.Print2;
            myDel += myClass3.Print3;

            //not sure how to allow delegate to accept multiple types. 
        }
    }
    class FirstClass
    {
        public void Print(object i, out object x)
        {
            x = (int)i;

            Console.WriteLine(x);
            
        }
    }

    class SecondClass
    {
        public void Print2(object str, out object newS)
        {
            newS = (string)str;
            Console.WriteLine(newS);
            
        }
    }
    class ThirdClass
    {
        public void Print3(object dbl, out object newDbl)
        {
            newDbl = (double)dbl;
            Console.WriteLine(newDbl);

        }
    }
}
