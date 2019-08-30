using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BinarioSearchTree
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }




        private void print()
        {
            BinaryTreepreorder tree = new BinaryTreepreorder();
            int[] pre = new int[] { 10, 5, 1, 7, 40, 50 };
            int size = pre.Length;
            Node root = tree.constructTree(pre, size);
            Console.WriteLine("Inorder traversal of the constructed tree is ");
            tree.printInorder(root);

        }
    }
}
