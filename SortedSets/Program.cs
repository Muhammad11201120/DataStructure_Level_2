using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortedSets
{
    internal class Program
    {
        static void Main( string[] args )
        {
            SortedSet<int> list = new SortedSet<int>();
            list.Add( 1 );
            list.Add( 5 );
            list.Add( 4 );
            list.Add( 3 );
            list.Add( 2 );

            foreach ( int i in list )
            {
                Console.WriteLine( i );
            }
            Console.WriteLine( "---------------------------" );
            list.Remove( 1 );
            foreach ( int i in list )
            {
                Console.WriteLine( i );
            }


            Console.ReadLine();
        }
    }
}
