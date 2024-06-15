using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tuples
{
    internal class Program
    {
        static void Main( string[] args )
        {
            Tuple<int, string, double> myTuble = new Tuple<int, string, double>( 1, "Ahmed", 5.5 );
            Console.WriteLine( $"Items => {myTuble.Item1} , {myTuble.Item2} , {myTuble.Item3}" );
            Console.WriteLine( myMethod().Item1 + " , " + myMethod().Item2 );

            Console.ReadLine();
        }
        static (int, string) myMethod()
        {
            return (1, "me");
        }
    }
}
