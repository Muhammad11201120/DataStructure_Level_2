using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    internal class Program
    {
        static void Main( string[] args )
        {
            string[] myArr = new string[ 4 ];
            myArr[ 0 ]="ahmed";
            myArr[ 1 ]="Nawaf";
            myArr[ 2 ]= "bandar";
            myArr[ 3 ]= "Salem";

            int[] nums = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16 };
            int[,] matrix = { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };

            Array.Sort( myArr );//sorting myArr

            string[] copy = new string[ 4 ];
            Array.Copy( myArr, copy, myArr.Length );

            Console.WriteLine( "===============================" );

            for ( int i = 0; i < matrix.GetLength( 0 ); i++ )
            {
                for ( int j = 0; j < matrix.GetLength( 1 ); j++ )
                {
                    Console.Write( matrix[ i, j ] + " " );
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            Console.WriteLine( "================== EVENS with Power =============" );
            var evens = nums.Where( n => n%2==0 ).Select( n => n*n );
            foreach ( var item in evens )
            {
                Console.Write( item + " " );
            }
            Console.WriteLine();
            Console.WriteLine( "===============================" );

            var filter = myArr.Where( n => n[ 0 ]=='b' );

            foreach ( string item in filter )
            {
                Console.WriteLine( item );
            }




            Console.WriteLine( "============= Original Array ==================" );

            foreach ( var item in myArr )
            {
                Console.WriteLine( item );
            }
            Console.WriteLine( "============= Copied Array ==================" );
            foreach ( var item in copy )
            {
                Console.WriteLine( item );
            }
            Console.ReadLine();
        }
    }
}
