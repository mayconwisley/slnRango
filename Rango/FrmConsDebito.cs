using System;
using System.Windows.Forms;

namespace Rango
{
    public partial class FrmConsDebito : Form
    {
        public FrmConsDebito()
        {
            InitializeComponent();
        }
        int idCliente;

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
        private void Listar(int idCliente)
        {
            Controle.Debito.Listar.Lista lista = new Controle.Debito.Listar.Lista();

            try
            {
                if (CbGeral.Checked)
                {
                    DgvLista.DataSource = lista.Geral("%%");
                }
                else
                {
                    DgvLista.DataSource = lista.GeralId(idCliente);
                }

                SomarValor();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void SomarValor()
        {

            decimal valor = 0;
            foreach (DataGridViewRow item in DgvLista.Rows)
            {
                valor += decimal.Parse(item.Cells["Total"].Value.ToString());
            }
            LblTotal.Text = $"Total Débito: {valor.ToString("#,##0.00")}";

        }

        private void FrmConsDebito_Load(object sender, EventArgs e)
        {
            ListarCliente();
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
            Listar(idCliente);
        }

        private void CbGeral_CheckedChanged(object sender, EventArgs e)
        {
            if (CbGeral.Checked)
            {
                TxtIdCliente.Enabled = false;
                CbxCliente.Enabled = false;
            }
            else
            {
                TxtIdCliente.Enabled = true;
                CbxCliente.Enabled = true;
            }
            Listar(idCliente);
        }

        private void TxtIdCliente_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {

                idCliente = int.Parse(TxtIdCliente.Text.Trim());
                CbxCliente.SelectedValue = idCliente;
            }

        }

        private void FrmConsDebito_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
            }
        }
    }
}
