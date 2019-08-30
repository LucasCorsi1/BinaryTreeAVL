using System;

namespace BinarioSearchTree
{

    public class BinaryTreepreorder
    {
        public Index index = new Index();

        public  Node constructTreeUtil(int[] pre, Index preIndex, int low, int high, int size)
        {
            if (preIndex.index >= size || low > high)
            {
                return null;
            }
            Node root = new Node(pre[preIndex.index]);

            preIndex.index = preIndex.index + 1;

            if (low == high)
            {
                return root;
            }

            int i;
            for (i = low; i <= high; ++i)
            {
                if (pre[i] > root.value)
                {
                    break;
                }
            }

            root.left = constructTreeUtil(pre, preIndex, preIndex.index,i - 1, size);
        
            root.right = constructTreeUtil(pre, preIndex, i, high, size);

            return root;
        }

        public  Node constructTree(int[] pre, int size)
        {
            return constructTreeUtil(pre, index, 0, size - 1, size);
        }
    }
}
