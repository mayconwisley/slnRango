using Banco;
using System;
using System.Data;
using System.Text;

namespace Controle.Cliente.Listar
{
    public class Lista
    {
        public DataTable Geral(string pesquisa)
        {
            Crud crud = new Crud();
            StringBuilder sql = new StringBuilder();
            DataTable dataTable = new DataTable();

            sql.Append("SELECT Id, Nome, Telefone, Celular, Ativo ");
            sql.Append("FROM Cliente ");
            sql.Append("WHERE UPPER(Nome) LIKE UPPER(@Nome) ");
            sql.Append("ORDER BY Nome ASC");

            try
            {
                crud.LimparParametros();
                crud.AdicionarParamentro("Nome", pesquisa);
                dataTable = crud.Tabela(CommandType.Text, sql.ToString());
                return dataTable;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public DataTable IdNome()
        {
            Crud crud = new Crud();
            StringBuilder sql = new StringBuilder();
            DataTable dataTable = new DataTable();

            sql.Append("SELECT C.Id, C.Id ||' - ' || C.Nome AS Nome ");
            sql.Append("FROM Cliente C ");
            sql.Append("WHERE C.Ativo = 'S' ");
            sql.Append("ORDER BY C.Nome ASC");

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
    }
}
