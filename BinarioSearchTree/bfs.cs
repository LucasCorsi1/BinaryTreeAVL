using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarioSearchTree
{

    public class Bfs
    {
        InsertNodeAVL search = new InsertNodeAVL();

        public bool SearchinTree(Node root, int value)
        {
            Queue<Node> queue = new Queue<Node>();
            queue.Enqueue(root);
            while (queue.Count != 0)
            {
                Node tempNode = queue.Dequeue();

                if (tempNode.left != null)
                {
                    queue.Enqueue(tempNode.left);
                }

                if (tempNode.right != null)
                {
                    queue.Enqueue(tempNode.right);
                }
                if (tempNode.value == value) { return true; }

            }
            return false;

        }

        public bool Find(int v)
        {
            if (Find(v,search.root ).value == v)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private Node Find(int target, Node current)
        {

            if (target < current.value)
            {
                if (target == current.value)
                {
                    return current;
                }
                else
                    return Find(target, current.left);
            }
            else
            {
                if (target == current.value)
                {
                    return current;
                }
                else
                    return Find(target, current.right);
            }

        }

    }
}
