namespace BinarioSearchTree
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.btnshow = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.NumericInsert = new System.Windows.Forms.NumericUpDown();
            this.btnDelete = new System.Windows.Forms.Button();
            this.NumericDelete = new System.Windows.Forms.NumericUpDown();
            this.btnBusca = new System.Windows.Forms.Button();
            this.NumericSearch = new System.Windows.Forms.NumericUpDown();
            this.buttonPostorder = new System.Windows.Forms.Button();
            this.buttonInorder = new System.Windows.Forms.Button();
            this.buttonPreorder = new System.Windows.Forms.Button();
            this.btndeleteall = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.NumericInsert)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumericDelete)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumericSearch)).BeginInit();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox1.Location = new System.Drawing.Point(282, 55);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(623, 374);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            // 
            // btnshow
            // 
            this.btnshow.Location = new System.Drawing.Point(12, 81);
            this.btnshow.Name = "btnshow";
            this.btnshow.Size = new System.Drawing.Size(75, 23);
            this.btnshow.TabIndex = 1;
            this.btnshow.Text = "Mostrar";
            this.btnshow.UseVisualStyleBackColor = true;
            this.btnshow.Click += new System.EventHandler(this.btnshow_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(12, 52);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "adicionar valor";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // NumericInsert
            // 
            this.NumericInsert.Location = new System.Drawing.Point(93, 55);
            this.NumericInsert.Maximum = new decimal(new int[] {
            1569325055,
            23283064,
            0,
            0});
            this.NumericInsert.Name = "NumericInsert";
            this.NumericInsert.Size = new System.Drawing.Size(52, 20);
            this.NumericInsert.TabIndex = 3;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(12, 110);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 4;
            this.btnDelete.Text = "Deletar";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // NumericDelete
            // 
            this.NumericDelete.Location = new System.Drawing.Point(93, 113);
            this.NumericDelete.Maximum = new decimal(new int[] {
            1569325055,
            23283064,
            0,
            0});
            this.NumericDelete.Name = "NumericDelete";
            this.NumericDelete.Size = new System.Drawing.Size(52, 20);
            this.NumericDelete.TabIndex = 5;
            // 
            // btnBusca
            // 
            this.btnBusca.Location = new System.Drawing.Point(12, 139);
            this.btnBusca.Name = "btnBusca";
            this.btnBusca.Size = new System.Drawing.Size(75, 23);
            this.btnBusca.TabIndex = 6;
            this.btnBusca.Text = "Busca";
            this.btnBusca.UseVisualStyleBackColor = true;
            this.btnBusca.Click += new System.EventHandler(this.btnBusca_Click);
            // 
            // NumericSearch
            // 
            this.NumericSearch.Location = new System.Drawing.Point(93, 142);
            this.NumericSearch.Maximum = new decimal(new int[] {
            1569325055,
            23283064,
            0,
            0});
            this.NumericSearch.Name = "NumericSearch";
            this.NumericSearch.Size = new System.Drawing.Size(52, 20);
            this.NumericSearch.TabIndex = 7;
            // 
            // buttonPostorder
            // 
            this.buttonPostorder.Location = new System.Drawing.Point(12, 209);
            this.buttonPostorder.Name = "buttonPostorder";
            this.buttonPostorder.Size = new System.Drawing.Size(75, 23);
            this.buttonPostorder.TabIndex = 8;
            this.buttonPostorder.Text = "Postorder";
            this.buttonPostorder.UseVisualStyleBackColor = true;
            this.buttonPostorder.Click += new System.EventHandler(this.buttonPostorder_Click);
            // 
            // buttonInorder
            // 
            this.buttonInorder.Location = new System.Drawing.Point(12, 180);
            this.buttonInorder.Name = "buttonInorder";
            this.buttonInorder.Size = new System.Drawing.Size(75, 23);
            this.buttonInorder.TabIndex = 9;
            this.buttonInorder.Text = "Inorder";
            this.buttonInorder.UseVisualStyleBackColor = true;
            this.buttonInorder.Click += new System.EventHandler(this.buttonInorder_Click);
            // 
            // buttonPreorder
            // 
            this.buttonPreorder.Location = new System.Drawing.Point(12, 238);
            this.buttonPreorder.Name = "buttonPreorder";
            this.buttonPreorder.Size = new System.Drawing.Size(75, 23);
            this.buttonPreorder.TabIndex = 10;
            this.buttonPreorder.Text = "Preorder";
            this.buttonPreorder.UseVisualStyleBackColor = true;
            this.buttonPreorder.Click += new System.EventHandler(this.buttonPreorder_Click);
            // 
            // btndeleteall
            // 
            this.btndeleteall.Location = new System.Drawing.Point(12, 267);
            this.btndeleteall.Name = "btndeleteall";
            this.btndeleteall.Size = new System.Drawing.Size(85, 23);
            this.btndeleteall.TabIndex = 11;
            this.btndeleteall.Text = "Deletar Tudo";
            this.btndeleteall.UseVisualStyleBackColor = true;
            this.btndeleteall.Click += new System.EventHandler(this.btndeleteall_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(907, 431);
            this.Controls.Add(this.btndeleteall);
            this.Controls.Add(this.buttonPreorder);
            this.Controls.Add(this.buttonInorder);
            this.Controls.Add(this.buttonPostorder);
            this.Controls.Add(this.NumericSearch);
            this.Controls.Add(this.btnBusca);
            this.Controls.Add(this.NumericDelete);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.NumericInsert);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnshow);
            this.Controls.Add(this.richTextBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.NumericInsert)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumericDelete)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumericSearch)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button btnshow;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.NumericUpDown NumericInsert;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.NumericUpDown NumericDelete;
        private System.Windows.Forms.Button btnBusca;
        private System.Windows.Forms.NumericUpDown NumericSearch;
        private System.Windows.Forms.Button buttonPostorder;
        private System.Windows.Forms.Button buttonInorder;
        private System.Windows.Forms.Button buttonPreorder;
        private System.Windows.Forms.Button btndeleteall;
    }
}

