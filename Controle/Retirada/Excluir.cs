using Banco;
using Objetos.Retirada;
using System;
using System.Data;
using System.Text;

namespace Controle.Retirada
{
    public class Excluir
    {
        public bool Cadastro(RetiradaObjeto retirada)
        {
            Crud crud = new Crud();
            StringBuilder sql = new StringBuilder();

            sql.Append("DELETE FROM Retirada ");
            sql.Append("WHERE Id = @Id");

            try
            {
                crud.LimparParametros();
                crud.AdicionarParamentro("Id", retirada.Id);
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
