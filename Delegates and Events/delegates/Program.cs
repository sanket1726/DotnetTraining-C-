//Delegates are reference types

/*
 They are nothing but a type safe fucntion pointer      
 >> syntax : public/private/protected/ delegate(keyword) return_type Delegate_Name(return_type param_Name);
 >> rules : delegate who is going to invole the method both should have
            same return type  and same param_type
 >> objectCreations : DelegateName obj = new DelegateName(method_Name);
 >> invoking : obj(params);
   
  */



using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace delegates
{
    public delegate void HelloFunctionDelegate(string Message);
    public delegate int HelloInteger(int numberTo);
    class Program
    {
        public static void Hello(string strMessage)
        {
            Console.WriteLine(strMessage);
        }

        public static int NumberDisplay(int number)
        {
            return number * number;
        }

        static void Main(string[] args)
        {
            HelloFunctionDelegate del = new HelloFunctionDelegate(Hello);
            del("This is a call to Hello method using HelloFunctionDelegate");

            HelloInteger hel = new HelloInteger(NumberDisplay);
            int n = hel(12);
            Console.WriteLine(n);
        }
    }
}
