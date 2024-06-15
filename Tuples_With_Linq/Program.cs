using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tuples_With_Linq
{
    internal class Program
    {
        static void Main( string[] args )
        {
            List<(int id, string name, int age)> People = new List<(int id, string name, int age)>
            {
                (1,"Muhammed",30 ),
                (2,"Saeed",20),
                (3,"Rami",15)
            };
            var filter = People.Where( n => n.age > 15 );
            foreach ( var person in filter )
            {
                Console.WriteLine( $"Age Greater Than 15 : {person.name}" );
            }
            int agesAvreage = ( int ) People.Average( n => n.age );
            Console.WriteLine( $"Average Ages = {agesAvreage}" );
            Console.ReadKey();
        }
    }
}
