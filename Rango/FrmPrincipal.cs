﻿using System;
using System.Windows.Forms;

namespace Rango
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void SubMenuCadastroCliente_Click(object sender, EventArgs e)
        {
            FrmCadCliente frmCadCliente = new FrmCadCliente();
            frmCadCliente.ShowDialog();
        }

        private void SubMenuCadastroProduto_Click(object sender, EventArgs e)
        {
            FrmCadProduto frmCadProduto = new FrmCadProduto();
            frmCadProduto.ShowDialog();
        }

        private void SubMenuVendaCadastro_Click(object sender, EventArgs e)
        {
            FrmCadVenda frmCadVenda = new FrmCadVenda();
            frmCadVenda.ShowDialog();
        }

        private void SubMenuRetiradaCadastro_Click(object sender, EventArgs e)
        {
            FrmCadRetirada frmCadRetirada = new FrmCadRetirada();
            frmCadRetirada.ShowDialog();
        }

        private void MenuSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblDataHoraAtual.Text = $"Data: {DateTime.Now.ToString("d")} Hora: {DateTime.Now.ToString("t")}";
        }

        private void SubMenuSaldoConsulta_Click(object sender, EventArgs e)
        {
            FrmConsSaldo frmConsSaldo = new FrmConsSaldo();
            frmConsSaldo.ShowDialog();
        }

        private void SubMenuVendaCredito_Click(object sender, EventArgs e)
        {
            FrmCadCredito frmCadCredito = new FrmCadCredito();
            frmCadCredito.ShowDialog();
        }

        private void SubMenuRetiradaDebito_Click(object sender, EventArgs e)
        {
            FrmCadDebito frmCadDebito = new FrmCadDebito();
            frmCadDebito.ShowDialog();
        }

        private void SubMenuRetConsultaProduto_Click(object sender, EventArgs e)
        {
            FrmConsRetirada frmConsRetirada = new FrmConsRetirada();
            frmConsRetirada.ShowDialog();
        }

        private void SubMenuVenConsultaProduto_Click(object sender, EventArgs e)
        {
            FrmConsVenda frmConsVenda = new FrmConsVenda();
            frmConsVenda.ShowDialog();
        }

        private void SubMenuVenConsultaCredito_Click(object sender, EventArgs e)
        {
            FrmConsCredito frmConsCredito = new FrmConsCredito();
            frmConsCredito.ShowDialog();
        }

        private void SubMenuRetConsultaDebito_Click(object sender, EventArgs e)
        {
            FrmConsDebito frmConsDebito = new FrmConsDebito();
            frmConsDebito.ShowDialog();
        }

        private void SubMenuExtratoListar_Click(object sender, EventArgs e)
        {
            FrmExtrato frmExtrato = new FrmExtrato();
            frmExtrato.ShowDialog();
        }

        private void SubMenuSaldoCD_Click(object sender, EventArgs e)
        {
            FrmConsulSaldoCD frmConsulSaldoCD = new FrmConsulSaldoCD();
            frmConsulSaldoCD.ShowDialog();
        }
    }
}
