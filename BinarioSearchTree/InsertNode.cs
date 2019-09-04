using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarioSearchTree
{
    class InsertNode
    {
        public Node insert(Node root, int v)  // insere o valor
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
    }
}
