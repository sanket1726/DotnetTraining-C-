//C# program to print factorial of a number.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace factorialNumber
{
    class Program
    {
        static int number,factorial=1,i;
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number whose factorial you want to find");
            number = int.Parse(Console.ReadLine());
            i = number;
            while (i > 0)
            {
                factorial = (i--) * factorial;
                //i--;
            }

            Console.WriteLine($"Factorial of {number} is {factorial}");

        }
    }
}
