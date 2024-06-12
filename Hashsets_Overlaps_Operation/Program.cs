using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hashsets_Overlaps_Operation
{
    internal class Program
    {
        static void Main( string[] args )
        {
            HashSet<int> set1 = new HashSet<int> { 1, 2, 3, 4 };
            HashSet<int> set2 = new HashSet<int> { 4, 5, 6, 7 };
            HashSet<int> set3 = new HashSet<int> { 8, 9, 10, 11 };

            Console.WriteLine( $"set1 overlaps set2 : {set2.Overlaps( set2 )}" ); // if there is overlap it will return true otherwise false
            Console.WriteLine( $"set2 overlaps set3 : {set2.Overlaps( set3 )}" ); // if there is overlap it will return true otherwise false

            Console.ReadLine();
        }
    }
}
