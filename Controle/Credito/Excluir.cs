using Banco;
using Objetos.Credito;
using System;
using System.Data;
using System.Text;

namespace Controle.Credito
{
    public class Excluir
    {
        public bool Cadastro(CreditoObjeto credito)
        {
            Crud crud = new Crud();
            StringBuilder sql = new StringBuilder();

            sql.Append("DELETE FROM Credito ");
            sql.Append("WHERE Id = @Id");

            try
            {
                crud.LimparParametros();
                crud.AdicionarParamentro("Id", credito.Id);

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
