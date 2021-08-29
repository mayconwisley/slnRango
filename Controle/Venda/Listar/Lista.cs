using Banco;
using System;
using System.Data;
using System.Text;

namespace Controle.Venda.Listar
{
    public class Lista
    {
        public DataTable Geral(string pesquisa)
        {
            Crud crud = new Crud();
            StringBuilder sql = new StringBuilder();
            DataTable dataTable = new DataTable();

            sql.Append("SELECT V.Id, V.Cliente_Id,C.Nome,  V.Produto_Id, P.Descricao, V.Data, V.Quantidade, V.Valor, (V.Quantidade * V.Valor) AS Total ");
            sql.Append("FROM Venda V ");
            sql.Append("INNER JOIN Cliente C ON V.Cliente_Id = C.Id ");
            sql.Append("INNER JOIN Produto P ON V.Produto_Id = P.Id ");
            sql.Append("WHERE UPPER(C.Nome) LIKE UPPER(@Nome) OR UPPER(P.Descricao) LIKE UPPER(@Descricao) ");
            sql.Append("ORDER BY C.Nome ASC, P.Descricao ASC");

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

            sql.Append("SELECT V.Id, V.Cliente_Id,C.Nome,  V.Produto_Id, P.Descricao, V.Data, V.Quantidade, V.Valor, (V.Quantidade * V.Valor) AS Total ");
            sql.Append("FROM Venda V ");
            sql.Append("INNER JOIN Cliente C ON V.Cliente_Id = C.Id ");
            sql.Append("INNER JOIN Produto P ON V.Produto_Id = P.Id ");
            sql.Append("WHERE V.Cliente_Id = @Cliente_Id ");
            sql.Append("ORDER BY C.Nome ASC, P.Descricao ASC");

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

        public DataTable IdDescricao(int idCliente)
        {
            Crud crud = new Crud();
            StringBuilder sql = new StringBuilder();
            DataTable dataTable = new DataTable();

            sql.Append("SELECT V.Produto_Id , V.Produto_Id || ' - ' || P.Descricao AS Descricao ");
            sql.Append("FROM Venda V ");
            sql.Append("INNER JOIN Produto P ON V.Produto_Id = P.Id ");
            sql.Append("WHERE P.Ativo = 'S' AND V.Cliente_Id = @Cliente_Id ");
            sql.Append("GROUP BY V.Produto_Id, P.Descricao ");
            sql.Append("ORDER BY P.Descricao ASC ");


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

        public DataTable Saldo()
        {
            Crud crud = new Crud();
            StringBuilder sql = new StringBuilder();
            DataTable dataTable = new DataTable();

            sql.Append("SELECT SC.Cliente_Id, SC.Nome, SC.Produto_Id, SC.Descricao, SC.Saldo, SC.Valor, SC.Total ");
            sql.Append("FROM Saldo_Cliente SC ");
            sql.Append("ORDER BY SC.Nome ASC, SC.Descricao ASC");

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

        public DataTable SaldoCliente(int idCliente)
        {
            Crud crud = new Crud();
            StringBuilder sql = new StringBuilder();
            DataTable dataTable = new DataTable();
            sql.Append("SELECT SC.Cliente_Id, SC.Nome, SC.Produto_Id, SC.Descricao, SC.Saldo, SC.Valor, SC.Total ");
            sql.Append("FROM Saldo_Cliente SC ");
            sql.Append("WHERE SC.Cliente_Id = @Cliente_Id ");
            sql.Append("ORDER BY SC.Nome ASC, SC.Descricao ASC");

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
            sql.Append("FROM Venda ");
            sql.Append("WHERE Cliente_Id = @Cliente_Id AND Produto_Id = @Produto_Id ");

            try
            {
                crud.LimparParametros();
                crud.AdicionarParamentro("Cliente_Id", idCliente);
                crud.AdicionarParamentro("Produto_Id", idProduto);
                int quantidade = int.Parse(crud.Executar(CommandType.Text, sql.ToString()).ToString());
                return quantidade;

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

    }
}
