using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashSet
{
    internal class Program
    {
        static void Main( string[] args )
        {
            int[] myArr = new int[]
            {
                1,2,3,3,3,4,4,5,5,6,6,7
            };
            HashSet<int> list = new HashSet<int>();
            list.Add( 1 );
            list.Add( 2 );
            list.Add( 3 );
            list.Add( 3 );
            list.Add( 4 );
            list.Add( 4 );
            list.Add( 5 );
            foreach ( int i in list )
            {
                Console.WriteLine( i );
            }

            if ( list.Contains( 1 ) )
                Console.WriteLine( "YES" );
            else
                Console.WriteLine( "NO" );

            list.Remove( 1 );
            foreach ( int i in list )
                Console.WriteLine( i );

            if ( list.Contains( 1 ) )
                Console.WriteLine( "YES" );
            else
                Console.WriteLine( "NO" );

            HashSet<int> set = new HashSet<int>( myArr );
            foreach ( int i in set )
                Console.WriteLine( i );
            Console.ReadLine();
        }

    }
}
