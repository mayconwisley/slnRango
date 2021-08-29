using Controle.Produto;
using Controle.Produto.Listar;
using Controle.Validar;
using Objetos.Produto;
using System;
using System.Windows.Forms;

namespace Rango
{
    public partial class FrmCadProduto : Form
    {
        public FrmCadProduto()
        {
            InitializeComponent();
        }

        int idProduto;

        //Manipulação do produtos
        private void Manipular(char opc)
        {
            ProdutoObjeto produto = new ProdutoObjeto();
            Gravar gravar = new Gravar();
            Alterar alterar = new Alterar();
            Excluir excluir = new Excluir();


            try
            {
                produto.Id = idProduto;
                produto.Data = DateTime.Parse(MktData.Text.Trim());
                produto.Descricao = TxtDescricao.Text.Trim();
                produto.Valor = decimal.Parse(TxtValor.Text.Trim());

                if (CbAtivo.Checked)
                {
                    produto.Ativo = 'S';
                }
                else
                {
                    produto.Ativo = 'N';
                }


                switch (opc)
                {
                    case 'G':
                        gravar.Cadastro(produto);
                        break;
                    case 'A':
                        alterar.Cadastro(produto);
                        break;
                    case 'E':
                        excluir.Cadastro(produto);
                        break;

                    default:
                        MessageBox.Show("Sem opção de Manipulação");
                        break;
                }

                Listar($"%{TxtPesquisa.Text.Trim()}%");

                TxtDescricao.Clear();
                TxtValor.Text = "0,00";
                MktData.Clear();

                BtnAlterar.Enabled = false;
                BtnExcluir.Enabled = false;
                BtnGravar.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //Listar Produtos
        private void Listar(string pesquisa)
        {
            Lista lista = new Lista();

            try
            {
                DgvLista.DataSource = lista.Geral(pesquisa);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void FrmCadProduto_Load(object sender, EventArgs e)
        {
            Listar($"%{TxtPesquisa.Text.Trim()}%");
            MktData.Text = DateTime.Now.ToString("dd/MM/yyyy");
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

        private void DgvLista_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            idProduto = int.Parse(DgvLista.Rows[e.RowIndex].Cells["Id"].Value.ToString());
            TxtDescricao.Text = DgvLista.Rows[e.RowIndex].Cells["Descricao"].Value.ToString();
            TxtValor.Text = DgvLista.Rows[e.RowIndex].Cells["Valor"].Value.ToString();
            MktData.Text = DgvLista.Rows[e.RowIndex].Cells["Data"].Value.ToString();
            char ativo = char.Parse(DgvLista.Rows[e.RowIndex].Cells["Ativo"].Value.ToString());

            if (ativo == 'S')
            {
                CbAtivo.Checked = true;
            }
            else
            {
                CbAtivo.Checked = false;
            }

            BtnAlterar.Enabled = true;
            BtnExcluir.Enabled = true;
            BtnGravar.Enabled = false;
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
            TxtValor.Text = formatarValor.ParaValor(TxtValor.Text.Trim());
        }

        private void TxtValor_Enter(object sender, EventArgs e)
        {
            if (TxtValor.Text == "0,00")
            {
                TxtValor.Clear();
            }
        }
    }
}
