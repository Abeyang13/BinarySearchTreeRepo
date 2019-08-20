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

    }
}
