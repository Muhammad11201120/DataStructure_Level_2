using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trees_My_Family_Tree
{
    public class TreeNode<T>
    {
        public T Data { get; set; }
        public List<TreeNode<T>> Children { get; set; }

        public TreeNode(T data)
        {
            this.Data = data;
            this.Children = new List<TreeNode<T>>();
        }
        public void Add(TreeNode<T> node )
        {
            Children.Add( node );
        }
    }
    public class Person
    {
        public string Name { get; set; }
        public string Gender { get; set; }

        public Person( string name, string gender )
        {
            Name = name;
            Gender = gender;
        }
    }
    internal class Program
    {
        public static void PrintFamilyTree( TreeNode<Person> node, string indent = " " )
        {
            Console.WriteLine($"{indent}  ({node.Data.Name} - {node.Data.Gender})"  );

            foreach( var child in node.Children )
            {
                PrintFamilyTree( child, indent + "   " );
            }
        }
        static void Main( string[ ] args )
        {
            TreeNode<Person> ALI = new TreeNode<Person>( new Person( "ALI", "MALE" ) ); 
            TreeNode<Person> Muhammed = new TreeNode<Person>( new Person( "Muhammed", "MALE" ) ); 
            TreeNode<Person> RAWAN = new TreeNode<Person>( new Person( "Rawan", "MALE" ) ); 
            TreeNode<Person> Ali = new TreeNode<Person>( new Person( "Ali", "MALE" ) ); 

            ALI.Children.Add(Muhammed);
            ALI.Children.Add(RAWAN);
            Muhammed.Children.Add( Ali );

            PrintFamilyTree( ALI );

            Console.ReadKey();
        }
    }
}
