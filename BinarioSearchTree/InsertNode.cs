using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarioSearchTree
{
    class InsertNode
    {

        Rotate rotate = new Rotate();

        public Node newNode(int key)
        {
            Node node = new Node();
            node.value = key;
            node.left = null;
            node.right = null;
            node.height = 1;                               
            return node;
        }

        public Node insert(Node node, int v)
        {
            if (node == null)
            {
                return (newNode(v));
            }

            if (v < node.value)
            {
                node.left = insert(node.left, v);
            }
            else if (v > node.value)
            {
                node.right = insert(node.right, v);
            }
            else
            {
                return node;
            }

            node.height = 1 +rotate.max(rotate.height(node.left),rotate.height(node.right));

            int balance =rotate.getBalance(node);

            if (balance > 1 && v < node.left.value)
            {
                return rotate.rightRotate(node);
            }


            if (balance < -1 && v > node.right.value)
            {
                return rotate.leftRotate(node);
            }

            if (balance > 1 && v > node.left.value)
            {
                node.left = rotate.leftRotate(node.left);
                return rotate.rightRotate(node);
            }

            if (balance < -1 && v < node.right.value)
            {
                node.right = rotate.rightRotate(node.right);
                return rotate.leftRotate(node);
            }
            return node;
        }
    }
}
