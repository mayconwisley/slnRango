
namespace Rango
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPrincipal));
            this.MenuPrincipal = new System.Windows.Forms.MenuStrip();
            this.MenuCadastro = new System.Windows.Forms.ToolStripMenuItem();
            this.SubMenuCadastroCliente = new System.Windows.Forms.ToolStripMenuItem();
            this.SubMenuCadastroProduto = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuVenda = new System.Windows.Forms.ToolStripMenuItem();
            this.SubMenuVendaCadastro = new System.Windows.Forms.ToolStripMenuItem();
            this.SubMenuVendaConsulta = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuRetirada = new System.Windows.Forms.ToolStripMenuItem();
            this.SubMenuRetiradaCadastro = new System.Windows.Forms.ToolStripMenuItem();
            this.SubMenuRetiradaConsulta = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuSaldo = new System.Windows.Forms.ToolStripMenuItem();
            this.SubMenuSaldoConsulta = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuSair = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblDataHoraAtual = new System.Windows.Forms.ToolStripStatusLabel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.MenuPrincipal.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // MenuPrincipal
            // 
            this.MenuPrincipal.BackColor = System.Drawing.Color.Transparent;
            this.MenuPrincipal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuCadastro,
            this.MenuVenda,
            this.MenuRetirada,
            this.MenuSaldo,
            this.MenuSair});
            this.MenuPrincipal.Location = new System.Drawing.Point(0, 0);
            this.MenuPrincipal.Name = "MenuPrincipal";
            this.MenuPrincipal.Size = new System.Drawing.Size(1066, 24);
            this.MenuPrincipal.TabIndex = 0;
            this.MenuPrincipal.Text = "menuStrip1";
            // 
            // MenuCadastro
            // 
            this.MenuCadastro.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SubMenuCadastroCliente,
            this.SubMenuCadastroProduto});
            this.MenuCadastro.Name = "MenuCadastro";
            this.MenuCadastro.Size = new System.Drawing.Size(66, 20);
            this.MenuCadastro.Text = "Cadastro";
            // 
            // SubMenuCadastroCliente
            // 
            this.SubMenuCadastroCliente.Name = "SubMenuCadastroCliente";
            this.SubMenuCadastroCliente.Size = new System.Drawing.Size(117, 22);
            this.SubMenuCadastroCliente.Text = "Cliente";
            this.SubMenuCadastroCliente.Click += new System.EventHandler(this.SubMenuCadastroCliente_Click);
            // 
            // SubMenuCadastroProduto
            // 
            this.SubMenuCadastroProduto.Name = "SubMenuCadastroProduto";
            this.SubMenuCadastroProduto.Size = new System.Drawing.Size(117, 22);
            this.SubMenuCadastroProduto.Text = "Produto";
            this.SubMenuCadastroProduto.Click += new System.EventHandler(this.SubMenuCadastroProduto_Click);
            // 
            // MenuVenda
            // 
            this.MenuVenda.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SubMenuVendaCadastro,
            this.SubMenuVendaConsulta});
            this.MenuVenda.Name = "MenuVenda";
            this.MenuVenda.Size = new System.Drawing.Size(51, 20);
            this.MenuVenda.Text = "Venda";
            // 
            // SubMenuVendaCadastro
            // 
            this.SubMenuVendaCadastro.Name = "SubMenuVendaCadastro";
            this.SubMenuVendaCadastro.Size = new System.Drawing.Size(121, 22);
            this.SubMenuVendaCadastro.Text = "Cadastro";
            this.SubMenuVendaCadastro.Click += new System.EventHandler(this.SubMenuVendaCadastro_Click);
            // 
            // SubMenuVendaConsulta
            // 
            this.SubMenuVendaConsulta.Name = "SubMenuVendaConsulta";
            this.SubMenuVendaConsulta.Size = new System.Drawing.Size(121, 22);
            this.SubMenuVendaConsulta.Text = "Consulta";
            this.SubMenuVendaConsulta.Click += new System.EventHandler(this.SubMenuVendaConsulta_Click);
            // 
            // MenuRetirada
            // 
            this.MenuRetirada.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SubMenuRetiradaCadastro,
            this.SubMenuRetiradaConsulta});
            this.MenuRetirada.Name = "MenuRetirada";
            this.MenuRetirada.Size = new System.Drawing.Size(62, 20);
            this.MenuRetirada.Text = "Retirada";
            // 
            // SubMenuRetiradaCadastro
            // 
            this.SubMenuRetiradaCadastro.Name = "SubMenuRetiradaCadastro";
            this.SubMenuRetiradaCadastro.Size = new System.Drawing.Size(121, 22);
            this.SubMenuRetiradaCadastro.Text = "Cadastro";
            this.SubMenuRetiradaCadastro.Click += new System.EventHandler(this.SubMenuRetiradaCadastro_Click);
            // 
            // SubMenuRetiradaConsulta
            // 
            this.SubMenuRetiradaConsulta.Name = "SubMenuRetiradaConsulta";
            this.SubMenuRetiradaConsulta.Size = new System.Drawing.Size(121, 22);
            this.SubMenuRetiradaConsulta.Text = "Consulta";
            this.SubMenuRetiradaConsulta.Click += new System.EventHandler(this.SubMenuRetiradaConsulta_Click);
            // 
            // MenuSaldo
            // 
            this.MenuSaldo.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SubMenuSaldoConsulta});
            this.MenuSaldo.Name = "MenuSaldo";
            this.MenuSaldo.Size = new System.Drawing.Size(48, 20);
            this.MenuSaldo.Text = "Saldo";
            // 
            // SubMenuSaldoConsulta
            // 
            this.SubMenuSaldoConsulta.Name = "SubMenuSaldoConsulta";
            this.SubMenuSaldoConsulta.Size = new System.Drawing.Size(121, 22);
            this.SubMenuSaldoConsulta.Text = "Consulta";
            this.SubMenuSaldoConsulta.Click += new System.EventHandler(this.SubMenuSaldoConsulta_Click);
            // 
            // MenuSair
            // 
            this.MenuSair.Name = "MenuSair";
            this.MenuSair.Size = new System.Drawing.Size(38, 20);
            this.MenuSair.Text = "Sair";
            this.MenuSair.Click += new System.EventHandler(this.MenuSair_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.lblDataHoraAtual});
            this.statusStrip1.Location = new System.Drawing.Point(0, 609);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1066, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(185, 17);
            this.toolStripStatusLabel1.Text = "Desenvolvido por: Maycon Wisley";
            // 
            // lblDataHoraAtual
            // 
            this.lblDataHoraAtual.Name = "lblDataHoraAtual";
            this.lblDataHoraAtual.Size = new System.Drawing.Size(157, 17);
            this.lblDataHoraAtual.Text = "Data: 00/00/0000 Hora: 00:00";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1066, 631);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.MenuPrincipal);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.MenuPrincipal;
            this.Name = "FrmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Rango";
            this.MenuPrincipal.ResumeLayout(false);
            this.MenuPrincipal.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip MenuPrincipal;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripMenuItem MenuCadastro;
        private System.Windows.Forms.ToolStripMenuItem SubMenuCadastroCliente;
        private System.Windows.Forms.ToolStripMenuItem SubMenuCadastroProduto;
        private System.Windows.Forms.ToolStripMenuItem MenuVenda;
        private System.Windows.Forms.ToolStripMenuItem SubMenuVendaCadastro;
        private System.Windows.Forms.ToolStripMenuItem SubMenuVendaConsulta;
        private System.Windows.Forms.ToolStripMenuItem MenuRetirada;
        private System.Windows.Forms.ToolStripMenuItem SubMenuRetiradaCadastro;
        private System.Windows.Forms.ToolStripMenuItem SubMenuRetiradaConsulta;
        private System.Windows.Forms.ToolStripMenuItem MenuSaldo;
        private System.Windows.Forms.ToolStripMenuItem SubMenuSaldoConsulta;
        private System.Windows.Forms.ToolStripMenuItem MenuSair;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel lblDataHoraAtual;
        private System.Windows.Forms.Timer timer1;
    }
}

