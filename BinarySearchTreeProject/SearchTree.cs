using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTreeProject
{
    class SearchTree
    {
        private Node root;


        public SearchTree()
        {
            root = null;
        }
        
        public void Add(int data)
        {
            Node node = new Node(data);
            if (root == null)
            {
                root = node;               
            }
            else
            {
                Node current = root;
                while(true)
                {
                    if (node.data <= current.data)
                    {
                        if (current.leftChild == null)
                        {
                            current.leftChild = node;
                            break;
                        }
                        else
                        {
                            current = current.leftChild;
                        }
                    }
                    else if (node.data > current.data)
                    {
                        if (current.rightChild == null)
                        {
                            current.rightChild = node;
                            break;
                        }
                        else
                        {
                            current = current.rightChild;
                        }
                    }
                }
            }
        }
        public void Search(int x)
        {
            Node current = root;
            while (current != null)
            {
                if (x < current.data)
                {
                    if (current.leftChild != null)
                    {
                        current = current.leftChild;
                        Console.WriteLine("Moving left");
                    }
                    else
                    {
                        Console.WriteLine("Number can't be found");
                        break;
                    }
                }
                else if (x > current.data)
                {
                    if(current.rightChild != null)
                    {
                        current = current.rightChild;
                        Console.WriteLine("Moving right");
                    }
                    else
                    {
                        Console.WriteLine("Number can't be found");
                        break;
                    }             
                }
                else if (x == current.data)
                {
                    Console.WriteLine($"We've found {x} ");
                    break;
                }
            }
        }
    }
}
