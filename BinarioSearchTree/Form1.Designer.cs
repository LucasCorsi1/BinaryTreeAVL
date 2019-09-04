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
            ((System.ComponentModel.ISupportInitialize)(this.NumericInsert)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumericDelete)).BeginInit();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(293, 64);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(602, 374);
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
            this.btnDelete.Text = "Delete";
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(917, 450);
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
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button btnshow;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.NumericUpDown NumericInsert;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.NumericUpDown NumericDelete;
    }
}

