using Controle.Debito;
using Controle.Debito.Listar;
using Controle.Validar;
using Objetos.Debito;
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
    public partial class FrmCadDebito : Form
    {
        public FrmCadDebito()
        {
            InitializeComponent();
        }

        int idCliente, idProduto, idDebito;
        decimal valorProduto = 0, valorCredito = 0;

        //Manipular dados de venda
        private void Manipular(char opc)
        {
            DebitoObjeto debito = new DebitoObjeto();
            Gravar gravar = new Gravar();
            Alterar alterar = new Alterar();
            Excluir excluir = new Excluir();

            try
            {
                debito.Id = idDebito;
                debito.Cliente = new Objetos.Cliente.ClienteObjeto();
                debito.Cliente.Id = idCliente;
                debito.Produto = new Objetos.Produto.ProdutoObjeto();
                debito.Produto.Id = idProduto;

                debito.Data = DateTime.Parse(MktData.Text.Trim());
                debito.Quantidade = int.Parse(TxtQuantidade.Text.Trim());
                debito.Valor = decimal.Parse(TxtValor.Text.Trim());

                switch (opc)
                {
                    case 'G':

                        if (debito.Quantidade <= 0)
                        {
                            MessageBox.Show($"Quantidade Inválida!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            TxtQuantidade.Text = "1";
                            return;
                        }

                        gravar.Cadastro(debito);
                        break;
                    case 'A':

                        if (debito.Quantidade <= 0)
                        {
                            MessageBox.Show($"Quantidade Inválida!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            TxtQuantidade.Text = "1";
                            return;
                        }

                        alterar.Cadastro(debito);
                        break;
                    case 'E':
                        excluir.Cadastro(debito);
                        break;
                    default:
                        MessageBox.Show("Sem Manipulação");
                        break;
                }

                Listar($"%{TxtPesquisa.Text.Trim()}%");
                ValidarSaldo(idCliente);

                BtnAlterar.Enabled = false;
                BtnExcluir.Enabled = false;
                BtnGravar.Enabled = true;

                CbxCliente.Enabled = true;
                TxtQuantidade.Text = "1";
                MktData.Text = DateTime.Now.ToString("d");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void CbxProduto_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                Controle.Produto.Listar.Lista lista = new Controle.Produto.Listar.Lista();
                idProduto = int.Parse(CbxProduto.SelectedValue.ToString());
                valorProduto = lista.ValorProduto(idProduto);
                TxtIdProduto.Text = idProduto.ToString();
                TxtValor.Text = valorProduto.ToString("#,##0.00");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void DgvLista_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            idDebito = int.Parse(DgvLista.Rows[e.RowIndex].Cells["Id"].Value.ToString());

            idCliente = int.Parse(DgvLista.Rows[e.RowIndex].Cells["Cliente_Id"].Value.ToString());
            idProduto = int.Parse(DgvLista.Rows[e.RowIndex].Cells["Produto_Id"].Value.ToString());

            CbxCliente.SelectedValue = idCliente;
            CbxProduto.SelectedValue = idProduto;

            TxtQuantidade.Text = DgvLista.Rows[e.RowIndex].Cells["Quantidade"].Value.ToString();
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

        private void TxtIdCliente_Leave(object sender, EventArgs e)
        {
            idCliente = int.Parse(TxtIdCliente.Text.Trim());
            CbxCliente.SelectedValue = idCliente;
            ListarProduto(idCliente);
        }

        private void TxtIdProduto_Leave(object sender, EventArgs e)
        {
            idProduto = int.Parse(TxtIdProduto.Text);
            CbxProduto.SelectedValue = idProduto;
            CbxProduto_SelectedIndexChanged(e, e);
        }

        private void FrmCadDebito_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
            }
        }

        private void TxtIdCliente_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                CbxProduto.Text = "";
                TxtIdProduto.Text = "";
                idCliente = int.Parse(TxtIdCliente.Text.Trim());
                CbxCliente.SelectedValue = idCliente;
                ListarProduto(idCliente);
            }
        }

        private void TxtIdProduto_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                idProduto = int.Parse(TxtIdProduto.Text);
                CbxProduto.SelectedValue = idProduto;
                CbxProduto_SelectedIndexChanged(e, e);
            }
        }

        private void TxtQuantidade_TextChanged(object sender, EventArgs e)
        {
            FormatarValor formatarValor = new FormatarValor();
            TxtQuantidade.Text = formatarValor.Numero(TxtQuantidade.Text);
            TxtQuantidade.Select(TxtQuantidade.Text.Length, 0);
        }

        private void TxtQuantidade_Leave(object sender, EventArgs e)
        {
            FormatarValor formatarValor = new FormatarValor();
            TxtQuantidade.Text = formatarValor.ZeroNumero(TxtQuantidade.Text.Trim());
        }

        private void TxtQuantidade_Enter(object sender, EventArgs e)
        {
            if (TxtQuantidade.Text == "0")
            {
                TxtQuantidade.Text = "1";
            }
        }

        private void CbxCliente_SelectedIndexChanged(object sender, EventArgs e)
        {
            CbxProduto.Text = "";
            TxtIdProduto.Text = "";
            idCliente = int.Parse(CbxCliente.SelectedValue.ToString());
            TxtIdCliente.Text = idCliente.ToString();
            ListarProduto(idCliente);
            ValidarSaldo(idCliente);
        }

        private void FrmCadDebito_Load(object sender, EventArgs e)
        {
            ListarCliente();
            Listar($"%{TxtPesquisa.Text.Trim()}%");
            MktData.Text = DateTime.Now.ToString("d");
        }

        private void Listar(string pesquisa)
        {
            Lista lista = new Lista();
            DgvLista.DataSource = lista.Geral(pesquisa);
        }

        private void ListarCliente()
        {
            Controle.Cliente.Listar.Lista lista = new Controle.Cliente.Listar.Lista();
            CbxCliente.DataSource = lista.IdNome();
        }

        private void ValidarSaldo(int idCliente)
        {
            Controle.Credito.Listar.Lista lista = new Controle.Credito.Listar.Lista();
            valorCredito = lista.SaldoAtual(idCliente);
            LblSaldo.Text = $"Saldo Atual: {valorCredito.ToString("#,##0.00")}";
        }

        private void ListarProduto(int idCliente)
        {
            Controle.Produto.Listar.Lista lista = new Controle.Produto.Listar.Lista();
            try
            {
                CbxProduto.DataSource = lista.IdDescricao();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
