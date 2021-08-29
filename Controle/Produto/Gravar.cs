using Banco;
using Objetos.Produto;
using System;
using System.Data;
using System.Text;

namespace Controle.Produto
{
    public class Gravar
    {
        public bool Cadastro(ProdutoObjeto produto)
        {
            Crud crud = new Crud();
            StringBuilder sql = new StringBuilder();

            sql.Append("INSERT INTO Produto (Data, Descricao, Valor, Ativo) ");
            sql.Append("VALUES(@Data, @Descricao, @Valor, @Ativo)");

            try
            {
                crud.LimparParametros();
                crud.AdicionarParamentro("Data", produto.Data);
                crud.AdicionarParamentro("Descricao", produto.Descricao);
                crud.AdicionarParamentro("Valor", produto.Valor);
                crud.AdicionarParamentro("Ativo", produto.Ativo);
                crud.Executar(CommandType.Text, sql.ToString());
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

        }
    }
}
