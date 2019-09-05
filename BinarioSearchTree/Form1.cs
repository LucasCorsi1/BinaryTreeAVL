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

        InsertNodeAVL insert = new InsertNodeAVL();
        DeleteNode delete = new DeleteNode();
        Bfs search = new Bfs();



        private void printRecursive(Node root, int space)
        {
            int COUNT = 10;

            if (root == null)
                return;

            space += COUNT;

            printRecursive(root.right, space);


            richTextBox1.AppendText(Environment.NewLine);

            for (int i = COUNT; i < space; i++)
                richTextBox1.AppendText(" ");
            richTextBox1.AppendText(root.value + Environment.NewLine);

            printRecursive(root.left, space);
        }

        private void print(Node root)
        {
            richTextBox1.Clear();
            printRecursive(root, 0);
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
            print(insert.root);

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();

            int a = Convert.ToInt32(NumericInsert.Value);

            insert.Insert(a);

            print(insert.root);

        }


        private void btnDelete_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
            int a = Convert.ToInt32(NumericDelete.Value);

           //  delete.deleteNode(insert.root, a);
            delete.DeleteAVL(a);
            print(insert.root);

        }

        private void btnBusca_Click(object sender, EventArgs e)
        {
            int a = Convert.ToInt32(NumericSearch.Value);

            if (search.SearchinTree(insert.root, a))
            {
                MessageBox.Show("Valor encontrado");
            }
            else MessageBox.Show("Valor não encontrado");
        }

        private void buttonInorder_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
            inorder(insert.root);
        }

        private void buttonPostorder_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
            postorder(insert.root);
        }

        private void buttonPreorder_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
            preorder(insert.root);
        }


        private void btndeleteall_Click(object sender, EventArgs e)
        {

            delete.deleteBinaryTree(insert.root);
            print(insert.root);
        }
    }
}
