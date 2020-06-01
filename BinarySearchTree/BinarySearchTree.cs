using System;
using System.Collections.Generic;
using System.ComponentModel.Design.Serialization;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTree
{
    class BinarySearchTree
    {
        public Node root;
        public Node newNode;

    public BinarySearchTree()
        {
            root = new Node();
            newNode = new Node();
        }

        public void Insert (int nodeData)
        {
            if (root == null)
            {
                root.data = nodeData;
            }
            else if (nodeData < root.data)
            {
                newNode.leftNode.data = nodeData;
            }
            else if(nodeData > root.data)
            {
                newNode.rightNode.data = nodeData;
            }
        }
        
        public bool Search (int nodeData)
        {
            while (nodeData != null)
            {
                if(root.data == nodeData)
                {
                    return true;
                }
                else if(root.data > nodeData)
                {
                    newNode = newNode.leftNode;
                }
                else (root.data < nodeData)
                {
                    newNode = newNode.rightNode
                }
                return false;    
            }
        }
    }
}
