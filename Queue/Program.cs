using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queue
{
    internal class Program
    {
        static void Main( string[] args )
        {
            Queue<string> strings = new Queue<string>();
            strings.Enqueue( "Muhammed" );
            strings.Enqueue( "Ahmed" );
            strings.Enqueue( "Saeed" );
            strings.Enqueue( "Fahad" );
            strings.Enqueue( "Salman" );
            strings.Enqueue( "Salem" );
            Console.WriteLine( "=================================" );
            Console.WriteLine( "First Element : " + strings.Peek() );
            Console.WriteLine( "=================================" );
            foreach ( var item in strings )
            {
                Console.WriteLine( item );
            }
            Console.WriteLine( "=============== After Dequeue ==================" );
            strings.Dequeue();

            foreach ( var item in strings )
            {
                Console.WriteLine( item );
            }
            Console.WriteLine( "================ Starts With S =================" );
            var StringsStratsWithM = strings.Where( n => n[ 0 ] == 'S' );
            foreach ( var item in StringsStratsWithM )
            {
                Console.WriteLine( item );
            }
            Console.WriteLine( "============================================" );
            Console.ReadLine();
        }
    }
}
