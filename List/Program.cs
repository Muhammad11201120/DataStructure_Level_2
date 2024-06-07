using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace List
{
    internal class Program
    {
        static void Main( string[] args )
        {
            List<int> myList = new List<int>();
            myList.Add( 1 );
            myList.Add( 2 );
            myList.Add( 3 );
            for ( int i = 0; i < myList.Count; i++ )
            {
                Console.WriteLine( myList[ i ] );
            }
            Console.WriteLine( "List Capacity: " + myList.Capacity );
            Console.WriteLine( "Is List Contains 2 : "+myList.Contains( 2 ) );
            Console.WriteLine( "List Count: " + myList.Count );
            Console.ReadLine();
        }
    }
}
