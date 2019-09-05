namespace BinarioSearchTree
{
    internal class DeleteNode
    {
        private InsertNodeAVL Root = new InsertNodeAVL();
        private AVL Del = new AVL();

        public Node deleteBinaryTree(Node root)
        {
            if (root == null)
            {
                return null;
            }
            deleteBinaryTree(root.left);
            root.left = null;
            deleteBinaryTree(root.right);
            root.right = null;
            Root.root = null;
            root.value = 0;

            return root = null;
        }


        public Node DeleteAVL(Node DeleteRoot, int deletevalue)
        {
            Node Child;

            if (DeleteRoot == null)
            {
                return null;
            }
            else
            {
                if (deletevalue < DeleteRoot.value)
                {
                    DeleteRoot.left = DeleteAVL(DeleteRoot.left, deletevalue);
                    if (Del.BalanceUiniverse(DeleteRoot) == -2)
                    {
                        if (Del.BalanceUiniverse(DeleteRoot.right) <= 0)
                        {
                            DeleteRoot = Del.RotationRR(DeleteRoot);
                        }
                        else
                        {
                            DeleteRoot = Del.RotationRL(DeleteRoot);
                        }
                    }
                }
                else if (deletevalue > DeleteRoot.value)
                {
                    DeleteRoot.right = DeleteAVL(DeleteRoot.right, deletevalue);
                    if (Del.BalanceUiniverse(DeleteRoot) == 2)
                    {
                        if (Del.BalanceUiniverse(DeleteRoot.left) >= 0)
                        {
                            DeleteRoot = Del.RotationLL(DeleteRoot);
                        }
                        else
                        {
                            DeleteRoot = Del.RotationLR(DeleteRoot);
                        }
                    }
                }
                else
                {
                    if (DeleteRoot.right != null)
                    {
                        Child = DeleteRoot.right;
                        while (Child.left != null)
                        {
                            Child = Child.left;
                        }
                        DeleteRoot.value = Child.value;
                        DeleteRoot.right = DeleteAVL(DeleteRoot.right, Child.value);
                        if (Del.BalanceUiniverse(DeleteRoot) == 2)
                        {
                            if (Del.BalanceUiniverse(DeleteRoot.left) >= 0)
                            {
                                DeleteRoot = Del.RotationLL(DeleteRoot);
                            }
                            else { DeleteRoot = Del.RotationLR(DeleteRoot); }
                        }
                    }
                    else
                    {
                        return DeleteRoot.left;
                    }
                }
            }
            return DeleteRoot;
        }


    }

}
