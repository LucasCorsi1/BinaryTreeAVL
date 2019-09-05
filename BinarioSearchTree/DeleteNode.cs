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


        public void DeleteAVL(int deletevalue)
        {
            Del.root = DeleteAVL(Del.root, deletevalue);
        }

        private Node DeleteAVL(Node root, int deletevalue)
        {
            Node parent;
            if (root == null)
            { return null; }
            else
            {
                if (deletevalue < root.value)
                {
                    root.left = DeleteAVL(root.left, deletevalue);
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
                else if (deletevalue > root.value)
                {
                    root.right = DeleteAVL(root.right, deletevalue);
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
