//Program to check whether number is prime or not
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace primeNumber
{
    //Delegate Declaration
    public delegate void PrimeNumberCheck(int n);
    class Program
    {
        //Variables declaration
        static int numberToCheck,flag=0;
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number you want to check whether its prime or not :");
            numberToCheck = int.Parse(Console.ReadLine());

            //Object creation of Delegate
            PrimeNumberCheck primeNumberCheck = new PrimeNumberCheck(PrimeCheck);
            primeNumberCheck(numberToCheck);
        }

        public static void PrimeCheck(int number)
        {
            for (int i = 2; i <= 9; i++)
            {
                if ((number % i) == 0)
                {
                    Console.WriteLine($"{number} Number is not prime ");
                    Console.WriteLine($"{number} is divisible by {i} initially");
                    flag = 1;
                    break;
                }
            }
            if(flag==0)
                Console.WriteLine($"{number} is prime number");
        }
    }
}
