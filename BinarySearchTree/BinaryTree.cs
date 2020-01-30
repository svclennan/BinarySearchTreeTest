using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTree
{
    class BinaryTree
    {
        public Node root;
        public BinaryTree()
        {
            root = null;
        }

        public bool AddValue(int data, Node current = null)
        {
            if (current == null)
            {
                if (root == null)
                {
                    Node node = new Node(data);
                    root = node;
                    return true;
                }
                current = root;
            }
            if (data <= current.data)
            {
                if (!(current.leftChild == null))
                {
                    return AddValue(data, current.leftChild);
                }
                else
                {
                    current.leftChild = new Node(data);
                    return true;
                }
            }
            else if (data > current.data)
            {
                if (!(current.rightChild == null))
                {
                    return AddValue(data, current.rightChild);
                }
                else
                {
                    current.rightChild = new Node(data);
                    return true;
                }
            }
            else
            {
                return false;
            }
        }
        public bool Search(int data, Node current = null)
        {
            if (current == null)
            {
                current = root;
            }
            if (current.data == data)
            {
                return true;
            }
            else if (data > current.data)
            {
                if (current.rightChild == null)
                {
                    return false;
                }
                return Search(data, current.rightChild);
            }
            else if (data < current.data)
            {
                if (current.leftChild == null)
                {
                    return false;
                }
                return Search(data, current.leftChild);
            }
            else
            {
                return false;
            }
        }

        public void Print(Node start)
        {
            Console.WriteLine(start.data);
            if (start.leftChild != null)
            {
                Console.WriteLine("/");
                Print(start.leftChild);
            }
            if (start.rightChild != null)
            {
                Console.WriteLine("\\");
                Print(start.rightChild);
            }
        }
    }
}