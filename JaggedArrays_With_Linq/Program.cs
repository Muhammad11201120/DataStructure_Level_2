using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JaggedArrays_With_Linq
{
    internal class Program
    {
        static void Main( string[] args )
        {
            int[][] jagged = new int[ 3 ][];

            jagged[ 0 ] = new int[ 3 ];
            jagged[ 1 ] = new int[ 3 ];
            jagged[ 2 ]= new int[ 2 ];

            jagged[ 0 ] = new int[] { 4, 2, 3 };
            jagged[ 1 ] = new int[] { 1, 2, 3 };
            jagged[ 2 ] = new int[] { 0, 2 };

            int sum = jagged.SelectMany( n => n ).Sum();
            int min = jagged.SelectMany( n => n ).Min();
            int max = jagged.SelectMany( n => n ).Max();
            Console.WriteLine( "=========AGGREGATE============" );
            Console.WriteLine( $"SUM = {sum}" );
            Console.WriteLine( $"MIN = {min}" );
            Console.WriteLine( $"MAX = {max}" );
            Console.WriteLine( "==========FILTERS============" );
            var filtered = jagged.Where( n => n.Length>2 ).Select( n => n.First() );
            foreach ( var item in filtered )
            {
                Console.WriteLine( item );
            }
            Console.WriteLine( "=============================" );
            Console.ReadKey();
        }
    }
}
