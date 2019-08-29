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

        public void traversing(Node root) //perocrre os nós
        {
            if (root == null)
            {
                return;
            }

            traversing(root.left);
            traversing(root.right);
        }


        public Node deleteNode(Node root, int k) // delete
        {
            if (root == null)
            {
                return root;
            }

            if (root.value > k)
            {
                root.left = deleteNode(root.left, k);
                return root;
            }
            else if (root.value < k)
            {
                root.right = deleteNode(root.right, k);
                return root;
            }

            if (root.left == null)
            {
                Node temp = root.right;
                root = null;
                return temp;
            }
            else if (root.right == null)
            {
                Node temp = root.left;
                root = null;
                return temp;
            }

            else
            {

                Node succParent = root.right;

                Node succ = root.right;
                while (succ.left != null)
                {
                    succParent = succ;
                    succ = succ.left;
                }

                succParent.left = succ.right;

                root.value = succ.value;

                succ = null;
                return root;
            }
        }


    }

}

