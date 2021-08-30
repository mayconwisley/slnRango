using Banco;
using Objetos.Credito;
using System;
using System.Data;
using System.Text;

namespace Controle.Credito
{
    public class Alterar
    {
        public bool Cadastro(CreditoObjeto credito)
        {
            Crud crud = new Crud();
            StringBuilder sql = new StringBuilder();

            sql.Append("UPDATE Credito ");
            sql.Append("SET Data =  @Data, Valor =  @Valor ");
            sql.Append("WHERE Id = @Id");

            try
            {
                crud.LimparParametros();
                crud.AdicionarParamentro("Data", credito.Data);
                crud.AdicionarParamentro("Valor", credito.Valor);
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
