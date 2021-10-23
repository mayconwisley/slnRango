using System;

namespace Objetos.Relatorio
{
    public class ExtratoProdutoObjeto
    {
        public int ClienteId { get; set; }
        public string Nome { get; set; }
        public int ProdutoId { get; set; }
        public string Descricao { get; set; }
        public DateTime Data { get; set; }
        public int Retirada { get; set; }
        public int Venda { get; set; }
        public decimal Valor { get; set; }
        public decimal Total { get; set; }
        public string Info { get; set; }
        public decimal Saldo { get; set; }


    }
}
