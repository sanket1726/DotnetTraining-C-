//C# program to swap two numbers

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace swapping
{

    class Program
    {
        //Need Some guidance about code optimization

        #region for tuple and third var
        /*public Tuple<int, int , int> swapNumbers(int num1, int num2)
        {
            int temp;
            temp = num1;
            num1 = num2;
            num2 = temp;

            return Tuple.Create(num1, num2 , temp);
        
        }*/
        #endregion
        
        static int num1,num2;
        static void Main(string[] args)
        {

            #region Swap using third variable and tuple

            /*Console.WriteLine("Enter Number 1 : ");
            num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter Number 2 : ");
            num2 = int.Parse(Console.ReadLine());

            Console.WriteLine($"numbers before swapping are num1 = {num1} and num2 = {num2}");

            Program swapp = new Program();

            var swapped = swapp.swapNumbers(num1 , num2);

            Console.WriteLine($"numbers after swapping are num1 = {swapped.Item1} and num2 = {swapped.Item2}");*/

            #endregion

            #region swap using third variable simple method

            Console.WriteLine("Enter Number 1 : ");
            num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter Number 2 : ");
            num2 = int.Parse(Console.ReadLine());

            Console.WriteLine($"numbers before swapping are num1 = {num1} and num2 = {num2}");

            int temp = num1;
            num1 = num2;
            num2 = temp;
            GC.Collect(temp);
            Console.WriteLine($"numbers after swapping are num1 = {num1} and num2 = {num2}");


            #endregion

            #region swap without using third variable (Addition and Subtraction)

            /*Console.WriteLine("Enter Number 1 : ");
            num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter Number 2 : ");
            num2 = int.Parse(Console.ReadLine());

            Console.WriteLine($"numbers before swapping are num1 = {num1} and num2 = {num2}");

            num2 = num2 - num1;
            num1 = num1 + num2;
            num2 = num1 - num2;
            Console.WriteLine($"numbers after swapping are num1 = {num1} and num2 = {num2}");*/
            #endregion

        }
    }
}
