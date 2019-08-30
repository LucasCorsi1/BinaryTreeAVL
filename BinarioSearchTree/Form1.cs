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
            print();
        }

        public void TRaverisng(Node root) //percorre os nós
        {
            if (root == null)
            {
                return;
            }

            TRaverisng(root.left);
            TRaverisng(root.right);
        }


        private void print()
        {

        }
    }
}
