namespace BinarioSearchTree
{
    public class Node
    {
        public int value;
        public Node left;
        public Node right;

        public Node(int d)
        {
            value = d;
            left = right = null;
        }

        private void inorder(Node root)
        {
            if (root == null)
            {
                return;
            }
            inorder(root.left);
            inorder(root.right);
        }


        private void preorder(Node root)
        {
            if (root == null)
            {
                return;
            }
            preorder(root.left);
            preorder(root.right);
        }



        private void postorder(Node root)
        {
            if (root == null)
            {
                return;
            }
            postorder(root.left);
            postorder(root.right);
        }
    }
}

