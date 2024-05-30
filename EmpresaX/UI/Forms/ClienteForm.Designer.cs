using EmpresaX.Business.Services;
using EmpresaX.Data.Entities;
using EmpresaX.UI.Controls;

namespace EmpresaX
{
    partial class ClienteForm : Form
    {
       

        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.DataGridView dgvClientes;

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
            dgvClientes = new DataGridView();
            labelNome = new Label();
            labelTelefone = new Label();
            txtTelefone = new TextBox();
            txtEmail = new TextBox();
            labelEndereco = new Label();
            txtEndereco = new TextBox();
            labelEmail = new Label();
            txtNome = new TextBox();
            btnClean = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvClientes).BeginInit();
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
            // dgvClientes
            // 
            dgvClientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvClientes.Location = new Point(12, 185);
            dgvClientes.Name = "dgvClientes";
            dgvClientes.Size = new Size(696, 200);
            dgvClientes.TabIndex = 7;
            dgvClientes.SelectionChanged += dgvClientes_SelectionChanged;
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
            // labelTelefone
            // 
            labelTelefone.AutoSize = true;
            labelTelefone.Location = new Point(15, 75);
            labelTelefone.Name = "labelTelefone";
            labelTelefone.Size = new Size(54, 15);
            labelTelefone.TabIndex = 8;
            labelTelefone.Text = "Telefone:";
            // 
            // txtTelefone
            // 
            txtTelefone.Location = new Point(80, 72);
            txtTelefone.Name = "txtTelefone";
            txtTelefone.Size = new Size(250, 23);
            txtTelefone.TabIndex = 2;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(80, 98);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(250, 23);
            txtEmail.TabIndex = 3;
            // 
            // labelEndereco
            // 
            labelEndereco.AutoSize = true;
            labelEndereco.Location = new Point(15, 49);
            labelEndereco.Name = "labelEndereco";
            labelEndereco.Size = new Size(59, 15);
            labelEndereco.TabIndex = 9;
            labelEndereco.Text = "Endereço:";
            // 
            // txtEndereco
            // 
            txtEndereco.Location = new Point(80, 46);
            txtEndereco.Name = "txtEndereco";
            txtEndereco.Size = new Size(250, 23);
            txtEndereco.TabIndex = 1;
            // 
            // labelEmail
            // 
            labelEmail.AutoSize = true;
            labelEmail.Location = new Point(15, 104);
            labelEmail.Name = "labelEmail";
            labelEmail.Size = new Size(39, 15);
            labelEmail.TabIndex = 9;
            labelEmail.Text = "Email:";
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
            // ClienteForm
            // 
            ClientSize = new Size(720, 397);
            Controls.Add(btnClean);
            Controls.Add(txtNome);
            Controls.Add(labelEmail);
            Controls.Add(txtEndereco);
            Controls.Add(dgvClientes);
            Controls.Add(labelEndereco);
            Controls.Add(btnDelete);
            Controls.Add(txtEmail);
            Controls.Add(btnUpdate);
            Controls.Add(txtTelefone);
            Controls.Add(btnAdd);
            Controls.Add(labelTelefone);
            Controls.Add(labelNome);
            Name = "ClienteForm";
            Text = "Gestão de Clientes";
            Load += ClienteForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvClientes).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelNome;
        private Label labelTelefone;
        private TextBox txtTelefone;
        private TextBox txtEmail;
        private Label labelEndereco;
        private TextBox txtEndereco;
        private Label labelEmail;
        private TextBox txtNome;
        private Button btnClean;
    }
}
