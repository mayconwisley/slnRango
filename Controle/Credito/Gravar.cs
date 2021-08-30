using Banco;
using Objetos.Credito;
using System;
using System.Data;
using System.Text;

namespace Controle.Credito
{
    public class Gravar
    {
        public bool Cadastro(CreditoObjeto credito)
        {
            Crud crud = new Crud();
            StringBuilder sql = new StringBuilder();

            sql.Append("INSERT INTO Credito(Cliente_Id, Data, Valor) ");
            sql.Append("VALUES(@Cliente_Id, @Data, @Valor) ");

            try
            {
                crud.LimparParametros();
                crud.AdicionarParamentro("Cliente_Id", credito.Cliente.Id);
                crud.AdicionarParamentro("Data", credito.Data);
                crud.AdicionarParamentro("Valor", credito.Valor);

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
