
namespace Rango
{
    partial class FrmExtrato
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.RbCD = new System.Windows.Forms.RadioButton();
            this.RbProduto = new System.Windows.Forms.RadioButton();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.BtnGerar = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.MktDataFim = new System.Windows.Forms.MaskedTextBox();
            this.MktDataInicio = new System.Windows.Forms.MaskedTextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.TxtIdCliente = new System.Windows.Forms.TextBox();
            this.CbxCliente = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.groupBox5);
            this.panel1.Controls.Add(this.groupBox4);
            this.panel1.Controls.Add(this.groupBox3);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Location = new System.Drawing.Point(10, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(423, 187);
            this.panel1.TabIndex = 0;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.RbCD);
            this.groupBox5.Controls.Add(this.RbProduto);
            this.groupBox5.Location = new System.Drawing.Point(8, 86);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(311, 38);
            this.groupBox5.TabIndex = 1;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Opção";
            // 
            // RbCD
            // 
            this.RbCD.AutoSize = true;
            this.RbCD.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.RbCD.FlatAppearance.CheckedBackColor = System.Drawing.Color.Lime;
            this.RbCD.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.RbCD.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.RbCD.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RbCD.Location = new System.Drawing.Point(175, 11);
            this.RbCD.Name = "RbCD";
            this.RbCD.Size = new System.Drawing.Size(93, 17);
            this.RbCD.TabIndex = 1;
            this.RbCD.Text = "Crédito/Débito";
            this.RbCD.UseVisualStyleBackColor = true;
            // 
            // RbProduto
            // 
            this.RbProduto.AutoSize = true;
            this.RbProduto.Checked = true;
            this.RbProduto.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.RbProduto.FlatAppearance.CheckedBackColor = System.Drawing.Color.Lime;
            this.RbProduto.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.RbProduto.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.RbProduto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RbProduto.Location = new System.Drawing.Point(41, 11);
            this.RbProduto.Name = "RbProduto";
            this.RbProduto.Size = new System.Drawing.Size(66, 17);
            this.RbProduto.TabIndex = 0;
            this.RbProduto.TabStop = true;
            this.RbProduto.Text = "Produtos";
            this.RbProduto.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.BtnGerar);
            this.groupBox4.Location = new System.Drawing.Point(325, 6);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(89, 172);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            // 
            // BtnGerar
            // 
            this.BtnGerar.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.BtnGerar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BtnGerar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Lime;
            this.BtnGerar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnGerar.Location = new System.Drawing.Point(8, 70);
            this.BtnGerar.Name = "BtnGerar";
            this.BtnGerar.Size = new System.Drawing.Size(72, 33);
            this.BtnGerar.TabIndex = 0;
            this.BtnGerar.Text = "Gerar";
            this.BtnGerar.UseVisualStyleBackColor = true;
            this.BtnGerar.Click += new System.EventHandler(this.BtnGerar_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.MktDataFim);
            this.groupBox3.Controls.Add(this.MktDataInicio);
            this.groupBox3.Location = new System.Drawing.Point(8, 130);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(311, 48);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Período";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(149, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(13, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "a";
            // 
            // MktDataFim
            // 
            this.MktDataFim.Location = new System.Drawing.Point(168, 15);
            this.MktDataFim.Mask = "00/00/0000";
            this.MktDataFim.Name = "MktDataFim";
            this.MktDataFim.Size = new System.Drawing.Size(74, 20);
            this.MktDataFim.TabIndex = 1;
            this.MktDataFim.ValidatingType = typeof(System.DateTime);
            // 
            // MktDataInicio
            // 
            this.MktDataInicio.Location = new System.Drawing.Point(69, 15);
            this.MktDataInicio.Mask = "00/00/0000";
            this.MktDataInicio.Name = "MktDataInicio";
            this.MktDataInicio.Size = new System.Drawing.Size(74, 20);
            this.MktDataInicio.TabIndex = 0;
            this.MktDataInicio.ValidatingType = typeof(System.DateTime);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Location = new System.Drawing.Point(8, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(311, 74);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Cliente";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.TxtIdCliente);
            this.groupBox2.Controls.Add(this.CbxCliente);
            this.groupBox2.Location = new System.Drawing.Point(7, 16);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(295, 48);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Cliente";
            // 
            // TxtIdCliente
            // 
            this.TxtIdCliente.Location = new System.Drawing.Point(7, 15);
            this.TxtIdCliente.Name = "TxtIdCliente";
            this.TxtIdCliente.Size = new System.Drawing.Size(46, 20);
            this.TxtIdCliente.TabIndex = 0;
            this.TxtIdCliente.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TxtIdCliente_KeyDown);
            this.TxtIdCliente.Leave += new System.EventHandler(this.TxtIdCliente_Leave);
            // 
            // CbxCliente
            // 
            this.CbxCliente.DisplayMember = "Nome";
            this.CbxCliente.FormattingEnabled = true;
            this.CbxCliente.Location = new System.Drawing.Point(59, 14);
            this.CbxCliente.Name = "CbxCliente";
            this.CbxCliente.Size = new System.Drawing.Size(228, 21);
            this.CbxCliente.TabIndex = 1;
            this.CbxCliente.ValueMember = "Id";
            this.CbxCliente.SelectedIndexChanged += new System.EventHandler(this.CbxCliente_SelectedIndexChanged);
            // 
            // FrmExtrato
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(442, 211);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmExtrato";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Extrato";
            this.Load += new System.EventHandler(this.FrmExtrato_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.FrmExtrato_KeyPress);
            this.panel1.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox TxtIdCliente;
        private System.Windows.Forms.ComboBox CbxCliente;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button BtnGerar;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox MktDataFim;
        private System.Windows.Forms.MaskedTextBox MktDataInicio;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.RadioButton RbCD;
        private System.Windows.Forms.RadioButton RbProduto;
    }
}