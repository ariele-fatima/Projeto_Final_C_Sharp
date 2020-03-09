namespace ProjetoFinal.ProdutosMarcas.Apresentacao
{
    partial class FrmPrincipal
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvMarcas = new System.Windows.Forms.DataGridView();
            this.IdMarca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NomeMarca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvProdutos = new System.Windows.Forms.DataGridView();
            this.IdProduto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdMarcaProduto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NomeProduto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MarcaProduto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnCadastrarMarca = new System.Windows.Forms.Button();
            this.btnCadastrarProduto = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMarcas)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProdutos)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnCadastrarMarca);
            this.groupBox1.Controls.Add(this.dgvMarcas);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(760, 200);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Marcas cadastradas";
            // 
            // dgvMarcas
            // 
            this.dgvMarcas.AllowUserToAddRows = false;
            this.dgvMarcas.AllowUserToDeleteRows = false;
            this.dgvMarcas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMarcas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdMarca,
            this.NomeMarca});
            this.dgvMarcas.Location = new System.Drawing.Point(7, 20);
            this.dgvMarcas.Name = "dgvMarcas";
            this.dgvMarcas.ReadOnly = true;
            this.dgvMarcas.Size = new System.Drawing.Size(600, 170);
            this.dgvMarcas.TabIndex = 0;
            // 
            // IdMarca
            // 
            this.IdMarca.DataPropertyName = "Id";
            this.IdMarca.HeaderText = "Id";
            this.IdMarca.Name = "IdMarca";
            this.IdMarca.ReadOnly = true;
            this.IdMarca.Visible = false;
            // 
            // NomeMarca
            // 
            this.NomeMarca.DataPropertyName = "Nome";
            this.NomeMarca.HeaderText = "Nome da Marca";
            this.NomeMarca.Name = "NomeMarca";
            this.NomeMarca.ReadOnly = true;
            this.NomeMarca.Width = 300;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnCadastrarProduto);
            this.groupBox2.Controls.Add(this.dgvProdutos);
            this.groupBox2.Location = new System.Drawing.Point(13, 229);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(760, 200);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Produtos registrados";
            // 
            // dgvProdutos
            // 
            this.dgvProdutos.AllowUserToAddRows = false;
            this.dgvProdutos.AllowUserToDeleteRows = false;
            this.dgvProdutos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProdutos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdProduto,
            this.IdMarcaProduto,
            this.NomeProduto,
            this.MarcaProduto});
            this.dgvProdutos.Location = new System.Drawing.Point(7, 20);
            this.dgvProdutos.Name = "dgvProdutos";
            this.dgvProdutos.ReadOnly = true;
            this.dgvProdutos.Size = new System.Drawing.Size(600, 170);
            this.dgvProdutos.TabIndex = 0;
            // 
            // IdProduto
            // 
            this.IdProduto.DataPropertyName = "Id";
            this.IdProduto.HeaderText = "Id";
            this.IdProduto.Name = "IdProduto";
            this.IdProduto.ReadOnly = true;
            this.IdProduto.Visible = false;
            // 
            // IdMarcaProduto
            // 
            this.IdMarcaProduto.DataPropertyName = "MarcaId";
            this.IdMarcaProduto.HeaderText = "Id Marca do produto";
            this.IdMarcaProduto.Name = "IdMarcaProduto";
            this.IdMarcaProduto.ReadOnly = true;
            this.IdMarcaProduto.Visible = false;
            // 
            // NomeProduto
            // 
            this.NomeProduto.DataPropertyName = "Nome";
            this.NomeProduto.HeaderText = "Nome do produto";
            this.NomeProduto.Name = "NomeProduto";
            this.NomeProduto.ReadOnly = true;
            this.NomeProduto.Width = 200;
            // 
            // MarcaProduto
            // 
            this.MarcaProduto.DataPropertyName = "Marca";
            this.MarcaProduto.HeaderText = "Marca do produto";
            this.MarcaProduto.Name = "MarcaProduto";
            this.MarcaProduto.ReadOnly = true;
            this.MarcaProduto.Width = 200;
            // 
            // btnCadastrarMarca
            // 
            this.btnCadastrarMarca.Location = new System.Drawing.Point(613, 20);
            this.btnCadastrarMarca.Name = "btnCadastrarMarca";
            this.btnCadastrarMarca.Size = new System.Drawing.Size(141, 23);
            this.btnCadastrarMarca.TabIndex = 1;
            this.btnCadastrarMarca.Text = "Cadastrar marca...";
            this.btnCadastrarMarca.UseVisualStyleBackColor = true;
            this.btnCadastrarMarca.Click += new System.EventHandler(this.btnCadastrarMarca_Click);
            // 
            // btnCadastrarProduto
            // 
            this.btnCadastrarProduto.Location = new System.Drawing.Point(613, 20);
            this.btnCadastrarProduto.Name = "btnCadastrarProduto";
            this.btnCadastrarProduto.Size = new System.Drawing.Size(141, 23);
            this.btnCadastrarProduto.TabIndex = 2;
            this.btnCadastrarProduto.Text = "Cadastrar produto...";
            this.btnCadastrarProduto.UseVisualStyleBackColor = true;
            this.btnCadastrarProduto.Click += new System.EventHandler(this.btnCadastrarProduto_Click);
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 441);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FrmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Produtos e Marcas";
            this.Load += new System.EventHandler(this.FrmPrincipal_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMarcas)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProdutos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvMarcas;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdMarca;
        private System.Windows.Forms.DataGridViewTextBoxColumn NomeMarca;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgvProdutos;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdProduto;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdMarcaProduto;
        private System.Windows.Forms.DataGridViewTextBoxColumn NomeProduto;
        private System.Windows.Forms.DataGridViewTextBoxColumn MarcaProduto;
        private System.Windows.Forms.Button btnCadastrarProduto;
        private System.Windows.Forms.Button btnCadastrarMarca;
    }
}

