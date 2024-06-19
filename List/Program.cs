using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;

namespace List
{
    internal class Program
    {
        static void Main( string[] args )
        {
            List<int> myList = new List<int>();

            List<string> myList2 = new List<string> { "Muhammed", "Ahmed", "Mahmoud", "Saee", "Fahad" };
            myList.Add( 1 );
            myList.Add( 2 );
            myList.Add( 3 );

            Console.WriteLine( "List Capacity: " + myList.Capacity );
            Console.WriteLine( "Is List Contains 2 : "+myList.Contains( 2 ) );
            Console.WriteLine( "List Count: " + myList.Count );
            myList.Insert( 0, 100 );
            Console.WriteLine( "My List after insert 100 to 0 index: " + string.Join( ", ", myList ) );

            myList.InsertRange( myList.Count, new List<int> { 200, 300, 400 } );
            Console.WriteLine( "\nMy List after insert 200, 300, 400 to end of the list: " + string.Join( ", ", myList ) );

            myList.Add( 50 );
            Console.WriteLine( "\nMy List after add 50 to the end of the list: " + string.Join( ", ", myList ) );

            myList.Remove( 50 );
            Console.WriteLine( "\nMy List after remove 50 from the list: " + string.Join( ", ", myList ) );
            myList.RemoveAt( myList.Count-1 );
            Console.WriteLine( "\nMy List after remove last element from the list: " + string.Join( ", ", myList ) );
            myList.RemoveAll( n => n%2==0 );
            Console.WriteLine( "\nMy List after remove all even numbers from the list: " + string.Join( ", ", myList ) );

            myList2.RemoveAll( n => n[ 0 ] =='M' );
            Console.WriteLine( "\nMy List2 after remove all names that contains M from the list: " + string.Join( ", ", myList2 ) );
            Console.WriteLine( "===========================" );
            for ( int i = 0; i < myList2.Count; i++ )
            {
                Console.WriteLine( myList2[ i ] );
            }
            Console.Write( "=================================\n" );
            foreach ( string item in myList2 )
            {
                Console.WriteLine( item );
            }
            Console.Write( "=================================\n" );
            myList.ForEach( n => Console.WriteLine( n ) );

            Console.ReadLine();

        }
    }
}
