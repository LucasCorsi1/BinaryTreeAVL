using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarioSearchTree
{
    public class Node
    {
        public int value;
        Node left;
        Node right;

        public Node insert(Node root, int v)
        {
            if (root == null)
            {
                root = new Node();
                root.value = v;
            }
            else if (v < root.value)

            {
                root.left = insert(root.left, v);
            }
            else
            {
                root.right = insert(root.right, v);
            }

            return root;
        }

        public void traverse(Node root)
        {
            if (root == null)
            {
                return;
            }

            traverse(root.left);
            traverse(root.right);
        }

    }
}
