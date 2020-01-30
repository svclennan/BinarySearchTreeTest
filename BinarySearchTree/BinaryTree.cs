using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTree
{
    class BinaryTree
    {
        Node root;
        public BinaryTree()
        {
            
        }
        public void AddValue(int data)
        {
            Node node = new Node(data);
            if (root == null)
            {
                root = node;
            }
            else
            {
                Node current = root;
                if (data < current.data)
                {
                    while (data < current.data)
                    {
                        while (!(current.leftChild == null))
                        {
                            current = current.leftChild;
                        }
                        current.leftChild = node;
                    }
                }
            }
        }
    }
}
