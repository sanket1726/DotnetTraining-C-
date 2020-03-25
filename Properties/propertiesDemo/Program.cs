//This code is about actual properties
//There are 4 types of properties in C#

/*1.Read/Write prop
2.ReadOnly prop --> only get prop
3.WriteOnly prop --> only set prop
4.Auto Implemented prop  //in C# 3.0*/



using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace propertiesDemo
{

    class Employee
    {
        private int _id;
        public int Id
        {
            get 
            {
                return this._id; 
            }
            set 
            {
                if (value <= 0)
                    throw new Exception("id cannot be 0 or -ve");
                this._id = value; 
            }
        }

        private string _Name;
        public string Name
        {
            get 
            {
                if (string.IsNullOrEmpty(_Name))
                    return "Name is not yet set";
                return this._Name; 
            }

            set 
            {
                if (string.IsNullOrEmpty(value))
                    throw new Exception("Name cannot be null or empty");
               this._Name = value;
            }
        }

        //auto propertry
        public int Salary { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Employee emp = new Employee();
            emp.Id = 100;
            Console.WriteLine(emp.Id + " "+ emp.Name + " " + emp.Salary);

        }
    }
}