using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hashsets_Equals_Operation
{
    internal class Program
    {
        static void Main( string[] args )
        {
            HashSet<int> set1 = new HashSet<int> { 4, 5, 6 };
            HashSet<int> set2 = new HashSet<int> { 4, 5, 6, 7 };
            HashSet<int> set3 = new HashSet<int> { 4, 5, 6, 7 };

            //check if two sets are equals
            Console.WriteLine( "--------------------------------------" );
            Console.WriteLine( $"is set1 equals set1 : {set1.SetEquals( set2 )}" );
            Console.WriteLine( $"is set2 equals set3 : {set2.SetEquals( set3 )}" );
            //check if set1 is subset of set2 or set3
            Console.WriteLine( "--------------------------------------" );
            Console.WriteLine( $"is set1 subset of set2 : {set1.IsSubsetOf( set2 )}" );
            Console.WriteLine( $"is set1 subset of set3 : {set1.IsSubsetOf( set3 )}" );
            //check if set2 is super set to set1
            Console.WriteLine( "--------------------------------------" );
            Console.WriteLine( $"is set1 super set to set2 : {set1.IsSupersetOf( set2 )}" );
            Console.WriteLine( $"is set2 super set to set1 : {set2.IsSupersetOf( set1 )}" );
            Console.WriteLine( "--------------------------------------" );
            Console.ReadLine();
        }
    }
}
