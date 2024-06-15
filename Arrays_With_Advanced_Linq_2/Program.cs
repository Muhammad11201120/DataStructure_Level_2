using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays_With_Advanced_Linq_2
{
    internal class Program
    {
        static void Main( string[] args )
        {
            var Employees = new[]
            {
                new {Id = 1 , Name = "Muhammed", DepartmentID = 1},
                new {Id = 2 , Name = "Saeed", DepartmentID = 2},
                new {Id = 3 , Name = "Fahad", DepartmentID = 2}
            };
            var Departments = new[]
            {
                new {Id = 1, Name = "Human Sources"},
                new {Id = 2, Name = "Development"},
            };

            // joining two Arrays With Linq
            var employeesDetails = Employees.Join( Departments, e => e.DepartmentID, d => d.Id, ( e, d ) => new { name = e.Name, Department = d.Name, ID = e.Id } );

            foreach ( var item in employeesDetails )
            {
                Console.WriteLine( $"Employee ID : {item.ID} - Employee Name: {item.name} - Deparment : {item.Department}" );
            }
            Console.ReadLine();
        }
    }
}
