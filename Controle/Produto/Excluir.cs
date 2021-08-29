using Banco;
using Objetos.Produto;
using System;
using System.Data;
using System.Text;

namespace Controle.Produto
{
    public class Excluir
    {
        public bool Cadastro(ProdutoObjeto produto)
        {
            Crud crud = new Crud();
            StringBuilder sql = new StringBuilder();

            sql.Append("DELETE FROM  Produto ");
            sql.Append("WHERE Id = @Id");

            try
            {
                crud.LimparParametros();
                crud.AdicionarParamentro("Id", produto.Id);
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
