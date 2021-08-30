using Banco;
using Objetos.Debito;
using System;
using System.Data;
using System.Text;

namespace Controle.Debito
{
    public class Alterar
    {
        public bool Cadastro(DebitoObjeto debito)
        {
            Crud crud = new Crud();
            StringBuilder sql = new StringBuilder();

            sql.Append("UPDATE Debito ");
            sql.Append("SET Produto_Id = @Produto_Id, Data = @Data, Quantidade =  @Quantidade, Valor =  @Valor ");
            sql.Append("WHERE Id = @Id");

            try
            {
                crud.LimparParametros();
                crud.AdicionarParamentro("Produto_Id", debito.Produto.Id);
                crud.AdicionarParamentro("Data", debito.Data);
                crud.AdicionarParamentro("Quantidade", debito.Quantidade);
                crud.AdicionarParamentro("Valor", debito.Valor);
                crud.AdicionarParamentro("Id", debito.Id);
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
