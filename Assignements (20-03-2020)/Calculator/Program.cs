using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            float num1, num2;
            float result = 0;
            string choice;
            Console.WriteLine("Basic Calculator Console Application \n");
            do
            {            
                Console.WriteLine("Enter number");
                num1 = float.Parse(Console.ReadLine());

                Console.WriteLine("select operation \n " + " + " + " - " + " * " + " / " + " % ");
                string arithOperator = Console.ReadLine();

                Console.WriteLine("Enter another number");
                num2 = float.Parse(Console.ReadLine());

                if (arithOperator.Equals("+"))
                    result = num1 + num2;
                else if (arithOperator.Equals("-"))
                    result = num1 - num2;
                else if (arithOperator.Equals("*"))
                    result = num1 * num2;
                else if (arithOperator.Equals("/"))
                    result = num1 / num2;
                else if (arithOperator.Equals("%"))
                    result = num1 % num2;
                else
                    Console.WriteLine("Wrong Input");

                Console.WriteLine($"Result is {result}");

                Console.WriteLine("0.Exit other for continue");
                choice =Console.ReadLine();


            } while (!choice.Equals("0"));




        }
    }
}
