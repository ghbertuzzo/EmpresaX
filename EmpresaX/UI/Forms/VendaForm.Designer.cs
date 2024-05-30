namespace EmpresaX.UI.Forms
{
    partial class VendaForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.ComboBox cmbClientes;
        private System.Windows.Forms.ComboBox cmbProdutos;
        private System.Windows.Forms.TextBox txtQuantidade;
        private System.Windows.Forms.Button btnAddProduto;
        private System.Windows.Forms.Button btnFinalizarVenda;
        private System.Windows.Forms.DataGridView dgvItensVenda;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblTotalValue;

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

        private void InitializeComponent()
        {
            cmbClientes = new ComboBox();
            cmbProdutos = new ComboBox();
            txtQuantidade = new TextBox();
            btnAddProduto = new Button();
            btnFinalizarVenda = new Button();
            dgvItensVenda = new DataGridView();
            lblTotal = new Label();
            lblTotalValue = new Label();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvItensVenda).BeginInit();
            SuspendLayout();
            // 
            // cmbClientes
            // 
            cmbClientes.FormattingEnabled = true;
            cmbClientes.Location = new Point(71, 12);
            cmbClientes.Name = "cmbClientes";
            cmbClientes.Size = new Size(200, 23);
            cmbClientes.TabIndex = 0;
            // 
            // cmbProdutos
            // 
            cmbProdutos.FormattingEnabled = true;
            cmbProdutos.Location = new Point(508, 15);
            cmbProdutos.Name = "cmbProdutos";
            cmbProdutos.Size = new Size(200, 23);
            cmbProdutos.TabIndex = 1;
            // 
            // txtQuantidade
            // 
            txtQuantidade.Location = new Point(508, 55);
            txtQuantidade.Name = "txtQuantidade";
            txtQuantidade.Size = new Size(200, 23);
            txtQuantidade.TabIndex = 2;
            // 
            // btnAddProduto
            // 
            btnAddProduto.Location = new Point(416, 94);
            btnAddProduto.Name = "btnAddProduto";
            btnAddProduto.Size = new Size(292, 23);
            btnAddProduto.TabIndex = 3;
            btnAddProduto.Text = "Adicionar Produto";
            btnAddProduto.UseVisualStyleBackColor = true;
            btnAddProduto.Click += btnAddProduto_Click;
            // 
            // btnFinalizarVenda
            // 
            btnFinalizarVenda.Location = new Point(416, 294);
            btnFinalizarVenda.Name = "btnFinalizarVenda";
            btnFinalizarVenda.Size = new Size(292, 23);
            btnFinalizarVenda.TabIndex = 7;
            btnFinalizarVenda.Text = "Finalizar Venda";
            btnFinalizarVenda.UseVisualStyleBackColor = true;
            btnFinalizarVenda.Click += btnFinalizarVenda_Click;
            // 
            // dgvItensVenda
            // 
            dgvItensVenda.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvItensVenda.Location = new Point(14, 132);
            dgvItensVenda.Name = "dgvItensVenda";
            dgvItensVenda.Size = new Size(694, 150);
            dgvItensVenda.TabIndex = 4;
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Location = new Point(14, 302);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(51, 15);
            lblTotal.TabIndex = 5;
            lblTotal.Text = "Total: R$";
            // 
            // lblTotalValue
            // 
            lblTotalValue.AutoSize = true;
            lblTotalValue.Location = new Point(71, 302);
            lblTotalValue.Name = "lblTotalValue";
            lblTotalValue.Size = new Size(28, 15);
            lblTotalValue.TabIndex = 6;
            lblTotalValue.Text = "0.00";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 15);
            label1.Name = "label1";
            label1.Size = new Size(47, 15);
            label1.TabIndex = 8;
            label1.Text = "Cliente:";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(416, 18);
            label2.Name = "label2";
            label2.Size = new Size(53, 15);
            label2.TabIndex = 9;
            label2.Text = "Produto:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(416, 58);
            label3.Name = "label3";
            label3.Size = new Size(72, 15);
            label3.TabIndex = 10;
            label3.Text = "Quantidade:";
            // 
            // VendaForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(720, 331);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnFinalizarVenda);
            Controls.Add(lblTotalValue);
            Controls.Add(lblTotal);
            Controls.Add(dgvItensVenda);
            Controls.Add(btnAddProduto);
            Controls.Add(txtQuantidade);
            Controls.Add(cmbProdutos);
            Controls.Add(cmbClientes);
            Name = "VendaForm";
            Text = "Registrar Venda";
            Load += VendaForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvItensVenda).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private Label label1;
        private Label label2;
        private Label label3;
    }
}