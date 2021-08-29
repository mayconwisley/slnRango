using Banco;
using System;
using System.Data;
using System.Text;

namespace Controle.Retirada.Listar
{
    public class Lista
    {
        public DataTable Geral(string pesquisa)
        {
            Crud crud = new Crud();
            StringBuilder sql = new StringBuilder();
            DataTable dataTable = new DataTable();

            sql.Append("SELECT R.Id, R.Cliente_Id,C.Nome,  R.Produto_Id, P.Descricao, R.Data, R.Quantidade, R.Valor, (R.Quantidade * R.Valor) AS Total ");
            sql.Append("FROM Retirada R ");
            sql.Append("INNER JOIN Cliente C ON R.Cliente_Id = C.Id ");
            sql.Append("INNER JOIN Produto P ON R.Produto_Id = P.Id ");
            sql.Append("WHERE UPPER(C.Nome) LIKE UPPER(@Nome) OR UPPER(P.Descricao) LIKE UPPER(@Descricao) ");
            sql.Append("ORDER BY C.Nome ASC, P.Descricao ASC, R.Data DESC");

            try
            {
                crud.LimparParametros();
                crud.AdicionarParamentro("Nome", pesquisa);
                crud.AdicionarParamentro("Descricao", pesquisa);
                dataTable = crud.Tabela(CommandType.Text, sql.ToString());
                return dataTable;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public DataTable GeralCliente(int idCliente)
        {
            Crud crud = new Crud();
            StringBuilder sql = new StringBuilder();
            DataTable dataTable = new DataTable();

            sql.Append("SELECT R.Id, R.Cliente_Id,C.Nome,  R.Produto_Id, P.Descricao, R.Data, R.Quantidade, R.Valor, (R.Quantidade * R.Valor) AS Total ");
            sql.Append("FROM Retirada R ");
            sql.Append("INNER JOIN Cliente C ON R.Cliente_Id = C.Id ");
            sql.Append("INNER JOIN Produto P ON R.Produto_Id = P.Id ");
            sql.Append("WHERE R.Cliente_Id = @Cliente_Id ");
            sql.Append("ORDER BY C.Nome ASC, P.Descricao ASC, R.Data DESC");

            try
            {
                crud.LimparParametros();
                crud.AdicionarParamentro("Cliente_Id", idCliente);
                dataTable = crud.Tabela(CommandType.Text, sql.ToString());
                return dataTable;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public int Quantidade(int idCliente, int idProduto)
        {

            Crud crud = new Crud();
            StringBuilder sql = new StringBuilder();

            sql.Append("SELECT SUM(Quantidade) ");
            sql.Append("FROM Retirada ");
            sql.Append("WHERE Cliente_Id = @Cliente_Id AND Produto_Id = @Produto_Id ");

            try
            {
                crud.LimparParametros();
                crud.AdicionarParamentro("Cliente_Id", idCliente);
                crud.AdicionarParamentro("Produto_Id", idProduto);

                var quantidade = crud.Executar(CommandType.Text, sql.ToString()).ToString();

                if (quantidade != "")
                {
                    return int.Parse(quantidade.ToString());
                }
                else
                {
                    return 0;
                }
                
                
                

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

    }
}
