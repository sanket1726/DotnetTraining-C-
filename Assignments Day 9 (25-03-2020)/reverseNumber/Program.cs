using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace reverseNumber
{
    class Program
    {
        #region variable declaration
        static int number,quotient,reminder,revNumber=0;
        static char temp;
        #endregion
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number ");
            number = int.Parse(Console.ReadLine());

            #region first method using number division
            /*quotient = number;
            while (quotient > 0)
            {
                reminder = quotient % 10;
                quotient = quotient / 10;
                revNumber = (revNumber * 10) + reminder;
            }
            Console.WriteLine($"Reverse of {number} is {revNumber}");*/
            #endregion

            #region using swapping 
            /*char[] numCharArray = number.ToString().ToCharArray();
            if((numCharArray.Length)%2 == 0)
            {
                for (int i = 0; i <= (numCharArray.Length/2)-1; i++)
                {
                        temp = numCharArray[i];
                        numCharArray[i] = numCharArray[numCharArray.Length-1-i];
                        numCharArray[numCharArray.Length - 1 - i] = temp; 
                }
            }

            var revNumberString = new string(numCharArray);
            int revNumber = int.Parse(revNumberString);
            Console.WriteLine($"Reverse of {number} is {revNumber}");*/
            #endregion
        }
    }
}
