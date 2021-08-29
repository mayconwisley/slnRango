using Banco;
using Objetos.Cliente;
using System;
using System.Data;
using System.Text;

namespace Controle.Cliente
{
    public class Gravar
    {
        public bool Cadastro(ClienteObjeto cliente)
        {
            Crud crud = new Crud();
            StringBuilder sql = new StringBuilder();

            sql.Append("INSERT INTO Cliente(Nome, Telefone, Celular, Ativo) ");
            sql.Append("VALUES (@Nome, @Telefone, @Celular, @Ativo)");

            try
            {
                crud.LimparParametros();
                crud.AdicionarParamentro("Nome", cliente.Nome);
                crud.AdicionarParamentro("Telefone", cliente.Telefone);
                crud.AdicionarParamentro("Celular", cliente.Celular);
                crud.AdicionarParamentro("Ativo", cliente.Ativo);
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
