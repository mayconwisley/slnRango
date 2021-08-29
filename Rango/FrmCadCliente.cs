using Controle.Cliente;
using Controle.Cliente.Listar;
using Objetos.Cliente;
using System;
using System.Windows.Forms;

namespace Rango
{
    public partial class FrmCadCliente : Form
    {
        public FrmCadCliente()
        {
            InitializeComponent();
        }

        int idCliente;

        //Cadastro das informações
        private void Manipular(char opc)
        {
            ClienteObjeto cliente = new ClienteObjeto();
            Gravar gravar = new Gravar();
            Alterar alterar = new Alterar();
            Excluir excluir = new Excluir();

            try
            {
                cliente.Id = idCliente;
                cliente.Nome = TxtNome.Text.Trim();
                cliente.Telefone = MktTelefone.Text.Trim();
                cliente.Celular = MktCelular.Text.Trim();

                if (CbAtivo.Checked)
                {
                    cliente.Ativo = 'S';
                }
                else
                {
                    cliente.Ativo = 'N';
                }

                switch (opc)
                {
                    case 'G':
                        gravar.Cadastro(cliente);
                        break;
                    case 'A':
                        alterar.Cadastro(cliente);
                        break;
                    case 'E':
                        excluir.Cadastro(cliente);

                        break;
                    default:

                        break;
                }
                Listar($"%{TxtPesquisa.Text.Trim()}%");
                TxtNome.Clear();
                MktCelular.Clear();
                MktTelefone.Clear();

                BtnGravar.Enabled = true;
                BtnAlterar.Enabled = false;
                BtnExcluir.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        //Listar as informações

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

        private void FrmCadCliente_Load(object sender, EventArgs e)
        {
            Listar($"%{TxtPesquisa.Text.Trim()}%");
        }

        private void DgvLista_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            idCliente = int.Parse(DgvLista.Rows[e.RowIndex].Cells["Id"].Value.ToString());
            TxtNome.Text = DgvLista.Rows[e.RowIndex].Cells["Nome"].Value.ToString();
            MktTelefone.Text = DgvLista.Rows[e.RowIndex].Cells["Telefone"].Value.ToString();
            MktCelular.Text = DgvLista.Rows[e.RowIndex].Cells["Celular"].Value.ToString();
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
    }
}
