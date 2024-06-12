using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace List_With_CustomObject
{
    class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
    }
    internal class Program
    {
        static void Main( string[] args )
        {
            List<Person> person = new List<Person>();
            person.Add( new Person() { Name="Ahmed", Age = 12 } );
            person.Add( new Person() { Name = "Ali", Age =45 } );
            person.Add( new Person() { Name = "Fahad", Age =15 } );
            foreach ( Person p in person )
            {
                if ( p.Age > 12 )
                {
                    Console.BackgroundColor = ConsoleColor.Green;
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine( " Accepted => Name : " + p.Name + ", Age : "+p.Age + " " );
                }
                else
                {
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine( " Not Accepted => Name : "+p.Name+", Age : "+p.Age + " " );
                }
            }
            //Convert List To Array
            Person[] personArr = person.ToArray();
            foreach ( Person p in personArr )
            {
                Console.WriteLine( p.Name );
            }
            //Convert Array To list
            List<Person> list = new List<Person>( personArr );
            foreach ( Person p in list )
            {

                Console.WriteLine( p.Name );
            }

            Console.ReadLine();
        }
    }
}
