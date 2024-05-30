namespace EmpresaX.UI.Forms
{
    partial class ProdutoForm : Form
    {
                /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.DataGridView dgvProdutos;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnAdd = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            dgvProdutos = new DataGridView();
            labelNome = new Label();
            labelPreco = new Label();
            txtPreco = new TextBox();
            txtEstoque = new TextBox();
            labelDescricao = new Label();
            txtDescricao = new TextBox();
            labelEstoque = new Label();
            txtNome = new TextBox();
            btnClean = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvProdutos).BeginInit();

            SuspendLayout();
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(12, 136);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(75, 23);
            btnAdd.TabIndex = 4;
            btnAdd.Text = "Adicionar";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(93, 136);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(75, 23);
            btnUpdate.TabIndex = 5;
            btnUpdate.Text = "Atualizar";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(174, 136);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(75, 23);
            btnDelete.TabIndex = 6;
            btnDelete.Text = "Remover";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // dgvProdutos
            // 
            dgvProdutos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProdutos.Location = new Point(12, 185);
            dgvProdutos.Name = "dgvProdutos";
            dgvProdutos.Size = new Size(696, 200);
            dgvProdutos.TabIndex = 7;
            dgvProdutos.SelectionChanged += dgvProdutos_SelectionChanged; 
            // 
            // labelNome
            // 
            labelNome.AutoSize = true;
            labelNome.Location = new Point(15, 23);
            labelNome.Name = "labelNome";
            labelNome.Size = new Size(43, 15);
            labelNome.TabIndex = 8;
            labelNome.Text = "Nome:";
            // 
            // labelPreco
            // 
            labelPreco.AutoSize = true;
            labelPreco.Location = new Point(15, 75);
            labelPreco.Name = "labelPreco";
            labelPreco.Size = new Size(64, 15);
            labelPreco.TabIndex = 8;
            labelPreco.Text = "Preco (R$):";
            // 
            // txtPreco
            // 
            txtPreco.Location = new Point(80, 72);
            txtPreco.Name = "txtPreco";
            txtPreco.Size = new Size(250, 23);
            txtPreco.TabIndex = 2;
            // 
            // txtEstoque
            // 
            txtEstoque.Location = new Point(80, 98);
            txtEstoque.Name = "txtEstoque";
            txtEstoque.Size = new Size(250, 23);
            txtEstoque.TabIndex = 3;
            // 
            // labelDescricao
            // 
            labelDescricao.AutoSize = true;
            labelDescricao.Location = new Point(15, 49);
            labelDescricao.Name = "labelDescricao";
            labelDescricao.Size = new Size(61, 15);
            labelDescricao.TabIndex = 9;
            labelDescricao.Text = "Descrição:";
            // 
            // txtDescricao
            // 
            txtDescricao.Location = new Point(80, 46);
            txtDescricao.Name = "txtDescricao";
            txtDescricao.Size = new Size(250, 23);
            txtDescricao.TabIndex = 1;
            // 
            // labelEstoque
            // 
            labelEstoque.AutoSize = true;
            labelEstoque.Location = new Point(15, 104);
            labelEstoque.Name = "labelEstoque";
            labelEstoque.Size = new Size(52, 15);
            labelEstoque.TabIndex = 9;
            labelEstoque.Text = "Estoque:";
            // 
            // txtNome
            // 
            txtNome.Location = new Point(80, 20);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(250, 23);
            txtNome.TabIndex = 0;
            // 
            // btnClean
            // 
            btnClean.Location = new Point(255, 136);
            btnClean.Name = "btnClean";
            btnClean.Size = new Size(75, 23);
            btnClean.TabIndex = 10;
            btnClean.Text = "Limpar";
            btnClean.UseVisualStyleBackColor = true;
            btnClean.Click += btnClean_Click;
            // 
            // ProdutoForm
            // 
            ClientSize = new Size(720, 397);
            Controls.Add(btnClean);
            Controls.Add(txtNome);
            Controls.Add(labelEstoque);
            Controls.Add(txtDescricao);
            Controls.Add(dgvProdutos);
            Controls.Add(labelDescricao);
            Controls.Add(btnDelete);
            Controls.Add(txtEstoque);
            Controls.Add(btnUpdate);
            Controls.Add(txtPreco);
            Controls.Add(btnAdd);
            Controls.Add(labelPreco);
            Controls.Add(labelNome);
            Name = "ProdutoForm";
            Text = "Gestão de Produtos";
            Load += ProdutoForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvProdutos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelNome;
        private Label labelPreco;
        private TextBox txtPreco;
        private TextBox txtEstoque;
        private Label labelDescricao;
        private TextBox txtDescricao;
        private Label labelEstoque;
        private TextBox txtNome;
        private Button btnClean;
    }
}