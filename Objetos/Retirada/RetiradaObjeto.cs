using Objetos.Cliente;
using Objetos.Produto;
using System;

namespace Objetos.Retirada
{
    public class RetiradaObjeto
    {
        public int Id { get; set; }
        public ClienteObjeto Cliente { get; set; }
        public ProdutoObjeto Produto { get; set; }
        public DateTime Data { get; set; }
        public int Quantidade { get; set; }
        public decimal Valor { get; set; }
    }
}
