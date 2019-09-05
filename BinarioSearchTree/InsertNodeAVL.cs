using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarioSearchTree
{
    class InsertNodeAVL
    {
        public Node root;
        AVL avl = new AVL();
       
        public void Insert(int value)
        {
            Node newItem = new Node(value);
            if (root == null)
            {
                root = newItem;
            }
            else
            {
                root = Insert(root, newItem);
            }
        }

        private Node Insert(Node current, Node n)
        {
            if (current == null)
            {
                current = n;
                return current;
            }
            else if (n.value < current.value)
            {
                current.left = Insert(current.left, n);
                current = balance_tree(current);
            }
            else if (n.value > current.value)
            {
                current.right = Insert(current.right, n);
                current = balance_tree(current);
            }
            return current;
        }
        public Node balance_tree(Node current)
        {
            int b_factor = avl.balance_factor(current);
            if (b_factor > 1)
            {
                if (avl.balance_factor(current.left) > 0)
                {
                    current = avl.RotateLL(current);
                }
                else
                {
                    current = avl.RotateLR(current);
                }
            }
            else if (b_factor < -1)
            {
                if (avl.balance_factor(current.right) > 0)
                {
                    current = avl.RotateRL(current);
                }
                else
                {
                    current = avl.RotateRR(current);
                }
            }
            return current;
        }
    }
}
