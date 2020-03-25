/*
 Delegate that is used to refer or invoke multiple methods is called
 multicast delegate

 or

 Multicast delegate is a delegate that has reference to  more than one function
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace multicastDelagates
{
    public delegate void SampleDelegate();
    public delegate int SampleIntDelegate();

    class Program
    {
        public static void SampleMethodOne()
        {
            Console.WriteLine("Sample method 1 invoked");
        }
        public static void SampleMethod2()
        {
            Console.WriteLine("Sample method 2 invoked");
        }
        public static int SampleMethod3()
        {
            return 1;
        }
        public static int SampleMethod4()
        {
            return 2;
        }
        static void Main(string[] args)
        {
            //1st way
            /*SampleDelegate del1, del2,del3,del4; 
            del1 = new SampleDelegate(SampleMethodOne);
            del2 = new SampleDelegate(SampleMethod2);
            del3 = new SampleDelegate(SampleMethod3);

            del4 = del1 + del2 - del3;
            del4();*/

            //2nd way
            SampleDelegate del = new SampleDelegate(SampleMethodOne);
            SampleIntDelegate del1 = new SampleIntDelegate(SampleMethod3);
            del += SampleMethod2;
            del1 += SampleMethod4;
            del();

            int returnedValue=del1();

            Console.WriteLine(returnedValue);
        }
    }
}
