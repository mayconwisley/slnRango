using System;

namespace Objetos.Produto
{
    public class ProdutoObjeto
    {
        public int Id { get; set; }
        public DateTime Data { get; set; }
        public string Descricao { get; set; }
        public decimal Valor { get; set; }
        public char Ativo { get; set; }
    }
}
