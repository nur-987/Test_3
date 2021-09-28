using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question6
{
    class MyArray
    {
        int[] myArray = new int[10] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

        public void GetElement(int i)
        {
            try
            {
                Console.WriteLine(myArray[i]);

            }
            catch (IndexOutOfRangeException)
            {
                Console.WriteLine("The index provided does not exist");

            }
            catch (Exception ex)
            {
                Console.WriteLine($"Exception{ex.Message}");
            }

        }

        public void Division(int a, int b)
        {
            try
            {
                int res = a / b;
                Console.WriteLine("Answer is: " + res);
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine($"Exception{ex.Message}");
                Console.WriteLine("Cannot divide number by zero");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Exception{ex.Message}");
            }
        }

        public char StringCheck(string str, int i)
        {
            char c = 'a';
            try
            {
                int num = str.Length;
                Console.WriteLine("Number of characters in that word: " + num);

                c = str.ElementAt(i);
                Console.WriteLine("the character at index chosen: " + c);

            }
            catch (NullReferenceException ex)
            {
                Console.WriteLine($"Exception{ex.Message}");
            }
            catch (IndexOutOfRangeException ex)
            {
                Console.WriteLine($"Exception{ex.Message}");
            }
            catch (FormatException ex)
            {
                Console.WriteLine($"Exception{ex.Message}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Exception{ex.Message}");
            }
            return c;


        }
    }
}
