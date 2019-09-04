using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarioSearchTree
{
    class DeleteNode
    {
        public Node deleteNode(Node root, int DeleteValues) // delete
        {
            if (root == null)
            {
                return root;
            }

            if (root.value > DeleteValues)
            {
                root.left = deleteNode(root.left, DeleteValues);
                return root;
            }
            else if (root.value < DeleteValues)
            {
                root.right = deleteNode(root.right, DeleteValues);
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

                Node successorParent = root.right;

                Node succerssorvalue = root.right;

                while (succerssorvalue.left != null)
                {
                    successorParent = succerssorvalue;
                    succerssorvalue = succerssorvalue.left;
                }

                successorParent.left = succerssorvalue.right;

                root.value = succerssorvalue.value;

                succerssorvalue = null;
                return root;
            }
        }


    }

}
