using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarioSearchTree
{

    public class Bfs
    {
        public bool SearchinTree(Node root, int value)
        {
            bool done = false;
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
                if(tempNode == root) {return done = true; }

            }
            return done = false;
            
        }
    }
}
