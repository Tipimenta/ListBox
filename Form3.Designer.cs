namespace CestasDaPrima
{
    partial class Form3
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lsvItens = new System.Windows.Forms.ListView();
            this.btnAdicionar = new System.Windows.Forms.Button();
            this.btnRemover = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textNome = new System.Windows.Forms.TextBox();
            this.textPreco = new System.Windows.Forms.TextBox();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lsvItens
            // 
            this.lsvItens.HideSelection = false;
            this.lsvItens.Location = new System.Drawing.Point(14, 12);
            this.lsvItens.Name = "lsvItens";
            this.lsvItens.Size = new System.Drawing.Size(284, 426);
            this.lsvItens.TabIndex = 0;
            this.lsvItens.UseCompatibleStateImageBehavior = false;
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.Location = new System.Drawing.Point(417, 362);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(141, 65);
            this.btnAdicionar.TabIndex = 1;
            this.btnAdicionar.Text = "Adicionar Produto";
            this.btnAdicionar.UseVisualStyleBackColor = true;
            this.btnAdicionar.Click += new System.EventHandler(this.btnAdicionar_Click);
            // 
            // btnRemover
            // 
            this.btnRemover.Location = new System.Drawing.Point(417, 248);
            this.btnRemover.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnRemover.Name = "btnRemover";
            this.btnRemover.Size = new System.Drawing.Size(141, 58);
            this.btnRemover.TabIndex = 2;
            this.btnRemover.Text = "Remover Produto";
            this.btnRemover.UseVisualStyleBackColor = true;
            this.btnRemover.Click += new System.EventHandler(this.btnRemover_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(417, 152);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(141, 58);
            this.btnEditar.TabIndex = 3;
            this.btnEditar.Text = "Editar Produto";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(417, 48);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(141, 26);
            this.textBox1.TabIndex = 4;
            // 
            // textNome
            // 
            this.textNome.Location = new System.Drawing.Point(417, 46);
            this.textNome.Name = "textNome";
            this.textNome.Size = new System.Drawing.Size(141, 26);
            this.textNome.TabIndex = 4;
            // 
            // textPreco
            // 
            this.textPreco.Location = new System.Drawing.Point(417, 99);
            this.textPreco.Name = "textPreco";
            this.textPreco.Size = new System.Drawing.Size(141, 26);
            this.textPreco.TabIndex = 5;
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(417, 152);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(141, 58);
            this.btnSalvar.TabIndex = 6;
            this.btnSalvar.Text = "Salvar Edição";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Visible = false;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 449);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.textPreco);
            this.Controls.Add(this.textNome);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnRemover);
            this.Controls.Add(this.btnAdicionar);
            this.Controls.Add(this.lsvItens);
            this.Name = "Form3";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lsvItens;
        private System.Windows.Forms.Button btnAdicionar;
        private System.Windows.Forms.Button btnRemover;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textNome;
        private System.Windows.Forms.TextBox textPreco;
        private System.Windows.Forms.Button btnSalvar;
    }
}