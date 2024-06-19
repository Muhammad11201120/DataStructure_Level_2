using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trees_GeneralTree
{
    public class TreeNode<T>
    {
        public T value { get; set; }
        public List<TreeNode<T>> Children { get; set; }

        public TreeNode( T value )         
        { 
            this.value = value; 
            this.Children = new List<TreeNode<T>>(); 
        }
        public void AddChild( TreeNode<T> child ) { Children.Add( child ); }
    }
    public class Tree<T>
    {
        public TreeNode<T> Root { get; private set; }

        public Tree( T root )
        { 
            this.Root = new TreeNode<T>(root); 
        }
    }
    internal class Program
    {
        static void Main( string[] args )
        {
            var companyTree = new Tree<string>( "CEO" );
            var finance = new TreeNode<string>( "CFO" );
            var tech = new TreeNode<string>( "CTO" );
            var marketing = new TreeNode<string>( "CMO" );


            companyTree.Root.AddChild( finance );
            companyTree.Root.AddChild( tech );
            companyTree.Root.AddChild( marketing );


            finance.AddChild( new TreeNode<string>( "Accountant" ) );
            tech.AddChild( new TreeNode<string>( "Developer" ) );
            tech.AddChild( new TreeNode<string>( "UX Designer" ) );
            marketing.AddChild( new TreeNode<string>( "Social Media Manager" ) );


            PrintTree( companyTree.Root );
            Console.ReadKey();
        }
        public static void PrintTree<T>( TreeNode<T> node, string indent = "" )
        {
            Console.WriteLine( indent + node.value );
            foreach( var child in node.Children )
            {
                PrintTree( child, indent + "  " );
            }
        }
    }
}
