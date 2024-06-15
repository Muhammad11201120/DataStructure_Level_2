using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Custom_Collections_ICollection
{
    public class MyCustomCollection<T> : ICollection<T>
    {
        List<T> list = new List<T>();
        public int Count => list.Count;

        public bool IsReadOnly => false;

        public void Add( T item )
        {
            list.Add( item );
        }

        public void Clear()
        {
            list.Clear();
        }

        public bool Contains( T item )
        {
            return list.Contains( item );
        }

        public void CopyTo( T[] array, int arrayIndex )
        {
            list.CopyTo( array, arrayIndex );
        }

        public IEnumerator<T> GetEnumerator()
        {
            foreach ( var item in list )
            {
                yield return item;
            }
        }

        public bool Remove( T item )
        {
            return list.Remove( item );
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
    internal class Program
    {

        static void Main( string[] args )
        {
            MyCustomCollection<int> list = new MyCustomCollection<int>();
            list.Add( 1 );
            list.Add( 2 );
            list.Add( 3 );
            list.Add( 4 );

            foreach ( var item in list )
            {
                Console.WriteLine( item );
            }
            Console.WriteLine( $"is the list contains 5 ? {list.Contains( 5 )}" );
            Console.WriteLine( $"is the list contains 2 ? {list.Contains( 2 )}" );
            Console.ReadKey();
        }
    }
}
