
namespace Rango
{
    partial class FrmCadProduto
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.DgvLista = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Data = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descricao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Valor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ativo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TxtPesquisa = new System.Windows.Forms.TextBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.BtnExcluir = new System.Windows.Forms.Button();
            this.BtnAlterar = new System.Windows.Forms.Button();
            this.BtnGravar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.CbAtivo = new System.Windows.Forms.CheckBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.TxtValor = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.TxtDescricao = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.MktData = new System.Windows.Forms.MaskedTextBox();
            this.panel1.SuspendLayout();
            this.groupBox7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvLista)).BeginInit();
            this.groupBox6.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.groupBox7);
            this.panel1.Controls.Add(this.groupBox6);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Location = new System.Drawing.Point(13, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(403, 404);
            this.panel1.TabIndex = 0;
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.DgvLista);
            this.groupBox7.Controls.Add(this.TxtPesquisa);
            this.groupBox7.Location = new System.Drawing.Point(6, 197);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(390, 202);
            this.groupBox7.TabIndex = 2;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Lista de Produtos";
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
            this.Data,
            this.Descricao,
            this.Valor,
            this.Ativo});
            this.DgvLista.Location = new System.Drawing.Point(7, 39);
            this.DgvLista.MultiSelect = false;
            this.DgvLista.Name = "DgvLista";
            this.DgvLista.ReadOnly = true;
            this.DgvLista.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvLista.Size = new System.Drawing.Size(377, 150);
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
            // Data
            // 
            this.Data.DataPropertyName = "Data";
            this.Data.HeaderText = "Data";
            this.Data.Name = "Data";
            this.Data.ReadOnly = true;
            this.Data.Width = 55;
            // 
            // Descricao
            // 
            this.Descricao.DataPropertyName = "Descricao";
            this.Descricao.HeaderText = "Descrição";
            this.Descricao.Name = "Descricao";
            this.Descricao.ReadOnly = true;
            this.Descricao.Width = 80;
            // 
            // Valor
            // 
            this.Valor.DataPropertyName = "Valor";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle1.Format = "C2";
            dataGridViewCellStyle1.NullValue = null;
            this.Valor.DefaultCellStyle = dataGridViewCellStyle1;
            this.Valor.HeaderText = "Valor";
            this.Valor.Name = "Valor";
            this.Valor.ReadOnly = true;
            this.Valor.Width = 56;
            // 
            // Ativo
            // 
            this.Ativo.DataPropertyName = "Ativo";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Ativo.DefaultCellStyle = dataGridViewCellStyle2;
            this.Ativo.HeaderText = "Ativo";
            this.Ativo.Name = "Ativo";
            this.Ativo.ReadOnly = true;
            this.Ativo.Width = 56;
            // 
            // TxtPesquisa
            // 
            this.TxtPesquisa.Location = new System.Drawing.Point(7, 13);
            this.TxtPesquisa.MaxLength = 250;
            this.TxtPesquisa.Name = "TxtPesquisa";
            this.TxtPesquisa.Size = new System.Drawing.Size(377, 20);
            this.TxtPesquisa.TabIndex = 0;
            this.TxtPesquisa.TextChanged += new System.EventHandler(this.TxtPesquisa_TextChanged);
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.BtnExcluir);
            this.groupBox6.Controls.Add(this.BtnAlterar);
            this.groupBox6.Controls.Add(this.BtnGravar);
            this.groupBox6.Location = new System.Drawing.Point(307, 5);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(89, 186);
            this.groupBox6.TabIndex = 1;
            this.groupBox6.TabStop = false;
            // 
            // BtnExcluir
            // 
            this.BtnExcluir.Enabled = false;
            this.BtnExcluir.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.BtnExcluir.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BtnExcluir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.BtnExcluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnExcluir.Location = new System.Drawing.Point(7, 111);
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
            this.BtnAlterar.Location = new System.Drawing.Point(7, 82);
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
            this.BtnGravar.Location = new System.Drawing.Point(7, 53);
            this.BtnGravar.Name = "BtnGravar";
            this.BtnGravar.Size = new System.Drawing.Size(75, 23);
            this.BtnGravar.TabIndex = 0;
            this.BtnGravar.Text = "&Gravar";
            this.BtnGravar.UseVisualStyleBackColor = true;
            this.BtnGravar.Click += new System.EventHandler(this.BtnGravar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox5);
            this.groupBox1.Controls.Add(this.groupBox4);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Location = new System.Drawing.Point(6, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(295, 186);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Produto";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.CbAtivo);
            this.groupBox5.Location = new System.Drawing.Point(106, 127);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(47, 48);
            this.groupBox5.TabIndex = 3;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Ativo";
            // 
            // CbAtivo
            // 
            this.CbAtivo.AutoSize = true;
            this.CbAtivo.Checked = true;
            this.CbAtivo.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CbAtivo.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.CbAtivo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.CbAtivo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CbAtivo.Location = new System.Drawing.Point(16, 17);
            this.CbAtivo.Name = "CbAtivo";
            this.CbAtivo.Size = new System.Drawing.Size(12, 11);
            this.CbAtivo.TabIndex = 0;
            this.CbAtivo.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.TxtValor);
            this.groupBox4.Location = new System.Drawing.Point(6, 127);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(94, 48);
            this.groupBox4.TabIndex = 2;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Valor";
            // 
            // TxtValor
            // 
            this.TxtValor.Location = new System.Drawing.Point(11, 14);
            this.TxtValor.Name = "TxtValor";
            this.TxtValor.Size = new System.Drawing.Size(72, 20);
            this.TxtValor.TabIndex = 0;
            this.TxtValor.Text = "0,00";
            this.TxtValor.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.TxtValor.TextChanged += new System.EventHandler(this.TxtValor_TextChanged);
            this.TxtValor.Enter += new System.EventHandler(this.TxtValor_Enter);
            this.TxtValor.Leave += new System.EventHandler(this.TxtValor_Leave);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.TxtDescricao);
            this.groupBox3.Location = new System.Drawing.Point(6, 73);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(279, 48);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Descrição";
            // 
            // TxtDescricao
            // 
            this.TxtDescricao.Location = new System.Drawing.Point(6, 14);
            this.TxtDescricao.MaxLength = 250;
            this.TxtDescricao.Name = "TxtDescricao";
            this.TxtDescricao.Size = new System.Drawing.Size(267, 20);
            this.TxtDescricao.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.MktData);
            this.groupBox2.Location = new System.Drawing.Point(6, 19);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(94, 48);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Data";
            // 
            // MktData
            // 
            this.MktData.Location = new System.Drawing.Point(7, 14);
            this.MktData.Mask = "00/00/0000";
            this.MktData.Name = "MktData";
            this.MktData.Size = new System.Drawing.Size(81, 20);
            this.MktData.TabIndex = 0;
            this.MktData.ValidatingType = typeof(System.DateTime);
            // 
            // FrmCadProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(429, 428);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmCadProduto";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Produtos";
            this.Load += new System.EventHandler(this.FrmCadProduto_Load);
            this.panel1.ResumeLayout(false);
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvLista)).EndInit();
            this.groupBox6.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
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
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.MaskedTextBox MktData;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox TxtValor;
        private System.Windows.Forms.TextBox TxtDescricao;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Button BtnExcluir;
        private System.Windows.Forms.Button BtnAlterar;
        private System.Windows.Forms.Button BtnGravar;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.CheckBox CbAtivo;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.DataGridView DgvLista;
        private System.Windows.Forms.TextBox TxtPesquisa;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Data;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descricao;
        private System.Windows.Forms.DataGridViewTextBoxColumn Valor;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ativo;
    }
}