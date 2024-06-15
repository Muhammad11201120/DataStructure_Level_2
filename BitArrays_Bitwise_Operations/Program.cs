using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BitArrays_Bitwise_Operations
{
    internal class Program
    {
        static string BitArrayToString( BitArray bitArray )
        {
            char[] chars = new char[ bitArray.Length ];
            for ( int i = 0; i < bitArray.Length; i++ )
            {
                chars[ i ] = bitArray[ i ] ? '1' : '0';
            }
            return new string( chars );
        }

        static void Main( string[] args )
        {
            BitArray bits1 = new BitArray( new bool[] { true, false, false, true, false } );
            BitArray bits2 = new BitArray( new bool[] { false, false, false, true, true } );
            Console.WriteLine( "=============================" );
            Console.WriteLine( "bits1 : " + BitArrayToString( bits1 ) );
            Console.WriteLine( "bits2 : " + BitArrayToString( bits2 ) );

            Console.WriteLine( "=============BitWise Operators:================" );
            BitArray resultAnd = new BitArray( bits1 );
            Console.WriteLine( "bits1 : " + BitArrayToString( bits1 ) );
            Console.WriteLine( "bits2 : " + BitArrayToString( bits2 ) );
            Console.WriteLine( "----------------" );
            Console.WriteLine( $" AND :  {BitArrayToString( resultAnd.And( bits2 ) )}" );

            Console.WriteLine( "=============================" );
            BitArray resultOr = new BitArray( bits1 );
            Console.WriteLine( "bits1 : " + BitArrayToString( bits1 ) );
            Console.WriteLine( "bits2 : " + BitArrayToString( bits2 ) );
            Console.WriteLine( "----------------" );
            Console.WriteLine( $" OR :  {BitArrayToString( resultOr.Or( bits2 ) )}" );


            Console.WriteLine( "=============================" );
            BitArray resultXor = new BitArray( bits1 );
            Console.WriteLine( "bits1 : " + BitArrayToString( bits1 ) );
            Console.WriteLine( "bits2 : " + BitArrayToString( bits2 ) );
            Console.WriteLine( "----------------" );
            Console.WriteLine( $" XOR :  {BitArrayToString( resultXor.Xor( bits2 ) )}" );

            Console.WriteLine( "=============================" );
            BitArray resultNOT = new BitArray( bits1 );
            Console.WriteLine( $" NOT :  {BitArrayToString( resultNOT.Not() )}" );


            Console.WriteLine( "=============================" );
            Console.ReadLine();
        }
    }
}
