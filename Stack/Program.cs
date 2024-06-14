using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack
{
    internal class Program
    {
        static void Main( string[] args )
        {
            Stack<int> ints = new Stack<int>();
            ints.Push( 1 );
            ints.Push( 2 );
            ints.Push( 3 );
            ints.Push( 4 );

            foreach ( int i in ints )
            {
                Console.WriteLine( i );
            }

            ints.Pop();

            Console.WriteLine( "=============================" );
            foreach ( int i in ints )
            {
                Console.WriteLine( i );
            }

            Console.WriteLine( "=============================" );
            var intsGreaterThan2 = ints.Where( x => x > 2 );
            foreach ( int i in intsGreaterThan2 )
            {
                Console.WriteLine( i );
            }
            Console.ReadLine();
        }
    }
}
