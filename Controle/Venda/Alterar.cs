using Banco;
using Objetos.Venda;
using System;
using System.Data;
using System.Text;

namespace Controle.Venda
{
    public class Alterar
    {
        public bool Cadastro(VendaObjeto venda)
        {
            Crud crud = new Crud();
            StringBuilder sql = new StringBuilder();

            sql.Append("UPDATE Venda ");
            sql.Append("SET Produto_Id = @Produto_Id, Data = @Data, Quantidade =  @Quantidade, Valor =  @Valor ");
            sql.Append("WHERE Id = @Id");

            try
            {
                crud.LimparParametros();
                crud.AdicionarParamentro("Produto_Id", venda.Produto.Id);
                crud.AdicionarParamentro("Data", venda.Data);
                crud.AdicionarParamentro("Quantidade", venda.Quantidade);
                crud.AdicionarParamentro("Valor", venda.Valor);
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
