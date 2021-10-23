using Banco;
using Objetos.Cliente;
using System;
using System.Data;
using System.Text;

namespace Controle.Cliente
{
    public class Excluir
    {
        public bool Cadastro(ClienteObjeto cliente)
        {
            Crud crud = new Crud();
            StringBuilder sql = new StringBuilder();

            sql.Append("DELETE FROM Cliente ");
            sql.Append("WHERE Id = @Id");

            try
            {
                crud.LimparParametros();
                crud.AdicionarParamentro("Id", cliente.Id);
                crud.Executar(CommandType.Text, sql.ToString());
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

            return true;
        }
    }
}
