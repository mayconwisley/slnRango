using Banco;
using Objetos.Venda;
using System;
using System.Data;
using System.Text;

namespace Controle.Venda
{
    public class Gravar
    {
        public bool Cadastro(VendaObjeto venda)
        {
            Crud crud = new Crud();
            StringBuilder sql = new StringBuilder();

            sql.Append("INSERT INTO Venda(Cliente_Id, Produto_Id, Data, Quantidade, Valor) ");
            sql.Append("VALUES(@Cliente_Id, @Produto_Id, @Data, @Quantidade, @Valor)");

            try
            {
                crud.LimparParametros();
                crud.AdicionarParamentro("Cliente_Id", venda.Cliente.Id);
                crud.AdicionarParamentro("Produto_Id", venda.Produto.Id);
                crud.AdicionarParamentro("Data", venda.Data);
                crud.AdicionarParamentro("Quantidade", venda.Quantidade);
                crud.AdicionarParamentro("Valor", venda.Valor);
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
