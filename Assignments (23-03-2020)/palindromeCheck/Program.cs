using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace palindromeCheck
{
    class Program
    {
        static int numberToCheck;
        //for 1st solution un comment below variables
        //static int newNumber=0,reminder,number;
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number :");
            numberToCheck = int.Parse(Console.ReadLine());

            #region palindrome using while loop

            /* number = numberToCheck;
             while (number > 0)
             {
                 reminder = number % 10;
                 newNumber = (newNumber * 10) + reminder;
                 number = number / 10;
             }

             Console.WriteLine($"oldNUm={numberToCheck} newNum={newNumber}");

             if (numberToCheck == newNumber)
                 Console.WriteLine($"{newNumber} is palindrome because {numberToCheck} == {newNumber}");
             else
                 Console.WriteLine($"{numberToCheck} is not palindrome because {numberToCheck} != {newNumber}");*/

            #endregion

            #region using String

            /*string numString = numberToCheck.ToString();
            string reverseString = new string(numString.ToCharArray().Reverse().ToArray());
            Console.WriteLine($"number string = {numString} and rev string is {reverseString}");
            if (numString.Equals(reverseString))
                Console.WriteLine("palindrome");
            else
                Console.WriteLine("Not palindrome");*/

            #endregion
        }
    }
}
