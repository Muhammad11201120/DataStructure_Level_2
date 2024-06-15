using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Custom_Collections_IEnumerable
{
    public class MyCollection<T> : IEnumerable<T>
    {
        LinkedList<T> MyLinkedList = new LinkedList<T>();

        public IEnumerator<T> GetEnumerator()
        {
            foreach ( var item in MyLinkedList )
            {
                yield return item;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
        public void Add( T item )
        {
            MyLinkedList.AddLast( item );
        }
    }
    internal class Program
    {
        static void Main( string[] args )
        {
            MyCollection<int> list = new MyCollection<int>();
            list.Add( 1 );
            list.Add( 2 );
            list.Add( 3 );

            foreach ( var item in list )
            {
                Console.WriteLine( item );
            }
            Console.ReadKey();
        }
    }
}
