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
            string[] myArr = new string[ 3 ];
            myArr[ 0 ]="ahmed";
            myArr[ 1 ]= "bandar";
            myArr[ 2 ]= "Salem";


            Console.WriteLine( "===============================" );
            var filter = myArr.Where( n => n[ 0 ]=='b' );
            foreach ( string item in filter )
            {
                Console.WriteLine( item );
            }

            Console.WriteLine( "===============================" );
            foreach ( var item in myArr )
            {
                Console.WriteLine( item );
            }
            Console.ReadLine();
        }
    }
}
