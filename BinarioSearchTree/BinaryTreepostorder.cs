using System;

namespace BinarioSearchTree
{
    public class BinaryTreepostorder
    {

        Node constructTreeUtil(int[] post, Index postIndex, int key, int min, int max, int size)
        {
            if (postIndex.postindex < 0)
            {
                return null;
            }

            Node root = null;

            if (key > min && key < max)
            {

                root = new Node(key);
                postIndex.postindex = postIndex.postindex - 1;

                if (postIndex.postindex > 0)
                {

                    root.right = constructTreeUtil(post, postIndex, post[postIndex.postindex], key, max, size);

                    root.left = constructTreeUtil(post, postIndex, post[postIndex.postindex], min, key, size);
                }
            }
            return root;
        }


        Node constructTree(int[] post, int size)
        {
            Index index = new Index();
            index.postindex = size - 1;
            return constructTreeUtil(post, index, post[index.postindex], int.MinValue, int.MaxValue, size);
        }
    }
}
