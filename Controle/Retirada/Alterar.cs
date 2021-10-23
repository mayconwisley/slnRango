using Banco;
using Objetos.Retirada;
using System;
using System.Data;
using System.Text;

namespace Controle.Retirada
{
    public class Alterar
    {
        public bool Cadastro(RetiradaObjeto retirada)
        {
            Crud crud = new Crud();
            StringBuilder sql = new StringBuilder();

            sql.Append("UPDATE Retirada ");
            sql.Append("SET Produto_Id = @Produto_Id, Data = @Data, Quantidade =  @Quantidade, Valor =  @Valor ");
            sql.Append("WHERE Id = @Id");

            try
            {
                crud.LimparParametros();
                crud.AdicionarParamentro("Produto_Id", retirada.Produto.Id);
                crud.AdicionarParamentro("Data", retirada.Data);
                crud.AdicionarParamentro("Quantidade", retirada.Quantidade);
                crud.AdicionarParamentro("Valor", retirada.Valor);
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
