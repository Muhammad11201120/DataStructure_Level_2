using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dictionary
{
    internal class Program
    {
        static void Main( string[] args )
        {
            Dictionary<string, int> frutes = new Dictionary<string, int>();
            frutes.Add( "Orange", 45 );
            frutes.Add( "Banana", 52 );
            frutes.Add( "Apple", 12 );

            frutes[ "Apple" ] = 85;
            foreach ( KeyValuePair<string, int> item in frutes )
            {
                Console.WriteLine( item.Key +" => "+item.Value );
            }

            //tryGetValue Method if found it will put the value in output parameters
            if ( frutes.TryGetValue( "Apple", out int foundedApple ) )
                Console.WriteLine( foundedApple );
            else
                Console.WriteLine( "not found" );

            if ( frutes.TryGetValue( "Strowberry", out int foundStrowBerry ) )
                Console.WriteLine( foundStrowBerry );
            else
                Console.WriteLine( "not found" );

            Console.ReadLine();
        }
    }
}
