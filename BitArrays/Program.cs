using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BitArrays
{
    internal class Program
    {
        static string ConvertFromBitArryToString( BitArray bitArray )
        {
            char[] ch = new char[ bitArray.Length ];
            for ( int i = 0; i < bitArray.Length; i++ )
            {
                ch[ i ] = bitArray[ i ] ? '1' : '0';
            }
            return new string( ch );
        }
        static void Main( string[] args )
        {
            // Create a BitArray with 10 bits, all initialized to false
            BitArray bits1 = new BitArray( 10 );
            Console.WriteLine( "===========================" );
            Console.WriteLine( "bits1 content: " + ConvertFromBitArryToString( bits1 ) );

            for ( int i = 0; i < bits1.Count; i++ )
            {
                Console.WriteLine( $"Bit at index {i}: {( bool ) bits1[ i ]}" );
            }
            // Create a BitArray from an array of booleans
            bool[] initialValues = { true, false, true, true, false };
            BitArray bits2 = new BitArray( initialValues );
            Console.WriteLine( "===========================" );
            Console.WriteLine( "bits2 content: " + ConvertFromBitArryToString( bits2 ) );
            for ( int i = 0; i < bits2.Count; i++ )
            {
                bool bitVal = bits1[ i ];
                Console.WriteLine( $"Bit at index {i}: {bitVal}" );
            }
            // Create a BitArray from a byte array
            byte[] byteArray = { 0xAA, 0x55 }; // 10101010, 01010101
            BitArray bits3 = new BitArray( byteArray );
            Console.WriteLine( "===========================" );
            Console.WriteLine( "bits3 content: " + ConvertFromBitArryToString( bits3 ) );
            for ( int i = 0; i < bits3.Count; i++ )
            {
                bool bitVal = bits3[ i ];
                Console.WriteLine( $"Bit at index {i}: {bitVal}" );
            }
            // Basic Operations
            BitArray bits4 = new BitArray( 8 ); // 00000000
            bits4.Set( 2, true ); // Set the bit at index 2 to true
            bits4.Set( 5, true ); // Set the bit at index 5 to true
            bits4[ 7 ] = true;    // Set the bit at index 7 to true
            bits4[ 3 ] = false;   // Set the bit at index 3 to false

            Console.WriteLine( "===========================" );
            Console.WriteLine( "bits4 content: " + ConvertFromBitArryToString( bits4 ) );
            for ( int i = 0; i < bits4.Count; i++ )
            {
                bool bitVal = bits4[ i ];
                Console.WriteLine( $"Bit at index {i}: {bitVal}" );
            }
            Console.WriteLine( "===========================" );
            bits4.SetAll( true ); // Set all bits to true
            Console.WriteLine( "bits4 content after setting all to true: " + ConvertFromBitArryToString( bits4 ) );
            for ( int i = 0; i < bits4.Count; i++ )
            {
                bool bitVal = bits4[ i ];
                Console.WriteLine( $"Bit at index {i}: {bitVal}" );
            }
            Console.WriteLine( "===========================" );
            bits4.SetAll( false ); // Set all bits to false
            Console.WriteLine( "bits4 content after setting all to false:" + ConvertFromBitArryToString( bits4 ) );
            for ( int i = 0; i < bits4.Count; i++ )
            {
                bool bitVal = bits4[ i ];
                Console.WriteLine( $"Bit at index {i}: {bitVal}" );
            }

            bool bitValue = bits4[ 3 ]; // Get the value of the bit at index 3
            int length = bits4.Length; // Get the number of bits in the BitArray

            // Iterating Through a BitArray
            BitArray bits5 = new BitArray( 8 );
            bits5.SetAll( true );
            Console.WriteLine( "===========================" );
            Console.WriteLine( "bits5 content: " + ConvertFromBitArryToString( bits5 ) );
            for ( int i = 0; i < bits5.Count; i++ )
            {
                bool bitVal = bits5[ i ];
                Console.WriteLine( $"Bit at index {i}: {bitVal}" );
            }
            Console.WriteLine( "===========================" );
            Console.ReadLine();
        }
    }
}
