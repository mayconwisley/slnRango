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
            sql.Append("SELECT EP.Cliente_Id AS ClienteId, EP.Nome, EP.Produto_Id AS ProdutoId, EP.Descricao, EP.Data, EP.Retirada, EP.Venda, EP.Valor, EP.Total, EP.Info ");
            sql.Append("FROM Extrato_Produto EP ");
            sql.Append("WHERE EP.Cliente_Id = @Cliente_Id AND EP.Data BETWEEN @DataInicio AND @DataFim ");
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
    }
}
