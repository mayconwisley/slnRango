using Controle.Credito;
using Controle.Credito.Listar;
using Controle.Validar;
using Objetos.Credito;
using System;
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
    public partial class FrmCadCredito : Form
    {
        public FrmCadCredito()
        {
            InitializeComponent();
        }

        int idCliente, idCredito;

        private void Manipular(char opc)
        {
            CreditoObjeto credito = new CreditoObjeto();
            Gravar gravar = new Gravar();
            Alterar alterar = new Alterar();
            Excluir excluir = new Excluir();

            try
            {
                credito.Id = idCredito;
                credito.Cliente = new Objetos.Cliente.ClienteObjeto();
                credito.Cliente.Id = idCliente;
                credito.Data = DateTime.Parse(MktData.Text.Trim());
                credito.Valor = decimal.Parse(TxtValor.Text.Trim());

                switch (opc)
                {
                    case 'G':
                        gravar.Cadastro(credito);
                        break;
                    case 'A':
                        alterar.Cadastro(credito);
                        break;
                    case 'E':
                        excluir.Cadastro(credito);
                        break;
                    default:
                        MessageBox.Show("Sem Manipulação");
                        break;
                }

                Listar($"%{TxtPesquisa.Text.Trim()}%");

                BtnAlterar.Enabled = false;
                BtnExcluir.Enabled = false;
                BtnGravar.Enabled = true;
                CbxCliente.Enabled = true;
                MktData.Text = DateTime.Now.ToString("d");
                TxtValor.Clear();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void Listar(string pesquisa)
        {
            Lista lista = new Lista();
            DgvLista.DataSource = lista.Geral(pesquisa);
        }

        private void DgvLista_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            idCredito = int.Parse(DgvLista.Rows[e.RowIndex].Cells["Id"].Value.ToString());
            idCliente = int.Parse(DgvLista.Rows[e.RowIndex].Cells["Cliente_Id"].Value.ToString());
            CbxCliente.SelectedValue = idCliente;
            decimal valor = decimal.Parse(DgvLista.Rows[e.RowIndex].Cells["Valor"].Value.ToString());
            TxtValor.Text = valor.ToString("#,##0.00");

            MktData.Text = DgvLista.Rows[e.RowIndex].Cells["Data"].Value.ToString();

            CbxCliente.Enabled = false;

            BtnAlterar.Enabled = true;
            BtnExcluir.Enabled = true;
            BtnGravar.Enabled = false;
        }

        private void BtnGravar_Click(object sender, EventArgs e)
        {
            Manipular('G');
        }

        private void BtnAlterar_Click(object sender, EventArgs e)
        {
            Manipular('A');
        }

        private void BtnExcluir_Click(object sender, EventArgs e)
        {
            Manipular('E');
        }

        private void TxtPesquisa_TextChanged(object sender, EventArgs e)
        {
            Listar($"%{TxtPesquisa.Text.Trim()}%");
        }

        private void TxtValor_TextChanged(object sender, EventArgs e)
        {
            FormatarValor formatarValor = new FormatarValor();
            TxtValor.Text = formatarValor.Valor(TxtValor.Text);
            TxtValor.Select(TxtValor.Text.Length, 0);
        }

        private void TxtValor_Leave(object sender, EventArgs e)
        {
            FormatarValor formatarValor = new FormatarValor();
            TxtValor.Text = formatarValor.Zero(TxtValor.Text.Trim());
        }

        private void TxtValor_Enter(object sender, EventArgs e)
        {
            if (TxtValor.Text == "0,00")
            {
                TxtValor.Text = "";
            }
        }

        private void FrmCadCredito_Load(object sender, EventArgs e)
        {
            ListarCliente();
            Listar($"%{TxtPesquisa.Text.Trim()}%");
            MktData.Text = DateTime.Now.ToString("d");
        }

        private void CbxCliente_SelectedIndexChanged(object sender, EventArgs e)
        {
            idCliente = int.Parse(CbxCliente.SelectedValue.ToString());
        }

        private void ListarCliente()
        {
            Controle.Cliente.Listar.Lista lista = new Controle.Cliente.Listar.Lista();
            try
            {
                CbxCliente.DataSource = lista.IdNome();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

    }
}
