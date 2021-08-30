using Banco;
using Objetos.Debito;
using System;
using System.Data;
using System.Text;

namespace Controle.Debito
{
    public class Gravar
    {
        public bool Cadastro(DebitoObjeto debito)
        {
            Crud crud = new Crud();
            StringBuilder sql = new StringBuilder();

            sql.Append("INSERT INTO Debito(Cliente_Id, Produto_Id, Data, Quantidade, Valor) ");
            sql.Append("VALUES(@Cliente_Id, @Produto_Id, @Data, @Quantidade, @Valor)");

            try
            {
                crud.LimparParametros();
                crud.AdicionarParamentro("Cliente_Id", debito.Cliente.Id);
                crud.AdicionarParamentro("Produto_Id", debito.Produto.Id);
                crud.AdicionarParamentro("Data", debito.Data);
                crud.AdicionarParamentro("Quantidade", debito.Quantidade);
                crud.AdicionarParamentro("Valor", debito.Valor);
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
