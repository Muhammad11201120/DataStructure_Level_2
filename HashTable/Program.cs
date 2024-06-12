using System;
using System.Collections;


namespace HashTable
{
    internal class Program
    {
        static void Main( string[] args )
        {
            Hashtable myHash = new Hashtable();
            myHash.Add( "Mo", "Aissa" );
            myHash.Add( "Sa", "Ali" );

            Console.WriteLine( myHash[ "Mo" ] );
            foreach ( DictionaryEntry item in myHash )
            {
                Console.WriteLine( item.Key+ " , "+ item.Value );
            }
            // Removing 
            myHash.Remove( "Mo" );
            Console.WriteLine( "HashTable After Removing (Mo) \n" );
            foreach ( DictionaryEntry item in myHash )
            {
                Console.WriteLine( item.Key + " , "+item.Value );
            }
            Console.ReadLine();
        }
    }
}
