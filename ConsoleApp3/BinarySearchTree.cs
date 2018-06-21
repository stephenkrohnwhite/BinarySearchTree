using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class BinarySearchTree
    {
        private Node root;

        public BinarySearchTree()
        {
            root = null;
        }

        public void Search(int element)
        {
            Search(root, element);
            Console.WriteLine();
        }

        private void Search(Node current, int element)
        {
            if(current == null)
            {
                return;
            }
            else if(current.Data == element)
            {
                Console.WriteLine("Found Match: Node = "+current.Data);
                return;
            }
            
            Search(current.Right, element);
            Search(current.Left, element);
        }

        public void AddElement(int element)
        {
            Node insertion = new Node(element);
            if (root == null)
            {
                root = insertion;
            }
            else
            {
                Node currentNode = root;
                Node parent = null; 

                while(currentNode != null)
                {
                    parent = currentNode;
                    if(element < currentNode.Data)
                    {
                        currentNode = currentNode.Left;
                        if(currentNode == null)
                        {
                            parent.Left = insertion;
                        }
                    }
                    else if(element > currentNode.Data)
                    {
                        currentNode = currentNode.Right;
                        if(currentNode == null)
                        {
                            parent.Right = insertion;
                        }
                    }
                }
            }
        }

        
    
    }
}
