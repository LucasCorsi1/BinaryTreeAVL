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

        Node root = new Node();
        InsertNode insert = new InsertNode();
        DeleteNode delete = new DeleteNode();
        Bfs search = new Bfs();



        private void print2DUtil(Node root, int space)
        {
            int COUNT = 10;

            if (root == null)
                return;

            space += COUNT;

            print2DUtil(root.right, space);


            richTextBox1.AppendText(Environment.NewLine);

            for (int i = COUNT; i < space; i++)
                richTextBox1.AppendText(" ");
            richTextBox1.AppendText(root.value + Environment.NewLine);

            print2DUtil(root.left, space);
        }

        private void print2D(Node root)
        {
            richTextBox1.Clear();
            print2DUtil(root, 0);
        }


        private void inorder(Node root)
        {
            if (root == null)
            {
                return;
            }
            inorder(root.left);
            richTextBox1.AppendText(root.value + " ");
            inorder(root.right);
        }


        private void preorder(Node root)
        {
            if (root == null)
            {
                return;
            }
            richTextBox1.AppendText(root.value + " ");
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
            richTextBox1.AppendText(root.value + " ");
        }

        private void btnshow_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
            print2D(root);

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
            int a = Convert.ToInt32(NumericInsert.Value);

            insert.insert(root, a);
            print2D(root);

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
            int a = Convert.ToInt32(NumericDelete.Value);

            delete.deleteNode(root, a);
            print2D(root);

        }

        private void btnBusca_Click(object sender, EventArgs e)
        {
            int a = Convert.ToInt32(NumericSearch.Value);

            if (search.SearchinTree(root, a))
            {
                MessageBox.Show("Valor encontrado");
            }
            else MessageBox.Show("Valor não encontrado");
        }

        private void buttonInorder_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
            inorder(root);
        }

        private void buttonPostorder_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
            postorder(root);
        }

        private void buttonPreorder_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
            preorder(root);
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
        }

        private void btndeleteall_Click(object sender, EventArgs e)
        {
            
            deleteBinaryTree(root);
            print2D(root);
        }
    }
}
