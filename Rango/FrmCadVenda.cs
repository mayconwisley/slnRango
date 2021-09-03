using Controle.Validar;
using Controle.Venda;
using Controle.Venda.Listar;
using Objetos.Venda;
using System;
using System.Windows.Forms;

namespace Rango
{
    public partial class FrmCadVenda : Form
    {
        public FrmCadVenda()
        {
            InitializeComponent();
        }

        int idCliente, idProduto, idVenda;
        decimal valorProduto = 0;

        //Manipular dados de venda
        private void Manipular(char opc)
        {
            VendaObjeto venda = new VendaObjeto();
            Gravar gravar = new Gravar();
            Alterar alterar = new Alterar();
            Excluir excluir = new Excluir();

            try
            {
                venda.Id = idVenda;
                venda.Cliente = new Objetos.Cliente.ClienteObjeto();
                venda.Cliente.Id = idCliente;
                venda.Produto = new Objetos.Produto.ProdutoObjeto();
                venda.Produto.Id = idProduto;

                venda.Data = DateTime.Parse(MktData.Text.Trim());
                venda.Quantidade = int.Parse(TxtQuantidade.Text.Trim());
                venda.Valor = decimal.Parse(TxtValor.Text.Trim());

                switch (opc)
                {
                    case 'G':
                        if (venda.Quantidade <= 0)
                        {
                            MessageBox.Show($"É necessário digitar pelo menos 1 produto!\n\nVerifique", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            TxtQuantidade.Text = "1";
                            return;
                        }

                        gravar.Cadastro(venda);
                        break;
                    case 'A':
                        if (venda.Quantidade <= 0)
                        {
                            MessageBox.Show($"É necessário digitar pelo menos 1 produto!\n\nVerifique", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            TxtQuantidade.Text = "1";
                            return;
                        }

                        alterar.Cadastro(venda);
                        break;
                    case 'E':
                        excluir.Cadastro(venda);
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


                TxtQuantidade.Text = "0";
                MktData.Text = DateTime.Now.ToString("d");

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

        private void ListarProduto()
        {
            Controle.Produto.Listar.Lista lista = new Controle.Produto.Listar.Lista();
            CbxProduto.DataSource = lista.IdDescricao();
        }

        private void CbxProduto_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                Controle.Produto.Listar.Lista lista = new Controle.Produto.Listar.Lista();

                idProduto = int.Parse(CbxProduto.SelectedValue.ToString());
                valorProduto = lista.ValorProduto(idProduto);

                TxtValor.Text = valorProduto.ToString("#,##0.00");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void DgvLista_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            idVenda = int.Parse(DgvLista.Rows[e.RowIndex].Cells["Id"].Value.ToString());

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
                TxtQuantidade.Text = "";
            }
        }

        private void FrmCadVenda_Load(object sender, EventArgs e)
        {
            ListarCliente();
            ListarProduto();
            Listar($"%{TxtPesquisa.Text.Trim()}%");
            MktData.Text = DateTime.Now.ToString("d");
        }

        private void CbxCliente_SelectedIndexChanged(object sender, EventArgs e)
        {
            idCliente = int.Parse(CbxCliente.SelectedValue.ToString());
        }
    }
}
