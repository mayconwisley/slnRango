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
    }
}
