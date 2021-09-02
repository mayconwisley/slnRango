using System;

namespace Objetos.Relatorio
{
    public class ExtratoCDObejto
    {
        public int ClienteId { get; set; }
        public DateTime Data { get; set; }
        public string Nome { get; set; }
        public int ProdutoId { get; set; }
        public string Descricao { get; set; }
        public decimal Credito { get; set; }
        public decimal Debito { get; set; }
        public decimal Saldo { get; set; }
        public string Info { get; set; }
    }
}
