using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortedLists
{
    internal class Program
    {
        static void Main( string[] args )
        {
            SortedList<int, string> fruites = new SortedList<int, string>
            {
                //sorted lists is always arrange the list based on the keys
                { 1, "Apple" },
                { 2, "Orange" },
                { 3, "Banana" },
                { 5, "Strowberry" },
                { 4, "Botatos" }
            };
            foreach ( var i in fruites )
            {
                Console.WriteLine( i.Key + " - "+i.Value );
            }
            Console.WriteLine( "is list contains Apple? : " +fruites.ContainsValue( "Apple" ) );
            Console.WriteLine( "is list contains Onion? : "+fruites.ContainsValue( "Onion" ) );

            var listOfMine = fruites.Where( n => n.Value.Length > 6 );

            foreach ( var i in listOfMine )
            {
                Console.WriteLine( i.Value );
            }
            Console.ReadLine();
        }
    }
}
