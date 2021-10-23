using Banco;
using System;
using System.Data;
using System.Text;

namespace Controle.Debito.Listar
{
    public class Lista
    {
        public DataTable Geral(string pesquisa)
        {
            Crud crud = new Crud();
            StringBuilder sql = new StringBuilder();
            DataTable dataTable = new DataTable();

            sql.Append("SELECT D.Id, D.Cliente_Id,C.Nome,  D.Produto_Id, P.Descricao, D.Data, D.Quantidade, D.Valor, (D.Quantidade * D.Valor) AS Total ");
            sql.Append("FROM Debito D ");
            sql.Append("INNER JOIN Cliente C ON D.Cliente_Id = C.Id ");
            sql.Append("INNER JOIN Produto P ON D.Produto_Id = P.Id ");
            sql.Append("WHERE UPPER(C.Nome) LIKE UPPER(@Nome) OR UPPER(P.Descricao) LIKE UPPER(@Descricao) ");
            sql.Append("ORDER BY C.Nome ASC, P.Descricao ASC, D.Data DESC");

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

        public DataTable GeralId(int idCliente)
        {
            Crud crud = new Crud();
            StringBuilder sql = new StringBuilder();
            DataTable dataTable = new DataTable();

            sql.Append("SELECT D.Id, D.Cliente_Id,C.Nome,  D.Produto_Id, P.Descricao, D.Data, D.Quantidade, D.Valor, (D.Quantidade * D.Valor) AS Total ");
            sql.Append("FROM Debito D ");
            sql.Append("INNER JOIN Cliente C ON D.Cliente_Id = C.Id ");
            sql.Append("INNER JOIN Produto P ON D.Produto_Id = P.Id ");
            sql.Append("WHERE D.Cliente_Id = @Cliente_Id ");
            sql.Append("ORDER BY C.Nome ASC, P.Descricao ASC, D.Data DESC");

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

    }
}
