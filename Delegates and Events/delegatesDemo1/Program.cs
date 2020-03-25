using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace delegatesDemo1
{
    delegate bool IsPromotable(Employee empl);
    class Employee
    {
        public int ID { get; set; }
        public string Name { get; set; }

        public int Salary { get; set; }
        public int Experience { get; set; }

        public static void PromoteEmployee(List<Employee> employeeList, IsPromotable IsElibigbleToPromote)
        {
            foreach (Employee employee in employeeList)
            {
                if (IsElibigbleToPromote(employee))
                    Console.WriteLine($"{employee.Name} promoted with salary of 10% hike new salary={employee.Salary=(int)(employee.Salary*0.10)+employee.Salary}"); 
            }
        }
    }
    class Program
    {

        //OPtion to this method we can use lambda expression
        /*public static bool Promote(Employee emp)
        {
            if (emp.Experience >= 5)
                return true;
            else
                return false;
        }*/
        static void Main(string[] args)
        {
            List<Employee> empList = new List<Employee>();
            empList.Add(new Employee() { ID=101,Name="Sanket",Salary=41000,Experience=1 });
            empList.Add(new Employee() { ID = 101, Name = "Omkar", Salary = 41000, Experience = 1 });
            empList.Add(new Employee() { ID = 102, Name = "Rushi", Salary = 38000, Experience = 2 });
            empList.Add(new Employee() { ID = 103, Name = "Shantanu", Salary = 41000, Experience = 1 });
            empList.Add(new Employee() { ID = 104, Name = "Vivek", Salary = 40250, Experience = 6 });
            empList.Add(new Employee() { ID = 105, Name = "Akanksha", Salary = 25000, Experience = 3 });
            empList.Add(new Employee() { ID = 106, Name = "Akshay", Salary = 40000, Experience = 2 });
            empList.Add(new Employee() { ID = 107, Name = "ABC", Salary = 34000, Experience = 8 });
            empList.Add(new Employee() { ID = 108, Name = "XYZ", Salary = 50000, Experience = 9 });
            empList.Add(new Employee() { ID = 109, Name = "LMN", Salary = 45000, Experience = 7 });

            //IsPromotable isPromotable = new IsPromotable(Promote);

            // actually runtime creates a delegate creates a function 
            // and then passess it to specific method
            Employee.PromoteEmployee(empList, emp => emp.Experience >= 5);
        }
    }
}
