using Objetos.Cliente;
using System;

namespace Objetos.Credito
{
    public class CreditoObjeto
    {
        public int Id { get; set; }
        public ClienteObjeto Cliente { get; set; }
        public DateTime Data { get; set; }
        public decimal Valor { get; set; }
    }
}
