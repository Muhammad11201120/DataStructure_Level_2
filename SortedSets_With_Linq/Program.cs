using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;

namespace SortedSets_With_Linq
{
    internal class Program
    {
        static void Main( string[] args )
        {
            //Sorted Set Always Sorted And Uniqe
            SortedSet<int> list = new SortedSet<int>();
            list.Add( 1 );
            list.Add( 2 );
            list.Add( 3 );
            list.Add( 4 );
            list.Add( 5 );
            list.Add( 6 );
            list.Add( 7 );
            SortedSet<int> list2 = new SortedSet<int>
            {
                1,2,3
            };

            var listFilter = list.Where( x => x > 2 );
            foreach ( var item in listFilter )
            {
                Console.Write( item +" " );
            }
            Console.WriteLine( "\n------------------------------------" );
            int ListSum = list.Sum( x => x );
            Console.WriteLine( $"SUM = {ListSum}" );
            Console.WriteLine( $"Max Element = {list.Max}" );
            Console.WriteLine( $"Min Element = {list.Min}" );
            Console.WriteLine( "\n------------------------------------" );
            var sorted = list.OrderByDescending( x => x );
            foreach ( var e in sorted )
            {
                Console.Write( e +" " );
            }
            Console.WriteLine( "\n------------------------------------" );
            Console.WriteLine( $"are two sets equals: {list.SetEquals( list2 )}" );
            Console.WriteLine( $"is set2 subset of set1 : {list2.IsSubsetOf( list )}" );
            Console.WriteLine( $"is set2 super set of set1 {list2.IsSupersetOf( list )}" );
            Console.WriteLine( $"is set1 super set of set2 {list.IsSupersetOf( list2 )}" );
            Console.WriteLine( "\n------------------------------------" );

            SortedSet<int> intersect = new SortedSet<int>( list );
            intersect.IntersectWith( list2 );
            Console.WriteLine( "list1 intersect with list 2 : " );
            foreach ( var item in intersect )
            {
                Console.Write( item + " " );
            }

            Console.WriteLine( "\n------------------------------------" );
            SortedSet<int> union = new SortedSet<int>( list );
            union.UnionWith( list2 );
            Console.WriteLine( "list1 union with list 2 : " );
            foreach ( var item in union )
            {
                Console.Write( item + " " );
            }

            Console.WriteLine( "\n------------------------------------" );
            SortedSet<int> exceptwith = new SortedSet<int>( list );
            exceptwith.ExceptWith( list2 );
            Console.WriteLine( "list1 except with list 2 : " );
            foreach ( var item in exceptwith )
            {
                Console.Write( item + " " );
            }
            Console.WriteLine( "\n------------------------------------" );

            Console.ReadLine();
        }
    }
}
