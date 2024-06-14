using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObservableCollections
{
    internal class Program
    {
        static void Main( string[] args )
        {
            ObservableCollection<string> collection = new ObservableCollection<string>();
            collection.CollectionChanged += ItemChanged;// assiign ItemChanged Method To CollectionChanged Event


            collection.Add( "Muhammed" );
            collection.Add( "Saeed" );
            collection.Add( "Fahad" );
            collection.Add( "Salem" );

            collection.Move( 0, 3 );// it will move index 0 to 3 and rearrange the list
            collection.Move( 1, 2 );// it will move index 1 to 2 and rearrange the list


            Console.WriteLine( "============= All items =================" );
            foreach ( string item in collection )
            {
                Console.WriteLine( item );
            }
            Console.WriteLine( "============= Names Start WithS =================" );
            var NamesStartWithS = collection.Where( n => n[ 0 ]=='S' );
            foreach ( var item in NamesStartWithS )
            {
                Console.WriteLine( item );
            }
            Console.WriteLine( "===============================================" );
            Console.ReadLine();
        }
        static void ItemChanged( object sender, System.Collections.Specialized.NotifyCollectionChangedEventArgs e )
        {
            Console.WriteLine( "Items Changed : " );

            switch ( e.Action )
            {

                case System.Collections.Specialized.NotifyCollectionChangedAction.Add:
                    Console.WriteLine( "ADDED : " );
                    foreach ( var item in e.NewItems )
                        Console.WriteLine( item );
                    break;
                case System.Collections.Specialized.NotifyCollectionChangedAction.Replace:
                    Console.WriteLine( "REPLACED : " );
                    foreach ( var item in e.OldItems )
                        Console.WriteLine( item );
                    Console.WriteLine( "WITH : " );
                    foreach ( var item in e.NewItems )
                        Console.WriteLine( item );
                    break;
                case System.Collections.Specialized.NotifyCollectionChangedAction.Remove:
                    Console.WriteLine( "REMOVED : " );
                    foreach ( var item in e.OldItems )
                        Console.WriteLine( item );
                    break;
                case System.Collections.Specialized.NotifyCollectionChangedAction.Reset:
                    Console.WriteLine( "ITEMS RESETS" );
                    foreach ( var item in e.NewItems )
                        Console.WriteLine( item );
                    break;
                case System.Collections.Specialized.NotifyCollectionChangedAction.Move:
                    foreach ( var item in e.OldItems )
                        Console.WriteLine( $"Item {item} Moved From : {e.OldStartingIndex} index To {e.NewStartingIndex} index." );
                    break;
            }
        }
    }
}
