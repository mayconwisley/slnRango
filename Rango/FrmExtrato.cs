﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rango
{
    public partial class FrmExtrato : Form
    {
        public FrmExtrato()
        {
            InitializeComponent();
        }
        int idCliente;
        DateTime dataInicio, dateFim;
        private void ListarCliente()
        {
            Controle.Cliente.Listar.Lista lista = new Controle.Cliente.Listar.Lista();
            try
            {
                CbxCliente.DataSource = lista.IdNome();
                TxtIdCliente.Text = CbxCliente.SelectedValue.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ListarPeriodo()
        {
            DateTime dateInicio;
            dateInicio = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);


            MktDataInicio.Text = dateInicio.ToString("d");
            MktDataFim.Text = DateTime.Now.Date.ToString("d");
        }

        private void FrmExtrato_Load(object sender, EventArgs e)
        {
            ListarCliente();
            ListarPeriodo();
        }

        private void TxtIdCliente_Leave(object sender, EventArgs e)
        {
            idCliente = int.Parse(TxtIdCliente.Text.Trim());
            CbxCliente.SelectedValue = idCliente;
        }

        private void CbxCliente_SelectedIndexChanged(object sender, EventArgs e)
        {
            idCliente = int.Parse(CbxCliente.SelectedValue.ToString());
            TxtIdCliente.Text = idCliente.ToString();
        }

        private void TxtIdCliente_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {

                idCliente = int.Parse(TxtIdCliente.Text.Trim());
                CbxCliente.SelectedValue = idCliente;
            }
        }

        private void FrmExtrato_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
            }
        }

        private void BtnGerar_Click(object sender, EventArgs e)
        {
            dataInicio = DateTime.Parse(MktDataInicio.Text);
            dateFim = DateTime.Parse(MktDataFim.Text);


            FrmVisualizar frmVisualizar = new FrmVisualizar(idCliente, dataInicio, dateFim);
            frmVisualizar.ShowDialog();
        }
    }
}
