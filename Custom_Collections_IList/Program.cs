using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Custom_Collections_IList
{
    public class myCustomCollection<T> : IList<T>
    {
       private  List<T> _list = new List<T> ();
        public T this[ int index ]
        { 
            get => _list[index]; 
            set => _list[index] = value; 
        }

        public int Count => _list.Count;

        public bool IsReadOnly => false;

        public void Add( T item )
        {
            _list.Add(item);
        }

        public void Clear()
        {
            _list.Clear();
        }

        public bool Contains( T item )
        {
            return _list.Contains(item);
        }

        public void CopyTo( T[] array, int arrayIndex )
        {
            _list.CopyTo(array,arrayIndex);
        }

        public IEnumerator<T> GetEnumerator()
        {
            return _list.GetEnumerator();
        }

        public int IndexOf( T item )
        {
            return _list.IndexOf(item);
        }

        public void Insert( int index, T item )
        {
            _list.Insert(index,item);
        }

        public bool Remove( T item )
        {
            return _list.Remove( item );
        }

        public void RemoveAt( int index )
        {
            _list.RemoveAt(index);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return _list.GetEnumerator();
        }
    }
    internal class Program
    {
        static void Main( string[] args )
        {
            myCustomCollection<int> list = new myCustomCollection<int>();
            list.Add( 1 );
            list.Add( 2 );

            foreach( int item in list )
            {
                Console.WriteLine(item);
            }
            Console.ReadKey();
        }
    }
}
