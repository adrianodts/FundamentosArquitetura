using DesignPatterns.Facade.Domain;
using System;
using System.Linq;

namespace DesignPatterns.Strategy
{
    internal class PagamentoCartaoCreditoService : IPagamento
    {
        private PagamentoCartaoCreditoFacade _pagamentoCartaoCreditoFacade;

        public PagamentoCartaoCreditoService(PagamentoCartaoCreditoFacade pagamentoCartaoCreditoFacade)
        {
            _pagamentoCartaoCreditoFacade = pagamentoCartaoCreditoFacade;
        }

        public Pagamento RealizarPagamento(Pedido pedido, Pagamento pagamento)
        {
            pagamento.ValorPagamento = pedido.Produtos.Sum(p => p.Valor);
            Console.WriteLine("Iniciando pagamento via cartão de crédito - Valor R$ " + pagamento.ValorPagamento);

            pagamento.ConfirmacaoTransferencia = _pagamentoCartaoCreditoFacade.GerarPagamentoCartaoCredito();
            pagamento.Status = "Pago via Cartao Credito";

            return pagamento;
        }
    }
}