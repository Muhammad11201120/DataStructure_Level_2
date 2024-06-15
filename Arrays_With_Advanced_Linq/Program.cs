using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays_With_Advanced_Linq
{
    internal class Program
    {
        static void Main( string[] args )
        {
            // Array of numbers
            int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            var evens = numbers.Where( n => n%2==0 ).Sum();
            Console.WriteLine( $"Sum Of Even Numbers is : {evens}" );
            Console.ReadLine();
        }
    }
}
