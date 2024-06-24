using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trees_Find_Operation
{
    public class TreeNode<T>
    {
        public T Data { get; set; }
        public List<TreeNode<T>> Children { get; set; }

        public TreeNode(T data ){ this.Data = data; this.Children = new List<TreeNode<T>>(); }
        public void Add(TreeNode<T> node){ Children.Add(node); }

        public TreeNode<T> Find( T value)
        {
            if( EqualityComparer<T>.Default.Equals( Data, value ) )
                return this;
            foreach( var child in Children )
            {
                var found = child.Find( value );
                if( found != null )
                    return found;
            }
            return null;
        }
    }
    public class Tree<T>
    {
        public TreeNode<T> Root { get; private set; }

        public Tree( T root )
        {
            this.Root = new TreeNode<T>( root );
        }
        public TreeNode<T> Find( T value ) 
        {
            return Root?.Find( value ); 
        }
        private static void PrintTree( TreeNode<T> node, string indent = "" )
        {
            Console.WriteLine( indent + node.Data );
            foreach( var child in node.Children )
            {
                PrintTree( child, indent + "  " );
            }
        }
        public void PrintTree(string indent = " " )
        {
            PrintTree(this.Root,indent);
        }
    }
    internal class Program
    {
        static void Main( string[ ] args )
        {
            // Creating the tree
            var CompanyTree = new Tree<string>( "CEO" );
            var Finance = new TreeNode<string>( "CFO" );
            var Tech = new TreeNode<string>( "CTO" );
            var Marketing = new TreeNode<string>( "CMO" );

            // Adding departments to the CEO node
            CompanyTree.Root.Add( Finance );
            CompanyTree.Root.Add( Tech );
            CompanyTree.Root.Add( Marketing );

            // Adding employees to departments
            Finance.Add( new TreeNode<string>( "Accountant" ) );
            Tech.Add( new TreeNode<string>( "Developer" ) );
            Tech.Add( new TreeNode<string>( "UX Designer" ) );
            Marketing.Add( new TreeNode<string>( "Social Media Manager" ) );

            // Printing the tree
            CompanyTree.PrintTree();

            Console.WriteLine( "\nFinding Developer..." );
            if( CompanyTree.Find( "Developer" )==null )
                Console.WriteLine( "Not Found :-(" );
            else
                Console.WriteLine( "Found :-)" );

            Console.WriteLine( "\nFinding DBA..." );
            if( CompanyTree.Find( "DBA" ) == null )
                Console.WriteLine( "Not Found :-(" );
            else
                Console.WriteLine( "Found :-)" );

            Console.ReadKey();

        }
    }
}
