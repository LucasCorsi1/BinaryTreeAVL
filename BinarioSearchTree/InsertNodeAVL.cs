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
            Node Item = new Node(value);
            if (root == null)
            {
                root = Item;
            }
            else
            {
                root = Insert(root, Item);
            }
        }

        private Node Insert(Node Now, Node Root)
        {
            if (Now == null)
            {
                Now = Root;
                return Now;
            }
            else if (Root.value < Now.value)
            {
                Now.left = Insert(Now.left, Root);
                Now = PerfectBalanceThanos(Now);
            }
            else if (Root.value > Now.value)
            {
                Now.right = Insert(Now.right, Root);
                Now = PerfectBalanceThanos(Now);
            }
            return Now;
        }
        public Node PerfectBalanceThanos(Node Now)
        {
            int b_factor = avl.BalanceUiniverse(Now);
            if (b_factor > 1)
            {
                if (avl.BalanceUiniverse(Now.left) > 0)
                {
                    Now = avl.RotationLL(Now);
                }
                else
                {
                    Now = avl.RotationLR(Now);
                }
            }
            else if (b_factor < -1)
            {
                if (avl.BalanceUiniverse(Now.right) > 0)
                {
                    Now = avl.RotationRL(Now);
                }
                else
                {
                    Now = avl.RotationRR(Now);
                }
            }
            return Now;
        }
    }
}
