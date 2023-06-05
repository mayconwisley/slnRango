using Banco;
using Objetos.Cliente;
using System;
using System.Data;
using System.Text;

namespace Controle.Cliente
{
    public class Alterar
    {
        public bool Cadastro(ClienteObjeto cliente)
        {
            Crud crud = new Crud();
            StringBuilder sql = new StringBuilder();

            sql.Append("UPDATE Cliente ");
            sql.Append("SET Nome = @Nome, Telefone =  @Telefone, Celular = @Celular, Ativo = @Ativo ");
            sql.Append("WHERE Id = @Id");

            try
            {
                crud.LimparParametros();
                crud.AdicionarParamentro("Nome", cliente.Nome);
                crud.AdicionarParamentro("Telefone", cliente.Telefone);
                crud.AdicionarParamentro("Celular", cliente.Celular);
                crud.AdicionarParamentro("Ativo", cliente.Ativo);
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
