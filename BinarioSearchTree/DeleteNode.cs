using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarioSearchTree
{
    class DeleteNode
    {
        InsertNodeAVL Del = new InsertNodeAVL();
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
            root.value = 0;
        }


        public void DeleteAVL(int target)
        {
            Del.root = DeleteAVL(Del.root, target);
        }

        private Node DeleteAVL(Node root, int Deletevalues)
        {
            Node parent;
            if (root == null)
            { return null; }
            else
            {
                if (Deletevalues < root.value)
                {
                    root.left = DeleteAVL(root.left, Deletevalues);
                    if (Del.balance_factor(root) == -2)
                    {
                        if (Del.balance_factor(root.right) <= 0)
                        {
                            root = Del.RotateRR(root);
                        }
                        else
                        {
                            root = Del.RotateRL(root);
                        }
                    }
                }
                else if (Deletevalues > root.value)
                {
                    root.right = DeleteAVL(root.right, Deletevalues);
                    if (Del.balance_factor(root) == 2)
                    {
                        if (Del.balance_factor(root.left) >= 0)
                        {
                            root = Del.RotateLL(root);
                        }
                        else
                        {
                            root = Del.RotateLR(root);
                        }
                    }
                }
                else
                {
                    if (root.right != null)
                    {
                        parent = root.right;
                        while (parent.left != null)
                        {
                            parent = parent.left;
                        }
                        root.value = parent.value;
                        root.right = DeleteAVL(root.right, parent.value);
                        if (Del.balance_factor(root) == 2)
                        {
                            if (Del.balance_factor(root.left) >= 0)
                            {
                                root = Del.RotateLL(root);
                            }
                            else { root = Del.RotateLR(root); }
                        }
                    }
                    else
                    {
                        return root.left;
                    }
                }
            }
            return root;
        }


    }

}
