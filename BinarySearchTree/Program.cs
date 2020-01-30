using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTree
{
    class Program
    {
        static void Main(string[] args)
        {
            BinaryTree binaryTree = new BinaryTree();
            binaryTree.AddValue(5);
            binaryTree.AddValue(10);
            binaryTree.AddValue(3);
            binaryTree.AddValue(4);
            binaryTree.AddValue(8);
            binaryTree.Print(binaryTree.root);
            Console.WriteLine(binaryTree.Search(3));
            Console.WriteLine(binaryTree.Search(15));
            Console.ReadLine();
        }
    }
}
