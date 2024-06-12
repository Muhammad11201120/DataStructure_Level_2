using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hashset_Difference_Operation
{
    internal class Program
    {
        static void Main( string[] args )
        {
            HashSet<int> set1 = new HashSet<int> { 1, 2, 3, 4 };
            HashSet<int> set2 = new HashSet<int> { 4, 5, 6, 7 };

            //removing elements of set2 from set1
            set1.ExceptWith( set2 );

            foreach ( int i in set1 )
            {
                Console.WriteLine( i );
            }
            Console.ReadLine();
        }
    }
}
