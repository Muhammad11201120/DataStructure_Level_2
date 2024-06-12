using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hashsets_Symantic_Difference_Operation
{
    internal class Program
    {
        static void Main( string[] args )
        {
            HashSet<int> set1 = new HashSet<int> { 1, 2, 3, 4 };
            HashSet<int> set2 = new HashSet<int> { 4, 5, 6, 7 };
            //Retaining elements unique to each set using SymmetricExceptWith.
            // Symmetric difference between set1 and set2
            set1.SymmetricExceptWith( set2 );
            foreach ( int item in set1 )
            {
                Console.WriteLine( item );
            }
            Console.ReadLine();
        }
    }
}
