using Banco;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controle.Relatorio
{
    public class Extrato
    {
        public DataTable Produto(int idCliente, DateTime dataInicio, DateTime dataFim)
        {

            Crud crud = new Crud();
            StringBuilder sql = new StringBuilder();
            DataTable dataTable = new DataTable();
            sql.Append("SELECT EP.Cliente_Id AS ClienteId, EP.Nome, EP.Produto_Id AS ProdutoId, EP.Descricao, EP.Data, EP.Retirada, EP.Venda, " +
                       "EP.Valor, EP.Total, EP.Info, SUM(IIF(EP.Venda > 0, EP.Total, 0)) - SUM(IIF(EP.RETIRADA > 0, EP.Total, 0)) AS Saldo ");
            sql.Append("FROM Extrato_Produto EP ");
            sql.Append("WHERE EP.Cliente_Id = @Cliente_Id AND EP.Data BETWEEN @DataInicio AND @DataFim ");
            sql.Append("GROUP BY EP.Cliente_Id, EP.Nome, EP.Produto_Id, EP.Descricao, EP.Data, EP.Retirada, EP.Venda, EP.Valor, EP.Total, EP.Info ");
            sql.Append("ORDER BY EP.Data DESC, EP.Nome ASC, EP.Descricao");


            try
            {
                crud.LimparParametros();
                crud.AdicionarParamentro("Cliente_Id", idCliente);
                crud.AdicionarParamentro("DataInicio", dataInicio);
                crud.AdicionarParamentro("DataFim", dataFim);
                return dataTable = crud.Tabela(CommandType.Text, sql.ToString());

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }


        public DataTable CreDeb(int idCliente, DateTime dataInicio, DateTime dataFim)
        {

            Crud crud = new Crud();
            StringBuilder sql = new StringBuilder();
            DataTable dataTable = new DataTable();
            sql.Append("SELECT ECD.Cliente_Id AS ClienteId, ECD.Data, ECD.Nome, ECD.Produto_Id AS ProdutoId, ECD.Descricao, ECD.Credito, ECD.Debito, ECD.Saldo, ECD.Info ");
            sql.Append("FROM Extrato_Cd ECD ");
            sql.Append("WHERE ECD.Cliente_Id = @Cliente_Id AND ECD.Data BETWEEN @DataInicio AND @DataFim ");
            sql.Append("GROUP BY ECD.Cliente_Id, ECD.Data, ECD.Nome, ECD.Produto_Id, ECD.Descricao, ECD.Credito, ECD.Debito, ECD.Saldo, ECD.Info ");
            sql.Append("ORDER BY ECD.Data DESC, ECD.Nome ASC, ECD.Descricao");


            try
            {
                crud.LimparParametros();
                crud.AdicionarParamentro("Cliente_Id", idCliente);
                crud.AdicionarParamentro("DataInicio", dataInicio);
                crud.AdicionarParamentro("DataFim", dataFim);
                return dataTable = crud.Tabela(CommandType.Text, sql.ToString());

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
