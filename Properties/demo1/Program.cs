//In this code we will see why porperties

/*the programming languages who do not support properties use getters and setters to modify and access
    fields
    but in C# provides us of use properties
 */

 //This code simply shows modifications and adding some rules to fields using getters and setters

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demo1
{

    public class Student
    {
        private int _id;
        private string _Name;
        
        public void SetId(int id)
        {
            if (id <= 0)
                throw new Exception("Id cannot be -ve or 0");
            this._id = id;
        }

        public int GetId()
        {
            return this._id;
        }

        public void SetName(string Name)
        {
            if (string.IsNullOrEmpty(Name) || string.IsNullOrWhiteSpace(Name))
                throw new Exception("Name cannot be empty or null or whitespace");
            this._Name = Name;
        }

        public string GetName()
        {
            return string.IsNullOrEmpty(this._Name)     ?   "No name"   :  this._Name;
        }

        /* public int StudentId
         {
             get { return this._id; }
             set {
                 if (_id <= 0)
                     throw new Exception("It cannot be 0");
                 this._id = value;
             }
         }*/


    }


    class Program
    {
        static void Main(string[] args)
        {
            Student s = new Student();
            s.SetName("Sanket");
            Console.WriteLine($"{s.GetId()} {s.GetName()}");

        }
    }
}
