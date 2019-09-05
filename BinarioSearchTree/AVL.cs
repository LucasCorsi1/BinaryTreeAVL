namespace BinarioSearchTree
{
    internal class AVL
    {
        public int GetMax(int large, int right)
        {
            return large > right ? large : right;
        }

        public int GetSize(Node child)
        {
            int Size = 0;
            if (child != null)
            {
                int l = GetSize(child.left);
                int r = GetSize(child.right);
                int m = GetMax(l, r);
                Size = m + 1;
            }
            return Size;
        }

        public int BalanceUiniverse(Node child)
        {
            int l = GetSize(child.left);
            int r = GetSize(child.right);
            int balance = l - r;
            return balance;
        }

        public Node RotationRR(Node child)
        {
            Node index = child.right;
            child.right = index.left;
            index.left = child;
            return index;
        }

        public Node RotationLL(Node child)
        {
            Node index = child.left;
            child.left = index.right;
            index.right = child;
            return index;
        }

        public Node RotationLR(Node child)
        {
            Node index = child.left;
            child.left = RotationRR(index);
            return RotationLL(child);
        }

        public Node RotationRL(Node child)
        {
            Node index = child.right;
            child.right = RotationLL(index);
            return RotationRR(child);
        }
    }
}
