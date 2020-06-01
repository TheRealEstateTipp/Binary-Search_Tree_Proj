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
            BinarySearchTree newTree = new BinarySearchTree();
            newTree.Insert(40);
            newTree.Insert(25);
            newTree.Insert(60);
            newTree.Insert(20);
            newTree.Insert(52);

            Console.ReadLine();
            
        }
    }
}
