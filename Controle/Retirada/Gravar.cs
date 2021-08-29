using Banco;
using Objetos.Retirada;
using System;
using System.Data;
using System.Text;

namespace Controle.Retirada
{
    public class Gravar
    {
        public bool Cadastro(RetiradaObjeto retirada)
        {
            Crud crud = new Crud();
            StringBuilder sql = new StringBuilder();

            sql.Append("INSERT INTO Retirada(Cliente_Id, Produto_Id, Data, Quantidade, Valor) ");
            sql.Append("VALUES(@Cliente_Id, @Produto_Id, @Data, @Quantidade, @Valor)");

            try
            {
                crud.LimparParametros();
                crud.AdicionarParamentro("Cliente_Id", retirada.Cliente.Id);
                crud.AdicionarParamentro("Produto_Id", retirada.Produto.Id);
                crud.AdicionarParamentro("Data", retirada.Data);
                crud.AdicionarParamentro("Quantidade", retirada.Quantidade);
                crud.AdicionarParamentro("Valor", retirada.Valor);
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
