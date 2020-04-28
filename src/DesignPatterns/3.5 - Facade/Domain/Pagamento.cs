using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Facade.Domain
{
    public class Pagamento : IPagamento
    {
        public Pedido Pedido { get; private set; }

        public MeioPagamento MeioPagamento { get; private set; }
        public CartaoCredito CartaoCredito { get; set; }
        public Boleto Boleto { get; set; }
        public decimal ValorPagamento { get; set; }
        public StatusPagamento StatusPagamento { get; set; }

        public Pagamento(Pedido pedido, MeioPagamento meioPagamento)
        {
            Pedido = pedido;
            MeioPagamento = meioPagamento;
        }
        
    }
}
