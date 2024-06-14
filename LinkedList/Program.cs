using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    internal class Program
    {
        static void Main( string[] args )
        {
            LinkedList<string> strings = new LinkedList<string>();
            strings.AddLast( "Ayman" );
            strings.AddLast( "Muhammed" );
            strings.AddLast( "Fahad" );
            strings.AddAfter( strings.Find( "Muhammed" ), "Saaed" );
            Console.WriteLine( "======================================" );
            foreach ( string s in strings )
            {
                Console.WriteLine( s );
            }
            Console.WriteLine( "======================================" );
            var findMuhammed = strings.Find( "Muhammed" );
            Console.WriteLine( findMuhammed.Value );
            Console.WriteLine( "======================================" );
            if ( strings.Contains( "Muhammed" ) )
            {
                Console.WriteLine( "Found" );
            }
            else
                Console.WriteLine( "Not Found" );
            Console.WriteLine( "======================================" );
            Console.ReadLine();
        }
    }
}
