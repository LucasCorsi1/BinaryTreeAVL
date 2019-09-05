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

        private Node DeleteAVL(Node current, int target)
        {
            Node parent;
            if (current == null)
            { return null; }
            else
            {
                if (target < current.value)
                {
                    current.left = DeleteAVL(current.left, target);
                    if (Del.balance_factor(current) == -2)
                    {
                        if (Del.balance_factor(current.right) <= 0)
                        {
                            current = Del.RotateRR(current);
                        }
                        else
                        {
                            current = Del.RotateRL(current);
                        }
                    }
                }
                else if (target > current.value)
                {
                    current.right = DeleteAVL(current.right, target);
                    if (Del.balance_factor(current) == 2)
                    {
                        if (Del.balance_factor(current.left) >= 0)
                        {
                            current = Del.RotateLL(current);
                        }
                        else
                        {
                            current = Del.RotateLR(current);
                        }
                    }
                }
                else
                {
                    if (current.right != null)
                    {
                        parent = current.right;
                        while (parent.left != null)
                        {
                            parent = parent.left;
                        }
                        current.value = parent.value;
                        current.right = DeleteAVL(current.right, parent.value);
                        if (Del.balance_factor(current) == 2)
                        {
                            if (Del.balance_factor(current.left) >= 0)
                            {
                                current = Del.RotateLL(current);
                            }
                            else { current = Del.RotateLR(current); }
                        }
                    }
                    else
                    {
                        return current.left;
                    }
                }
            }
            return current;
        }


    }

}
