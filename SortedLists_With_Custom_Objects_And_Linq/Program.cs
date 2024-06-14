using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortedLists_With_Custom_Objects_And_Linq
{
    class Employee
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Department { get; set; }
        public decimal Salary { get; set; }

        public Employee( int id, string name, string department, decimal salary )
        {
            ID = id;
            Name = name;
            Department = department;
            Salary = salary;
        }
    }
    internal class Program
    {
        static void Main( string[] args )
        {
            SortedList<int, Employee> sortedEmp = new SortedList<int, Employee>
            {
                {1,new Employee(1,"Muhammed","HR",50000)},
                {2,new Employee(2,"Ahmed","IT",20032)},
                {3,new Employee(3,"Sami","IT",40000)},
                {4,new Employee(4,"Fahad","IT",20000)},
                {5,new Employee(5,"Saeed","Markiting",30000)}
            };
            //filtring with linq
            var query = sortedEmp.Where( n => n.Value.Department == "IT" ).OrderByDescending( n => n.Value.Salary ).Select( n => n.Value.Name );
            foreach ( var emp in query )
            {
                Console.WriteLine( emp );
            }
            Console.ReadLine();
        }
    }
}
