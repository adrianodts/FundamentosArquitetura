using System;
using System.Linq;

namespace DesignPatterns.Strategy
{
    public class PagamentoTransferenciaService : IPagamento
    {
        private readonly PagamentoTransferenciaFacade _pagamentoTransferenciaFacade;

        public PagamentoTransferenciaService(PagamentoTransferenciaFacade pagamentoTransferenciaFacade)
        {
            _pagamentoTransferenciaFacade = pagamentoTransferenciaFacade;
        }

        public Pagamento RealizarPagamento(Pedido pedido, Pagamento pagamento)
        {
            pagamento.ValorPagamento = pedido.Produtos.Sum(p => p.Valor);
            Console.WriteLine("Iniciando pagamento via transferencia - Valor R$ " + pagamento.ValorPagamento);

            pagamento.ConfirmacaoTransferencia = _pagamentoTransferenciaFacade.RealizarTransferencia();
            pagamento.Status = "Pago via transferencia";

            return pagamento;
        }
    }
}