using Banco;
using Objetos.Debito;
using System;
using System.Data;
using System.Text;

namespace Controle.Debito
{
    public class Excluir
    {
        public bool Cadastro(DebitoObjeto debito)
        {
            Crud crud = new Crud();
            StringBuilder sql = new StringBuilder();

            sql.Append("DELETE FROM Retirada ");
            sql.Append("WHERE Id = @Id");

            try
            {
                crud.LimparParametros();
                crud.AdicionarParamentro("Id", debito.Id);
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
