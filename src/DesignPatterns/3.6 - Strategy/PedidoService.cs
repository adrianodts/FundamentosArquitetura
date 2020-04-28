using DesignPatterns.Facade.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPatterns.Strategy
{
    public class PedidoService
    {
        public readonly IPagamento _pagamento;

        public PedidoService(IPagamento pagamento)
        {
            _pagamento = pagamento;
        }

        public Pagamento RealizarPagamento(Pedido pedido, Pagamento pagamento)
        {
           return _pagamento.RealizarPagamento(pedido, pagamento);
        }

    }
}
