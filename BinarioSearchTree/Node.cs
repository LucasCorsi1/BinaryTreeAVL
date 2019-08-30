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


        public Node insert(Node root, int v)  // insere o valor
        {
            if (root == null)
            {
                root = new Node(v);
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

        public void TRaverisng(Node root) //perocrre os nós
        {
            if (root == null)
            {
                return;
            }

            TRaverisng(root.left);
            TRaverisng(root.right);
        }


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

