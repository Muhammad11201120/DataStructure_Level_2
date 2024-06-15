using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays_With_Linq
{
    internal class Program
    {
        static void Main( string[] args )
        {
            var People = new[]
            {
                new{Name = "Muhammed", Age = 31},
                new {Name = "Fahad", Age = 43},
                new {Name = "Rami", Age = 63},
                new {Name = "Salem", Age = 13},
                new {Name = "Jamal", Age = 43},
                new {Name = "Karim", Age = 31},
                new {Name = "Maha", Age = 13},
            };

            //grouping with age then ordering within each group
            var GroupedByAge = People.GroupBy( p => p.Age ).Select( group => new
            {
                age = group.Key,
                people = group.OrderBy( p => p.Name )
            } );
            foreach ( var group in GroupedByAge )
            {
                Console.WriteLine( "==============" );
                Console.WriteLine( $"Age Group: {group.age}" );
                foreach ( var person in group.people )
                {
                    Console.WriteLine( $" - {person.Name}" );
                }
            }
            Console.WriteLine( "==============" );
            Console.ReadLine();
        }
    }
}
