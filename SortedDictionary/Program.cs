using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortedDictionary
{
    internal class Program
    {
        static void Main( string[] args )
        {
            SortedDictionary<string, int> fruites = new SortedDictionary<string, int>
            {
                // soreted dict will take care of sorting stuff
                { "Apple", 15 },
                { "Orange", 20 },
                { "Banana", 14 },
                { "Grap", 40 }
            };
            Console.WriteLine( "------------------------------------\n" );
            foreach ( var fruite in fruites )
            {
                Console.WriteLine( fruite.Key + " => "+ fruite.Value );
            }
            Console.WriteLine( "------------------------------------\n" );
            Console.WriteLine( $"is Apple in the dictionary : " + fruites.ContainsKey( "Apple" ) );
            Console.WriteLine( $"is Banana in the dictionary : " + fruites.ContainsKey( "Banana" ) );
            Console.WriteLine( $"is StrwoBerry in the dictionary : " + fruites.ContainsKey( "StrwoBerry" ) );
            Console.WriteLine( "------------------------------------\n" );
            Console.WriteLine( $"Value Of Apple : " + fruites[ "Apple" ] );
            Console.WriteLine( "------------------------------------\n" );
            fruites.Remove( "Apple" );
            foreach ( var fruite in fruites )
            {
                Console.WriteLine( fruite.Key );
            }
            Console.WriteLine( "------------------------------------\n" );
            Console.ReadKey();
        }
    }
}
