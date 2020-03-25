using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace enumDemo1
{
    class Program
    {
        static void Main(string[] args)
        {
            string gender;
            Gender g= Gender.FEMALE;
            Console.WriteLine(g);
        }
    }

    public enum Gender
    {
        MALE,
        FEMALE
    }
}
