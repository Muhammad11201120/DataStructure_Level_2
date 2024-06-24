using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Trees_Binary_Tree
{
    public class TreeNode<T>
    {
        public T Data { get; set; }
        public TreeNode<T> LeftChild { get; set; }
        public TreeNode<T> RightChild { get; set; }

        public TreeNode( T data )
        {
            Data = data;
            this.LeftChild = null;
            this.RightChild = null;
        }
    }
    public class Tree<T>
    {
        public TreeNode<T> Root { get; private set; }

        public Tree( )
        {
            this.Root = null;
        }
        public void Insert(T value )
        {
            var newNode = new TreeNode<T>( value );
            if( Root == null )
            {
                Root = newNode;
                return;
            }
            
            Queue<TreeNode<T>> queue = new Queue<TreeNode<T>>();
            queue.Enqueue( Root );
            while( queue.Count > 0 )
            {
                var current = queue.Dequeue();
                if( current.LeftChild == null )
                {
                    current.LeftChild = newNode;
                    break;
                }
                else
                { 
                    queue.Enqueue( current.LeftChild ); 
                }
                if( current.RightChild == null )
                {
                    current.RightChild = newNode;
                    break;
                }
                else
                { 
                    queue.Enqueue(current.RightChild);
                }
            }
        }
        // Method to visually print the tree structure
        public void PrintTree()
        {
            PrintTree( Root, 0 );
        }


        private void PrintTree( TreeNode<T> root, int space )
        {
            int COUNT = 10;  // Distance between levels to adjust the visual representation
            if( root == null )
                return;


            space += COUNT;
            PrintTree( root.RightChild, space ); // Print right subtree first, then root, and left subtree last


            Console.WriteLine();
            for( int i = COUNT; i < space; i++ )
                Console.Write( " " );
            Console.WriteLine( root.Data ); // Print the current node after space


            PrintTree( root.LeftChild, space ); // Recur on the left child
        }
        private void _PreOrderTraversal( TreeNode<T> node)
        {
            if( node != null )
            {
                Console.Write(node.Data + " ");
                _PreOrderTraversal( node.LeftChild );
                _PreOrderTraversal( node.RightChild);
            }
        }
        public void PreOrderTraversal()
        {
            _PreOrderTraversal( this.Root );
            Console.WriteLine();
        }
        private void _PostOrderTraversal( TreeNode<T> node )
        {
            if( node != null )
            {
                _PostOrderTraversal( node.LeftChild );
                _PostOrderTraversal( node.RightChild );
                Console.Write( node.Data + " " );
            }
        }
        public void PostOrderTraversal()
        {
            _PostOrderTraversal( this.Root );
            Console.WriteLine();
        }
        private void _InOrderTraversal( TreeNode<T> node )
        {
            if( node != null )
            {
                _InOrderTraversal( node.LeftChild );
                Console.Write( node.Data + " " );
                _InOrderTraversal( node.RightChild );
            }
        }
        public void InOrderTraversal()
        {
            _InOrderTraversal( this.Root );
            Console.WriteLine();
        }
    }
    internal class Program
    {
        static void Main( string[ ] args )
        {
            var binaryTree = new Tree<int>();
            Console.WriteLine( "Values to be inserted: 5,3,8,1,4,6,9\n" );

            binaryTree.Insert( 5 );
            binaryTree.Insert( 3 );
            binaryTree.Insert( 8 );
            binaryTree.Insert( 1 );
            binaryTree.Insert( 4 );
            binaryTree.Insert( 6 );
            binaryTree.Insert( 9 );

            binaryTree.PrintTree();
            Console.WriteLine( "\nPreOrder Traversal :" );
            binaryTree.PreOrderTraversal();
            Console.WriteLine( "\nPostOrder Traversal :" );
            binaryTree.PostOrderTraversal();
            Console.WriteLine( "\nInOrder Traversal :" );
            binaryTree.InOrderTraversal();
            Console.ReadKey();
        }
    }
}
