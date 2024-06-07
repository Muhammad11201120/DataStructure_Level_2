using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace List_With_Linq
{
    internal class Program
    {
        static void Main( string[] args )
        {
            List<int> myList = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            //Aggregrate functions
            Console.WriteLine( "Sum of myList = " + myList.Sum() );
            Console.WriteLine( "Average of myList = " + myList.Average() );
            Console.WriteLine( "Max of myList = " + myList.Max() );
            Console.WriteLine( "Min of myList = " + myList.Min() );
            Console.WriteLine( "First of myList = " + myList.First() );
            Console.WriteLine( "Last of myList = " + myList.Last() );

            Console.ReadLine();
        }
    }
}
