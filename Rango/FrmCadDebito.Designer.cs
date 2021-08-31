
namespace Rango
{
    partial class FrmCadDebito
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.DgvLista = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cliente_Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Produto_Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descricao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Data = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Valor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TxtPesquisa = new System.Windows.Forms.TextBox();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.BtnExcluir = new System.Windows.Forms.Button();
            this.BtnAlterar = new System.Windows.Forms.Button();
            this.BtnGravar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.TxtValor = new System.Windows.Forms.TextBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.TxtQuantidade = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.MktData = new System.Windows.Forms.MaskedTextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.TxtIdProduto = new System.Windows.Forms.TextBox();
            this.CbxProduto = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.LblSaldo = new System.Windows.Forms.Label();
            this.TxtIdCliente = new System.Windows.Forms.TextBox();
            this.CbxCliente = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            this.groupBox8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvLista)).BeginInit();
            this.groupBox7.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.groupBox8);
            this.panel1.Controls.Add(this.groupBox7);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Location = new System.Drawing.Point(12, 13);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(383, 438);
            this.panel1.TabIndex = 1;
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.DgvLista);
            this.groupBox8.Controls.Add(this.TxtPesquisa);
            this.groupBox8.Location = new System.Drawing.Point(6, 210);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(371, 218);
            this.groupBox8.TabIndex = 1;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "Lista de Débito";
            // 
            // DgvLista
            // 
            this.DgvLista.AllowUserToAddRows = false;
            this.DgvLista.AllowUserToDeleteRows = false;
            this.DgvLista.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.DgvLista.BackgroundColor = System.Drawing.SystemColors.Control;
            this.DgvLista.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.DgvLista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvLista.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Cliente_Id,
            this.Nome,
            this.Produto_Id,
            this.Descricao,
            this.Data,
            this.Quantidade,
            this.Valor,
            this.Total});
            this.DgvLista.Location = new System.Drawing.Point(6, 39);
            this.DgvLista.MultiSelect = false;
            this.DgvLista.Name = "DgvLista";
            this.DgvLista.ReadOnly = true;
            this.DgvLista.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvLista.Size = new System.Drawing.Size(358, 167);
            this.DgvLista.TabIndex = 1;
            this.DgvLista.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvLista_CellDoubleClick);
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Width = 41;
            // 
            // Cliente_Id
            // 
            this.Cliente_Id.DataPropertyName = "Cliente_Id";
            this.Cliente_Id.HeaderText = "Cliente_Id";
            this.Cliente_Id.Name = "Cliente_Id";
            this.Cliente_Id.ReadOnly = true;
            this.Cliente_Id.Width = 79;
            // 
            // Nome
            // 
            this.Nome.DataPropertyName = "Nome";
            this.Nome.HeaderText = "Nome";
            this.Nome.Name = "Nome";
            this.Nome.ReadOnly = true;
            this.Nome.Width = 60;
            // 
            // Produto_Id
            // 
            this.Produto_Id.DataPropertyName = "Produto_Id";
            this.Produto_Id.HeaderText = "Produto_Id";
            this.Produto_Id.Name = "Produto_Id";
            this.Produto_Id.ReadOnly = true;
            this.Produto_Id.Width = 84;
            // 
            // Descricao
            // 
            this.Descricao.DataPropertyName = "Descricao";
            this.Descricao.HeaderText = "Descrição";
            this.Descricao.Name = "Descricao";
            this.Descricao.ReadOnly = true;
            this.Descricao.Width = 80;
            // 
            // Data
            // 
            this.Data.DataPropertyName = "Data";
            dataGridViewCellStyle1.Format = "d";
            dataGridViewCellStyle1.NullValue = null;
            this.Data.DefaultCellStyle = dataGridViewCellStyle1;
            this.Data.HeaderText = "Data";
            this.Data.Name = "Data";
            this.Data.ReadOnly = true;
            this.Data.Width = 55;
            // 
            // Quantidade
            // 
            this.Quantidade.DataPropertyName = "Quantidade";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.Quantidade.DefaultCellStyle = dataGridViewCellStyle2;
            this.Quantidade.HeaderText = "Quantidade";
            this.Quantidade.Name = "Quantidade";
            this.Quantidade.ReadOnly = true;
            this.Quantidade.Width = 87;
            // 
            // Valor
            // 
            this.Valor.DataPropertyName = "Valor";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle3.Format = "C2";
            this.Valor.DefaultCellStyle = dataGridViewCellStyle3;
            this.Valor.HeaderText = "Valor";
            this.Valor.Name = "Valor";
            this.Valor.ReadOnly = true;
            this.Valor.Width = 56;
            // 
            // Total
            // 
            this.Total.DataPropertyName = "Total";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle4.Format = "C2";
            this.Total.DefaultCellStyle = dataGridViewCellStyle4;
            this.Total.HeaderText = "Total";
            this.Total.Name = "Total";
            this.Total.ReadOnly = true;
            this.Total.Width = 56;
            // 
            // TxtPesquisa
            // 
            this.TxtPesquisa.Location = new System.Drawing.Point(6, 13);
            this.TxtPesquisa.Name = "TxtPesquisa";
            this.TxtPesquisa.Size = new System.Drawing.Size(359, 20);
            this.TxtPesquisa.TabIndex = 0;
            this.TxtPesquisa.TextChanged += new System.EventHandler(this.TxtPesquisa_TextChanged);
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.BtnExcluir);
            this.groupBox7.Controls.Add(this.BtnAlterar);
            this.groupBox7.Controls.Add(this.BtnGravar);
            this.groupBox7.Location = new System.Drawing.Point(288, 5);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(89, 199);
            this.groupBox7.TabIndex = 0;
            this.groupBox7.TabStop = false;
            // 
            // BtnExcluir
            // 
            this.BtnExcluir.Enabled = false;
            this.BtnExcluir.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.BtnExcluir.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BtnExcluir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.BtnExcluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnExcluir.Location = new System.Drawing.Point(7, 117);
            this.BtnExcluir.Name = "BtnExcluir";
            this.BtnExcluir.Size = new System.Drawing.Size(75, 23);
            this.BtnExcluir.TabIndex = 2;
            this.BtnExcluir.Text = "&Excluir";
            this.BtnExcluir.UseVisualStyleBackColor = true;
            this.BtnExcluir.Click += new System.EventHandler(this.BtnExcluir_Click);
            // 
            // BtnAlterar
            // 
            this.BtnAlterar.Enabled = false;
            this.BtnAlterar.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.BtnAlterar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BtnAlterar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Lime;
            this.BtnAlterar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAlterar.Location = new System.Drawing.Point(7, 88);
            this.BtnAlterar.Name = "BtnAlterar";
            this.BtnAlterar.Size = new System.Drawing.Size(75, 23);
            this.BtnAlterar.TabIndex = 1;
            this.BtnAlterar.Text = "&Alterar";
            this.BtnAlterar.UseVisualStyleBackColor = true;
            this.BtnAlterar.Click += new System.EventHandler(this.BtnAlterar_Click);
            // 
            // BtnGravar
            // 
            this.BtnGravar.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.BtnGravar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BtnGravar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Lime;
            this.BtnGravar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnGravar.Location = new System.Drawing.Point(7, 59);
            this.BtnGravar.Name = "BtnGravar";
            this.BtnGravar.Size = new System.Drawing.Size(75, 23);
            this.BtnGravar.TabIndex = 0;
            this.BtnGravar.Text = "&Gravar";
            this.BtnGravar.UseVisualStyleBackColor = true;
            this.BtnGravar.Click += new System.EventHandler(this.BtnGravar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox6);
            this.groupBox1.Controls.Add(this.groupBox5);
            this.groupBox1.Controls.Add(this.groupBox4);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Location = new System.Drawing.Point(6, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(276, 199);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Débito";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.TxtValor);
            this.groupBox6.Location = new System.Drawing.Point(186, 140);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(79, 48);
            this.groupBox6.TabIndex = 4;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Valor";
            // 
            // TxtValor
            // 
            this.TxtValor.Location = new System.Drawing.Point(6, 14);
            this.TxtValor.Name = "TxtValor";
            this.TxtValor.ReadOnly = true;
            this.TxtValor.Size = new System.Drawing.Size(67, 20);
            this.TxtValor.TabIndex = 0;
            this.TxtValor.Text = "0,00";
            this.TxtValor.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.TxtQuantidade);
            this.groupBox5.Location = new System.Drawing.Point(101, 140);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(79, 48);
            this.groupBox5.TabIndex = 3;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Quantidade";
            // 
            // TxtQuantidade
            // 
            this.TxtQuantidade.Location = new System.Drawing.Point(6, 14);
            this.TxtQuantidade.Name = "TxtQuantidade";
            this.TxtQuantidade.Size = new System.Drawing.Size(67, 20);
            this.TxtQuantidade.TabIndex = 0;
            this.TxtQuantidade.Text = "0";
            this.TxtQuantidade.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.TxtQuantidade.TextChanged += new System.EventHandler(this.TxtQuantidade_TextChanged);
            this.TxtQuantidade.Enter += new System.EventHandler(this.TxtQuantidade_Enter);
            this.TxtQuantidade.Leave += new System.EventHandler(this.TxtQuantidade_Leave);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.MktData);
            this.groupBox4.Location = new System.Drawing.Point(6, 140);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(89, 48);
            this.groupBox4.TabIndex = 2;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Data";
            // 
            // MktData
            // 
            this.MktData.Location = new System.Drawing.Point(7, 14);
            this.MktData.Mask = "00/00/0000";
            this.MktData.Name = "MktData";
            this.MktData.Size = new System.Drawing.Size(75, 20);
            this.MktData.TabIndex = 0;
            this.MktData.ValidatingType = typeof(System.DateTime);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.TxtIdProduto);
            this.groupBox3.Controls.Add(this.CbxProduto);
            this.groupBox3.Location = new System.Drawing.Point(6, 86);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(259, 48);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Produto";
            // 
            // TxtIdProduto
            // 
            this.TxtIdProduto.Location = new System.Drawing.Point(7, 14);
            this.TxtIdProduto.Name = "TxtIdProduto";
            this.TxtIdProduto.Size = new System.Drawing.Size(52, 20);
            this.TxtIdProduto.TabIndex = 0;
            this.TxtIdProduto.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TxtIdProduto_KeyDown);
            this.TxtIdProduto.Leave += new System.EventHandler(this.TxtIdProduto_Leave);
            // 
            // CbxProduto
            // 
            this.CbxProduto.DisplayMember = "Descricao";
            this.CbxProduto.FormattingEnabled = true;
            this.CbxProduto.Location = new System.Drawing.Point(65, 14);
            this.CbxProduto.Name = "CbxProduto";
            this.CbxProduto.Size = new System.Drawing.Size(188, 21);
            this.CbxProduto.TabIndex = 1;
            this.CbxProduto.ValueMember = "Id";
            this.CbxProduto.SelectedIndexChanged += new System.EventHandler(this.CbxProduto_SelectedIndexChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.LblSaldo);
            this.groupBox2.Controls.Add(this.TxtIdCliente);
            this.groupBox2.Controls.Add(this.CbxCliente);
            this.groupBox2.Location = new System.Drawing.Point(6, 19);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(259, 61);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Cliente";
            // 
            // LblSaldo
            // 
            this.LblSaldo.AutoSize = true;
            this.LblSaldo.Location = new System.Drawing.Point(5, 40);
            this.LblSaldo.Name = "LblSaldo";
            this.LblSaldo.Size = new System.Drawing.Size(88, 13);
            this.LblSaldo.TabIndex = 2;
            this.LblSaldo.Text = "Saldo Atual: 0,00";
            // 
            // TxtIdCliente
            // 
            this.TxtIdCliente.Location = new System.Drawing.Point(7, 14);
            this.TxtIdCliente.Name = "TxtIdCliente";
            this.TxtIdCliente.Size = new System.Drawing.Size(52, 20);
            this.TxtIdCliente.TabIndex = 0;
            this.TxtIdCliente.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TxtIdCliente_KeyDown);
            this.TxtIdCliente.Leave += new System.EventHandler(this.TxtIdCliente_Leave);
            // 
            // CbxCliente
            // 
            this.CbxCliente.DisplayMember = "Nome";
            this.CbxCliente.FormattingEnabled = true;
            this.CbxCliente.Location = new System.Drawing.Point(65, 14);
            this.CbxCliente.Name = "CbxCliente";
            this.CbxCliente.Size = new System.Drawing.Size(188, 21);
            this.CbxCliente.TabIndex = 1;
            this.CbxCliente.ValueMember = "Id";
            this.CbxCliente.SelectedIndexChanged += new System.EventHandler(this.CbxCliente_SelectedIndexChanged);
            // 
            // FrmCadDebito
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(406, 460);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmCadDebito";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro Débito";
            this.Load += new System.EventHandler(this.FrmCadDebito_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.FrmCadDebito_KeyPress);
            this.panel1.ResumeLayout(false);
            this.groupBox8.ResumeLayout(false);
            this.groupBox8.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvLista)).EndInit();
            this.groupBox7.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.DataGridView DgvLista;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cliente_Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn Produto_Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descricao;
        private System.Windows.Forms.DataGridViewTextBoxColumn Data;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantidade;
        private System.Windows.Forms.DataGridViewTextBoxColumn Valor;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total;
        private System.Windows.Forms.TextBox TxtPesquisa;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.Button BtnExcluir;
        private System.Windows.Forms.Button BtnAlterar;
        private System.Windows.Forms.Button BtnGravar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.TextBox TxtValor;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.TextBox TxtQuantidade;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.MaskedTextBox MktData;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label LblSaldo;
        private System.Windows.Forms.TextBox TxtIdProduto;
        private System.Windows.Forms.ComboBox CbxProduto;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox TxtIdCliente;
        private System.Windows.Forms.ComboBox CbxCliente;
    }
}