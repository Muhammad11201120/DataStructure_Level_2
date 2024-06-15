using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JaggedArray
{
    internal class Program
    {
        static void Main( string[] args )
        {
            //Jagged Array is Array Of Arrays With Different Sizes
            int[][] numbers = new int[ 3 ][];

            numbers[ 0 ] = new int[ 4 ];
            numbers[ 1 ] = new int[ 3 ];
            numbers[ 2 ] = new int[ 2 ];

            numbers[ 0 ]= new int[] { 1, 2, 3, 4 };
            numbers[ 1 ]= new int[] { 1, 2, 3 };
            numbers[ 2 ]= new int[] { 1, 2 };

            for ( int i = 0; i < numbers.Length; i++ )
            {
                for ( int j = 0; j < numbers[ i ].Length; j++ )
                {
                    Console.Write( numbers[ i ][ j ]+" " );
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
