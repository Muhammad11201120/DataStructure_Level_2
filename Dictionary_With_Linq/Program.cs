using System;
using System.CodeDom;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dictionary_With_Linq
{
    internal class Program
    {
        static void Main( string[] args )
        {
            Dictionary<string, int> fruteBasket = new Dictionary<string, int>
            {
                {"Apple",45},
                {"Orange",42},
                {"Banana",50 },
                {"StrwBerry",35 }
            };
            Dictionary<string, string> fruitsCategory = new Dictionary<string, string>
            {
                 { "Apple", "Tree" },
                 { "Banana", "Herb" },
                { "Cherry", "Tree" },
                { "Strawberry", "Bush" },
                { "Raspberry", "Bush" }
            };
            var furites = fruteBasket.Select( kv => new { kv.Key, kv.Value } );
            Console.WriteLine( "\tItems: \n" );
            foreach ( var item in furites )
            {
                Console.WriteLine( item.Key +" , " +item.Value );
            }
            Console.WriteLine( "-------- Greater Than 42 ----------------\n" );
            var bigFruiters = fruteBasket.Where( n => n.Value> 42 );
            foreach ( var item in bigFruiters )
            {
                Console.WriteLine( item.Key + ",  "+item.Value );
            }
            //Ordering desc with linq
            Console.WriteLine( "----------- ASSC -------------\n" );
            var orderedFruets = fruteBasket.OrderBy( n => n.Value );
            foreach ( var item in orderedFruets )
            {
                Console.WriteLine( item.Key + ",  "+item.Value );
            }
            Console.WriteLine( "----------- DESC -------------\n" );
            var orderedFruetsdesc = fruteBasket.OrderByDescending( n => n.Value );
            foreach ( var item in orderedFruetsdesc )
            {
                Console.WriteLine( item.Key + ",  "+item.Value );
            }
            Console.WriteLine( "------------SUM ------------\n" );

            //Aggrigate linq 
            int TotalfruetesSum = fruteBasket.Sum( n => n.Value );
            Console.WriteLine( "Tottal Sum Values = "+TotalfruetesSum );
            Console.WriteLine( "---------- Filters --------------\n" );
            var fruitFilters = fruteBasket.Where( n => n.Value > 30 ).OrderBy( n => n.Key ).Select( kv => new { kv.Key, kv.Value } );
            foreach ( var item in fruitFilters )
            {
                Console.WriteLine( item.Key + ",  "+item.Value );
            }
            Console.WriteLine( "--------------- Group By ------------------\n" );
            var groupedFruits = fruitsCategory.GroupBy( kpv => kpv.Value );


            foreach ( var group in groupedFruits )
            {
                Console.WriteLine( $"Category: {group.Key}" );
                foreach ( var fruit in group )
                {
                    Console.WriteLine( $" - {fruit.Key}" );
                }
            }
            Console.ReadLine();
        }
    }
}
