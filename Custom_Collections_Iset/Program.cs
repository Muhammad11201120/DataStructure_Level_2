﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Custom_Collections_Iset
{
    internal class Program
    {
        public class MyCustomCollection<T> : ISet<T>
        {
            private List<T> _list = new List<T>();
            public int Count => _list.Count;

            public bool IsReadOnly => false;

            public bool Add( T item )
            {
                throw new NotImplementedException();
            }

            public void Clear()
            {
                throw new NotImplementedException();
            }

            public bool Contains( T item )
            {
                throw new NotImplementedException();
            }

            public void CopyTo( T[] array, int arrayIndex )
            {
                throw new NotImplementedException();
            }

            public void ExceptWith( IEnumerable<T> other )
            {
                throw new NotImplementedException();
            }

            public IEnumerator<T> GetEnumerator()
            {
                throw new NotImplementedException();
            }

            public void IntersectWith( IEnumerable<T> other )
            {
                throw new NotImplementedException();
            }

            public bool IsProperSubsetOf( IEnumerable<T> other )
            {
                throw new NotImplementedException();
            }

            public bool IsProperSupersetOf( IEnumerable<T> other )
            {
                throw new NotImplementedException();
            }

            public bool IsSubsetOf( IEnumerable<T> other )
            {
                throw new NotImplementedException();
            }

            public bool IsSupersetOf( IEnumerable<T> other )
            {
                throw new NotImplementedException();
            }

            public bool Overlaps( IEnumerable<T> other )
            {
                throw new NotImplementedException();
            }

            public bool Remove( T item )
            {
                throw new NotImplementedException();
            }

            public bool SetEquals( IEnumerable<T> other )
            {
                throw new NotImplementedException();
            }

            public void SymmetricExceptWith( IEnumerable<T> other )
            {
                throw new NotImplementedException();
            }

            public void UnionWith( IEnumerable<T> other )
            {
                throw new NotImplementedException();
            }

            void ICollection<T>.Add( T item )
            {
                throw new NotImplementedException();
            }

            IEnumerator IEnumerable.GetEnumerator()
            {
                throw new NotImplementedException();
            }
        }
        static void Main( string[] args )
        {
        }
    }
}
