using Banco;
using System;
using System.Data;
using System.Text;

namespace Controle.Produto.Listar
{
    public class Lista
    {
        public DataTable Geral(string pesquisa)
        {
            Crud crud = new Crud();
            StringBuilder sql = new StringBuilder();
            DataTable dataTable = new DataTable();

            sql.Append("SELECT Id, Data, Descricao, Valor, Ativo ");
            sql.Append("FROM Produto ");
            sql.Append("WHERE UPPER(Descricao) LIKE UPPER(@Descricao) ");
            sql.Append("ORDER BY Descricao ASC");

            try
            {
                crud.LimparParametros();
                crud.AdicionarParamentro("Descricao", pesquisa);
                dataTable = crud.Tabela(CommandType.Text, sql.ToString());
                return dataTable;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public DataTable IdDescricao()
        {
            Crud crud = new Crud();
            StringBuilder sql = new StringBuilder();
            DataTable dataTable = new DataTable();

            sql.Append("SELECT P.Id, P.Id || ' - ' || P.Descricao AS Descricao ");
            sql.Append("FROM Produto P ");
            sql.Append("WHERE P.Ativo = 'S' ");
            sql.Append("ORDER BY P.Descricao ASC");

            try
            {
                crud.LimparParametros();
                dataTable = crud.Tabela(CommandType.Text, sql.ToString());
                return dataTable;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public decimal ValorProduto(int idProduto)
        {
            Crud crud = new Crud();
            StringBuilder sql = new StringBuilder();

            sql.Append("SELECT Valor ");
            sql.Append("FROM Produto ");
            sql.Append("WHERE Id = @Id");

            try
            {
                crud.LimparParametros();
                crud.AdicionarParamentro("Id", idProduto);
                decimal valorProduto = decimal.Parse(crud.Executar(CommandType.Text, sql.ToString()).ToString());
                return valorProduto;
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }

        }

    }
}
