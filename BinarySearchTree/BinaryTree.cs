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
        public List<int> values;
        public BinaryTree()
        {
            values = new List<int>();
        }
        private bool AddValue(int data, Node start)
        {
            if (root == null)
            {
                root = new Node(data);
                values.Add(data);
                return true;
            }
            else
            {
                if (data <= start.data)
                {
                    if (!(start.leftChild == null))
                    {
                        return AddValue(data, start.leftChild);
                    }
                    else
                    {
                        start.leftChild = new Node(data);
                        values.Add(data);
                        return true;
                    }
                }
                else if (data > start.data)
                {
                    if (!(start.rightChild == null))
                    {
                        return AddValue(data, start.rightChild);
                    }
                    else
                    {
                        start.rightChild = new Node(data);
                        values.Add(data);
                        return true;
                    }
                }
                else
                {
                    return false;
                }
            }
        }
        public bool AddValue(int data)
        {
            if (root == null)
            {
                Node node = new Node(data);
                root = node;
                values.Add(data);
                return true;
            }
            else
            {
                return AddValue(data, root);
            }
        }
        public bool Search(int data)
        {
            if (root.data == data)
            {
                return true;
            }
            else if (data > root.data)
            {
                if (root.rightChild == null)
                {
                    return false;
                }
                return Search(data, root.rightChild);
            }
            else if (data < root.data)
            {
                if (root.leftChild == null)
                {
                    return false;
                }
                return Search(data, root.leftChild);
            }
            else
            {
                return false;
            }
        }
        private bool Search(int data, Node start)
        {
            if (start.data == data)
            {
                return true;
            }
            else if (data > start.data)
            {
                if (start.rightChild == null)
                {
                    return false;
                }
                return Search(data, start.rightChild);
            }
            else if (data < start.data)
            {
                if (start.leftChild == null)
                {
                    return false;
                }
                return Search(data, start.leftChild);
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
