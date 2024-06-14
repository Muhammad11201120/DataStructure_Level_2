using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortedLists_With_Linq
{
    internal class Program
    {
        static void Main( string[] args )
        {
            // Initialize a SortedList of int keys and string values with fruit names
            SortedList<int, string> sortedList = new SortedList<int, string>()
        {
            { 1, "Apple" },
            { 2, "Banana" },
            { 3, "Cherry" },
            { 4, "Date" },
            { 5, "Grape" },
            { 6, "Fig" },
            { 7, "Elderberry" }
        };

            var group = sortedList.GroupBy( x => x.Value.Length );
            foreach ( var items in group )
            {
                Console.WriteLine( "Items With "+items.Key+" Chars Are: " );
                foreach ( var item in items )
                {
                    Console.WriteLine( "\t"+item.Value );
                }
            }


            Console.ReadLine();
        }
    }
}
