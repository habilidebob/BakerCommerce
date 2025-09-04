namespace BakerCommerce
{
    partial class FormProdutos
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
            this.dgvProdutos = new System.Windows.Forms.DataGridView();
            this.grbCadastrar = new System.Windows.Forms.GroupBox();
            this.lblNomeCadastro = new System.Windows.Forms.Label();
            this.txbNomeCadastro = new System.Windows.Forms.TextBox();
            this.txbPrecoCadastro = new System.Windows.Forms.TextBox();
            this.lblPrecoCadastro = new System.Windows.Forms.Label();
            this.lblCategoriaCadastro = new System.Windows.Forms.Label();
            this.cmbCategoriaCadastro = new System.Windows.Forms.ComboBox();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.grbEditar = new System.Windows.Forms.GroupBox();
            this.btnEditar = new System.Windows.Forms.Button();
            this.cmbCategoriaEditar = new System.Windows.Forms.ComboBox();
            this.lblCategoriaEditar = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblPrecoEditar = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.lblNomeEditar = new System.Windows.Forms.Label();
            this.grbApagar = new System.Windows.Forms.GroupBox();
            this.btnApagar = new System.Windows.Forms.Button();
            this.lblApagarDescricao = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.pibIcone = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProdutos)).BeginInit();
            this.grbCadastrar.SuspendLayout();
            this.grbEditar.SuspendLayout();
            this.grbApagar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pibIcone)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvProdutos
            // 
            this.dgvProdutos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProdutos.Location = new System.Drawing.Point(54, 93);
            this.dgvProdutos.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvProdutos.Name = "dgvProdutos";
            this.dgvProdutos.Size = new System.Drawing.Size(888, 334);
            this.dgvProdutos.TabIndex = 0;
            // 
            // grbCadastrar
            // 
            this.grbCadastrar.Controls.Add(this.btnCadastrar);
            this.grbCadastrar.Controls.Add(this.cmbCategoriaCadastro);
            this.grbCadastrar.Controls.Add(this.lblCategoriaCadastro);
            this.grbCadastrar.Controls.Add(this.txbPrecoCadastro);
            this.grbCadastrar.Controls.Add(this.lblPrecoCadastro);
            this.grbCadastrar.Controls.Add(this.txbNomeCadastro);
            this.grbCadastrar.Controls.Add(this.lblNomeCadastro);
            this.grbCadastrar.Location = new System.Drawing.Point(54, 447);
            this.grbCadastrar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grbCadastrar.Name = "grbCadastrar";
            this.grbCadastrar.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grbCadastrar.Size = new System.Drawing.Size(449, 246);
            this.grbCadastrar.TabIndex = 1;
            this.grbCadastrar.TabStop = false;
            this.grbCadastrar.Text = "Cadastrar";
            // 
            // lblNomeCadastro
            // 
            this.lblNomeCadastro.AutoSize = true;
            this.lblNomeCadastro.Location = new System.Drawing.Point(85, 44);
            this.lblNomeCadastro.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNomeCadastro.Name = "lblNomeCadastro";
            this.lblNomeCadastro.Size = new System.Drawing.Size(50, 16);
            this.lblNomeCadastro.TabIndex = 0;
            this.lblNomeCadastro.Text = "Nome: ";
            // 
            // txbNomeCadastro
            // 
            this.txbNomeCadastro.Location = new System.Drawing.Point(140, 41);
            this.txbNomeCadastro.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txbNomeCadastro.Name = "txbNomeCadastro";
            this.txbNomeCadastro.Size = new System.Drawing.Size(227, 23);
            this.txbNomeCadastro.TabIndex = 1;
            // 
            // txbPrecoCadastro
            // 
            this.txbPrecoCadastro.Location = new System.Drawing.Point(140, 73);
            this.txbPrecoCadastro.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txbPrecoCadastro.Name = "txbPrecoCadastro";
            this.txbPrecoCadastro.Size = new System.Drawing.Size(227, 23);
            this.txbPrecoCadastro.TabIndex = 3;
            // 
            // lblPrecoCadastro
            // 
            this.lblPrecoCadastro.AutoSize = true;
            this.lblPrecoCadastro.Location = new System.Drawing.Point(85, 76);
            this.lblPrecoCadastro.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPrecoCadastro.Name = "lblPrecoCadastro";
            this.lblPrecoCadastro.Size = new System.Drawing.Size(43, 16);
            this.lblPrecoCadastro.TabIndex = 2;
            this.lblPrecoCadastro.Text = "Preço:";
            // 
            // lblCategoriaCadastro
            // 
            this.lblCategoriaCadastro.AutoSize = true;
            this.lblCategoriaCadastro.Location = new System.Drawing.Point(65, 110);
            this.lblCategoriaCadastro.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCategoriaCadastro.Name = "lblCategoriaCadastro";
            this.lblCategoriaCadastro.Size = new System.Drawing.Size(70, 16);
            this.lblCategoriaCadastro.TabIndex = 4;
            this.lblCategoriaCadastro.Text = "Categoria: ";
            // 
            // cmbCategoriaCadastro
            // 
            this.cmbCategoriaCadastro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCategoriaCadastro.FormattingEnabled = true;
            this.cmbCategoriaCadastro.Location = new System.Drawing.Point(141, 106);
            this.cmbCategoriaCadastro.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbCategoriaCadastro.Name = "cmbCategoriaCadastro";
            this.cmbCategoriaCadastro.Size = new System.Drawing.Size(226, 24);
            this.cmbCategoriaCadastro.TabIndex = 5;
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadastrar.Location = new System.Drawing.Point(50, 150);
            this.btnCadastrar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(317, 53);
            this.btnCadastrar.TabIndex = 6;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            // 
            // grbEditar
            // 
            this.grbEditar.Controls.Add(this.btnEditar);
            this.grbEditar.Controls.Add(this.cmbCategoriaEditar);
            this.grbEditar.Controls.Add(this.lblCategoriaEditar);
            this.grbEditar.Controls.Add(this.textBox1);
            this.grbEditar.Controls.Add(this.lblPrecoEditar);
            this.grbEditar.Controls.Add(this.textBox2);
            this.grbEditar.Controls.Add(this.lblNomeEditar);
            this.grbEditar.Location = new System.Drawing.Point(510, 447);
            this.grbEditar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grbEditar.Name = "grbEditar";
            this.grbEditar.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grbEditar.Size = new System.Drawing.Size(432, 246);
            this.grbEditar.TabIndex = 7;
            this.grbEditar.TabStop = false;
            this.grbEditar.Text = "Editar";
            // 
            // btnEditar
            // 
            this.btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditar.Location = new System.Drawing.Point(50, 150);
            this.btnEditar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(317, 53);
            this.btnEditar.TabIndex = 6;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            // 
            // cmbCategoriaEditar
            // 
            this.cmbCategoriaEditar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCategoriaEditar.FormattingEnabled = true;
            this.cmbCategoriaEditar.Location = new System.Drawing.Point(141, 106);
            this.cmbCategoriaEditar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbCategoriaEditar.Name = "cmbCategoriaEditar";
            this.cmbCategoriaEditar.Size = new System.Drawing.Size(226, 24);
            this.cmbCategoriaEditar.TabIndex = 5;
            // 
            // lblCategoriaEditar
            // 
            this.lblCategoriaEditar.AutoSize = true;
            this.lblCategoriaEditar.Location = new System.Drawing.Point(65, 110);
            this.lblCategoriaEditar.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCategoriaEditar.Name = "lblCategoriaEditar";
            this.lblCategoriaEditar.Size = new System.Drawing.Size(70, 16);
            this.lblCategoriaEditar.TabIndex = 4;
            this.lblCategoriaEditar.Text = "Categoria: ";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(140, 73);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(227, 23);
            this.textBox1.TabIndex = 3;
            // 
            // lblPrecoEditar
            // 
            this.lblPrecoEditar.AutoSize = true;
            this.lblPrecoEditar.Location = new System.Drawing.Point(85, 76);
            this.lblPrecoEditar.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPrecoEditar.Name = "lblPrecoEditar";
            this.lblPrecoEditar.Size = new System.Drawing.Size(43, 16);
            this.lblPrecoEditar.TabIndex = 2;
            this.lblPrecoEditar.Text = "Preço:";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(140, 41);
            this.textBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(227, 23);
            this.textBox2.TabIndex = 1;
            // 
            // lblNomeEditar
            // 
            this.lblNomeEditar.AutoSize = true;
            this.lblNomeEditar.Location = new System.Drawing.Point(85, 44);
            this.lblNomeEditar.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNomeEditar.Name = "lblNomeEditar";
            this.lblNomeEditar.Size = new System.Drawing.Size(50, 16);
            this.lblNomeEditar.TabIndex = 0;
            this.lblNomeEditar.Text = "Nome: ";
            // 
            // grbApagar
            // 
            this.grbApagar.Controls.Add(this.btnApagar);
            this.grbApagar.Controls.Add(this.lblApagarDescricao);
            this.grbApagar.Enabled = false;
            this.grbApagar.Location = new System.Drawing.Point(56, 701);
            this.grbApagar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grbApagar.Name = "grbApagar";
            this.grbApagar.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grbApagar.Size = new System.Drawing.Size(887, 90);
            this.grbApagar.TabIndex = 8;
            this.grbApagar.TabStop = false;
            this.grbApagar.Text = "Apagar";
            // 
            // btnApagar
            // 
            this.btnApagar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnApagar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnApagar.Location = new System.Drawing.Point(700, 26);
            this.btnApagar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnApagar.Name = "btnApagar";
            this.btnApagar.Size = new System.Drawing.Size(166, 49);
            this.btnApagar.TabIndex = 1;
            this.btnApagar.Text = "Apagar";
            this.btnApagar.UseVisualStyleBackColor = true;
            // 
            // lblApagarDescricao
            // 
            this.lblApagarDescricao.AutoSize = true;
            this.lblApagarDescricao.Location = new System.Drawing.Point(28, 44);
            this.lblApagarDescricao.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblApagarDescricao.Name = "lblApagarDescricao";
            this.lblApagarDescricao.Size = new System.Drawing.Size(208, 16);
            this.lblApagarDescricao.TabIndex = 0;
            this.lblApagarDescricao.Text = "Selecione um produto para apagar.";
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Futura Bk BT", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(402, 25);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(443, 42);
            this.lblTitulo.TabIndex = 11;
            this.lblTitulo.Text = "Gerenciamento de Produtos";
            // 
            // pibIcone
            // 
            this.pibIcone.Image = global::BakerCommerce.Properties.Resources.add_cart;
            this.pibIcone.Location = new System.Drawing.Point(851, 8);
            this.pibIcone.Name = "pibIcone";
            this.pibIcone.Size = new System.Drawing.Size(91, 78);
            this.pibIcone.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pibIcone.TabIndex = 10;
            this.pibIcone.TabStop = false;
            // 
            // FormProdutos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(976, 810);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.pibIcone);
            this.Controls.Add(this.grbApagar);
            this.Controls.Add(this.grbEditar);
            this.Controls.Add(this.grbCadastrar);
            this.Controls.Add(this.dgvProdutos);
            this.Font = new System.Drawing.Font("Futura Bk BT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FormProdutos";
            this.Text = "*";
            ((System.ComponentModel.ISupportInitialize)(this.dgvProdutos)).EndInit();
            this.grbCadastrar.ResumeLayout(false);
            this.grbCadastrar.PerformLayout();
            this.grbEditar.ResumeLayout(false);
            this.grbEditar.PerformLayout();
            this.grbApagar.ResumeLayout(false);
            this.grbApagar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pibIcone)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvProdutos;
        private System.Windows.Forms.GroupBox grbCadastrar;
        private System.Windows.Forms.Label lblNomeCadastro;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.ComboBox cmbCategoriaCadastro;
        private System.Windows.Forms.Label lblCategoriaCadastro;
        private System.Windows.Forms.TextBox txbPrecoCadastro;
        private System.Windows.Forms.Label lblPrecoCadastro;
        private System.Windows.Forms.TextBox txbNomeCadastro;
        private System.Windows.Forms.GroupBox grbEditar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.ComboBox cmbCategoriaEditar;
        private System.Windows.Forms.Label lblCategoriaEditar;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lblPrecoEditar;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label lblNomeEditar;
        private System.Windows.Forms.GroupBox grbApagar;
        private System.Windows.Forms.Button btnApagar;
        private System.Windows.Forms.Label lblApagarDescricao;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.PictureBox pibIcone;
    }
}