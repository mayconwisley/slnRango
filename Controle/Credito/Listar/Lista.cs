using Banco;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controle.Credito.Listar
{
    public class Lista
    {
        public DataTable Geral(string pesquisa)
        {
            Crud crud = new Crud();
            StringBuilder sql = new StringBuilder();
            DataTable dataTable = new DataTable();

            sql.Append("SELECT CR.Id, CR.Cliente_Id, C.Nome, CR.Data, CR.Valor ");
            sql.Append("FROM Credito CR ");
            sql.Append("INNER JOIN Cliente C ON CR.Cliente_Id = C.Id ");
            sql.Append("WHERE UPPER(C.Nome) LIKE UPPER(@Nome) ");
            sql.Append("ORDER BY C.Nome ASC");

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
        public DataTable GeralId(int idCliente)
        {
            Crud crud = new Crud();
            StringBuilder sql = new StringBuilder();
            DataTable dataTable = new DataTable();

            sql.Append("SELECT C.Id, C.Cliente_Id, CL.Nome, C.Data, C.Valor ");
            sql.Append("FROM Credito C ");
            sql.Append("INNER JOIN Cliente CL ON C.Cliente_Id = CL.Id ");
            sql.Append("WHERE CL.Id = @Id ");
            sql.Append("ORDER BY CL.Nome ASC");

            try
            {
                crud.LimparParametros();
                crud.AdicionarParamentro("Id", idCliente);
                dataTable = crud.Tabela(CommandType.Text, sql.ToString());
                return dataTable;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }


        public decimal SaldoAtual(int idCliente)
        {
            Crud crud = new Crud();
            StringBuilder sql = new StringBuilder();

            sql.Append("SELECT SUM(SCD.Saldo) ");
            sql.Append("FROM Saldo_Credito_Debito SCD ");
            sql.Append("WHERE SCD.Cliente_Id = @Cliente_Id");

            try
            {
                crud.LimparParametros();
                crud.AdicionarParamentro("Cliente_Id", idCliente);


                return decimal.Parse(crud.Executar(CommandType.Text, sql.ToString()).ToString());


            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
