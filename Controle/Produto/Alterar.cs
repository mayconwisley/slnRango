using Banco;
using Objetos.Produto;
using System;
using System.Data;
using System.Text;

namespace Controle.Produto
{
    public class Alterar
    {
        public bool Cadastro(ProdutoObjeto produto)
        {
            Crud crud = new Crud();
            StringBuilder sql = new StringBuilder();

            sql.Append("UPDATE  Produto ");
            sql.Append("SET Data = @Data, Descricao = @Descricao, Valor = @Valor, Ativo = @Ativo ");
            sql.Append("WHERE Id = @Id");

            try
            {
                crud.LimparParametros();
                crud.AdicionarParamentro("Data", produto.Data);
                crud.AdicionarParamentro("Descricao", produto.Descricao);
                crud.AdicionarParamentro("Valor", produto.Valor);
                crud.AdicionarParamentro("Ativo", produto.Ativo);
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
