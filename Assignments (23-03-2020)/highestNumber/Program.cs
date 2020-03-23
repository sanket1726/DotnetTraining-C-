//C# program to find largest number from 3 numbers

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments__23_3_2020_
{
    class Program
    {
        static int num1, num2, num3, max;
        static void Main(string[] args)
        {

            Console.WriteLine("Enter Num1 :");
            num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter Num2 :");
            num2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter Num3 :");
            num3 = int.Parse(Console.ReadLine());


            #region highest number using ternary operator

            /*max = num1 > num2 ? (num1 > num3 ? num1 : num3) : (num2 > num3 ? num2 : num3);
            Console.WriteLine($"Maximum number from 3 numbers is {max}");*/

            #endregion

            #region highest number using simple if-else

            /*if (num1 > num2 && num1 > num3)
            {
                Console.WriteLine($"Max num is {num1}");
            }
            else if (num2 > num1 && num2 > num3)
            {
                Console.WriteLine($"Max num is {num2}");
            }
            else
                Console.WriteLine($"Max number is {num3}");*/
            #endregion

            #region highest number using nested if else
            /*if (num1 > num2)
            {
                if (num1 > num3)
                    max = num1;
                else
                    max = num3;
            }
            else if (num2 > num3)
            {
                max = num2;
            }
            else
                max = num3;

            Console.WriteLine($"max number is {max}");*/
            #endregion


        }
    }
}
