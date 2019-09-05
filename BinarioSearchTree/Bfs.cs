using System.Collections.Generic;

namespace BinarioSearchTree
{

    public class Bfs
    {
        private readonly InsertNodeAVL search = new InsertNodeAVL();

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
    }
}
