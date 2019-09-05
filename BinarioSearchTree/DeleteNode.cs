using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarioSearchTree
{
    class DeleteNode
    {
        Rasengan rodaroda = new Rasengan();

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
                root.right = null;
                return temp;
            }
            else if (root.right == null)
            {
                Node temp = root.left;
                root.left = null;
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

        public void deleteBinaryTree(Node root)
        {
            if (root == null)
            {
                return;
            }
            deleteBinaryTree(root.left);
            root.left = null;
            deleteBinaryTree(root.right);
            root.right = null;
        }

        /*

        private void DeleteBalance(Node node, int balance)
        {
            while (node != null)
            {
                balance = (node.Balance += balance);

                if (balance == 2)
                {
                    if (node.left.Balance >= 0)
                    {
                        node = rodaroda.RotateRight(node);

                        if (node.Balance == -1)
                        {
                            return;
                        }
                    }
                    else
                    {
                        node =rodaroda.RotateLeftRight(node);
                    }
                }
                else if (balance == -2)
                {
                    if (node.right.Balance <= 0)
                    {
                        node =rodaroda.RotateLeft(node);

                        if (node.Balance == 1)
                        {
                            return;
                        }
                    }
                    else
                    {
                        node = rodaroda.RotateRightLeft(node);
                    }
                }
                else if (balance != 0)
                {
                    return;
                }

                Node parent = node.parent;

                if (parent != null)
                {
                    balance = parent.left == node ? -1 : 1;
                }

                node = parent;
            }
        }*/


    }

}
