using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Threading.Tasks;

namespace Custom_Collections_Iset
{
        public class MyCustomCollection<T> : ISet<T>
        {
            private List<T> _list = new List<T>();
            public int Count => _list.Count;

            public bool IsReadOnly => false;

            public bool Add( T item )
            {
                if( _list.Contains( item ) )
                    return false;
                _list.Add( item );
                return true;
            }

            public void Clear()
            {
                _list.Clear();
            }

            public bool Contains( T item )
            {
                if( _list.Contains( item ) )
                    return true;
                return false;
            }

            public void CopyTo( T[] array, int arrayIndex )
            {
                if( array == null )
                    throw new ArgumentNullException( "Array is Null" );
                if( array.Length - arrayIndex < _list.Count )
                    throw new ArgumentOutOfRangeException( "Array is not enough to hold more items" );
                for( int i = 0; i < _list.Count; i++ )
                    array[ arrayIndex + i ] = _list[ i ];
            }

            public void ExceptWith( IEnumerable<T> other )
            {
                if( other == null )
                {
                    throw new ArgumentNullException( nameof( other ) );
                }
                HashSet<T> otherSet = new HashSet<T>( other );
                for( int i = _list.Count - 1; i >= 0; i-- )
                {

                    if( otherSet.Contains( _list[ i ] ) )
                    {
                        _list.Remove( _list[ i ] );
                    }
                }

                /*for (int i = 0; i < _Items.Count; i++)
                {

                    if (otherSet.Contains(_Items[i]))
                    {
                        _Items.Remove(_Items[i]);
                        --i;
                    }
                }*/
            }

            public IEnumerator<T> GetEnumerator()
            {
                for( int i = 0; i < _list.Count; i++ )
                {
                    yield return _list[ i ];
                };

            }

            public void IntersectWith( IEnumerable<T> other )
            {
                if( other == null )
                {
                    throw new ArgumentNullException( nameof( other ) );
                }
                HashSet<T> otherSet = new HashSet<T>( other );
                for( int i = _list.Count - 1; i >= 0; i-- )
                {
                    if( !( otherSet.Contains( _list[ i ] ) ) )
                    {
                        _list.Remove( _list[ i ] );
                    }
                }
            }

            public bool IsProperSubsetOf( IEnumerable<T> other )
            {
                if( other == null )
                {
                    throw new ArgumentNullException( nameof( other ) );
                }

                HashSet<T> otherSet = new HashSet<T>( other );
                // we check if the otherSet large or equal The current, the current set can't be a proper superSet
                if( otherSet.Count >= _list.Count )
                    return false;

                foreach( T item in _list )
                {
                    if( !otherSet.Contains( item ) )
                    {
                        return false;
                    }
                }
                return ( otherSet.Count > _list.Count );
            }

            public bool IsProperSupersetOf( IEnumerable<T> other )
            {
                if( other == null )
                {
                    throw new ArgumentNullException( nameof( other ) );
                }

                HashSet<T> otherSet = new HashSet<T>( other );
                // we check if the otherSet large or equal The current, the current set can't be a proper superSet
                if( otherSet.Count >= _list.Count )
                    return false;

                foreach( T item in otherSet )
                {
                    if( !_list.Contains( item ) )
                    {
                        return false;
                    }
                }
                return ( otherSet.Count < _list.Count );
            }

            public bool IsSubsetOf( IEnumerable<T> other )
            {
                if( other == null )
                {
                    throw new ArgumentNullException( nameof( other ) );
                }

                HashSet<T> otherSet = new HashSet<T>( other );

                foreach( T item in _list )
                {
                    if( !otherSet.Contains( item ) )
                    {
                        return false;
                    }
                }

                return true;
            }

            public bool IsSupersetOf( IEnumerable<T> other )
            {
                if( other == null )
                {
                    throw new ArgumentNullException( nameof( other ) );
                }

                foreach( T item in other )
                {
                    if( !_list.Contains( item ) )
                    {
                        return false;
                    }
                }

                return true;
            }

            public bool Overlaps( IEnumerable<T> other )
            {
                if( other == null )
                {
                    throw new ArgumentNullException( nameof( other ) );
                }
                HashSet<T> otherSet = new HashSet<T>( other );
                foreach( T item in _list )
                {
                    if( otherSet.Contains( item ) )
                        return true;
                }
                return false;
            }

            public bool Remove( T item )
            {
                return _list.Remove( item );
            }

            public bool SetEquals( IEnumerable<T> other )
            {
                if( other == null )
                {
                    throw new ArgumentNullException( nameof( other ) );
                }
                HashSet<T> otherSet = other as HashSet<T>;

                return _list.ToHashSet().SetEquals( otherSet );
            }

            public void SymmetricExceptWith( IEnumerable<T> other )
            {

                if( other == null )
                {
                    throw new ArgumentNullException( nameof( other ) );
                }
                HashSet<T> otherSet = other as HashSet<T>;
                foreach( T item in otherSet )
                {
                    if( !_list.Contains( item ) )
                    {
                        _list.Add( item ); // add unique element
                    }
                    else
                    {
                        _list.Remove( item ); // remove common element
                    }
                }
            }

            public void UnionWith( IEnumerable<T> other )
            {
                if( other == null )
                {
                    throw new ArgumentNullException( nameof( other ) );
                }

                HashSet<T> otherSet = new HashSet<T>( other );

                foreach( T item in otherSet )
                {
                    if( !_list.Contains( item ) )
                    {
                        _list.Add( item );
                    }
                }

            }

            void ICollection<T>.Add( T item )
            {
                _list.Add( item );
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
                // Create an instance of MyCollectionSet
                MyCustomCollection<int> mySet = new MyCustomCollection<int>();

                // Add elements to mySet
                mySet.Add( 1 );
                mySet.Add( 2 );
                mySet.Add( 3 );

                // Display the elements in mySet
                Console.WriteLine( "Elements in mySet:" );
                foreach( int item in mySet )
                {
                    Console.WriteLine( item );
                }

                // Test some set operations
                MyCustomCollection<int> otherSet = new MyCustomCollection<int>();
                otherSet.Add( 2 );
                otherSet.Add( 3 );
                otherSet.Add( 4 );
                otherSet.Add( 1 );

                Console.WriteLine( "Is mySet a subset of otherSet? " + mySet.IsSubsetOf( otherSet ) );
                Console.WriteLine( "Is mySet a superset of otherSet? " + mySet.IsSupersetOf( otherSet ) );

                mySet.IntersectWith( otherSet );
                Console.WriteLine( "Elements in mySet after IntersectWith:" );
                foreach( int item in mySet )
                {
                    Console.WriteLine( item );
                }

                mySet.UnionWith( otherSet );
                Console.WriteLine( "Elements in mySet after UnionWith:" );
                foreach( int item in mySet )
                {
                    Console.WriteLine( item );
                }
                mySet.ExceptWith( otherSet );
                Console.WriteLine( "Elements in mySet after ExceptWith:" );
                foreach( int item in mySet )
                {
                    Console.WriteLine( item );
                }
                Console.ReadLine();
            }
        }
    }

