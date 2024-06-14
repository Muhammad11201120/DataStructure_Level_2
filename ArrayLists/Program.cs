using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayLists
{
    internal class Program
    {
        static void Main( string[] args )
        {
            ArrayList myList = new ArrayList
            {
                1,"Name",true,'v',3
            };
            ArrayList myInt = new ArrayList
            {
                1,2,3,4,2,2,2,5,6
            };
            for ( int i = 0; i < myList.Count; i++ )
            {
                Console.Write( myList[ i ] +" - " );
            }
            Console.WriteLine( "\n===========================" );
            var EvenNums = myInt.Cast<int>().Where( x => x % 2 == 0 );


            foreach ( var i in EvenNums )
            {
                Console.Write( i + " , " );
            }
            Console.WriteLine( "\n===========================" );
            int min = myInt.Cast<int>().Min();
            int max = myInt.Cast<int>().Max();
            double avg = myInt.Cast<int>().Average();
            int count = myInt.Cast<int>().Count();
            Console.WriteLine( $"Min number in the array list is => {min}" );
            Console.WriteLine( $"Max number in the array list is => {max}" );
            Console.WriteLine( $"Average number in the array list is => {avg}" );
            Console.WriteLine( $"Number of the array list Items is => {count}" );
            Console.WriteLine( "\n===========================" );
            var countNumberTwo = myInt.Cast<int>().Count( n => n==2 );
            Console.WriteLine( $"Accurance Of Number 2 In Th Array is => {countNumberTwo}" );
            Console.ReadLine();
        }
    }
}
