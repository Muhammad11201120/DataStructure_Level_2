

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashSet_With_Linq
{
    internal class Program
    {
        static void Main( string[] args )
        {
            HashSet<string> set = new HashSet<string>
            {
                "Ahmed","Muhammed","Mahmoud","Manal","Arwa","Muna"
            };
            var namesThatStartsWithM = set.Where( names => names.StartsWith( "M" ) );
            foreach ( string item in namesThatStartsWithM )
            {
                Console.WriteLine( item );
            }
            Console.WriteLine( "-------------------------------------" );
            var namesThatHaveLengthMoreThan4 = set.Where( name => name.Length > 4 );
            foreach ( string item in namesThatHaveLengthMoreThan4 )
            {
                Console.WriteLine( item );
            }
            Console.ReadLine();

        }
    }
}
