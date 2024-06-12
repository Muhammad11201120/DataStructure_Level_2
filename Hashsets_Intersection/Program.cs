using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hashsets_Intersection
{
    internal class Program
    {
        static void Main( string[] args )
        {
            HashSet<int> set1 = new HashSet<int> {
                1,2,3
            };
            HashSet<int> set2 = new HashSet<int> {
                3,4,5
            };

            set1.IntersectWith( set2 );

            foreach ( int i in set1 )
            {
                Console.WriteLine( i );
            }
            Console.ReadLine();
        }
    }
}
