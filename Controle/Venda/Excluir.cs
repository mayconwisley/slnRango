using Banco;
using Objetos.Venda;
using System;
using System.Data;
using System.Text;

namespace Controle.Venda
{
    public class Excluir
    {
        public bool Cadastro(VendaObjeto venda)
        {
            Crud crud = new Crud();
            StringBuilder sql = new StringBuilder();

            sql.Append("DELETE FROM Venda ");
            sql.Append("WHERE Id = @Id");

            try
            {
                crud.LimparParametros();
                crud.AdicionarParamentro("Id", venda.Id);
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
