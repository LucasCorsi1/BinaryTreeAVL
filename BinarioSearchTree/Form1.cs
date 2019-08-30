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

        }


        private void inorder(Node root)
        {
            if (root == null)
            {
                return;
            }
            inorder(root.left);
            // printar valor aqui nesta linha <-
            inorder(root.right);
        }


        private void preorder(Node root)
        {
            if (root == null)
            {
                return;
            }
            //Printar valor aqui nesta linha <-
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
            //printar valor aqui nesta linha <-
        }


    }
}
