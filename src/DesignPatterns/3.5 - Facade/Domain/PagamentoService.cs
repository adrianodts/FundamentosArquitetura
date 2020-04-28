using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPatterns.Facade.Domain
{
    public class PedidoService
    {
        public readonly IPagamentoFacade _pagamentoFacade;

        public PedidoService(IPagamentoFacade pagamentoFacade)
        {
            _pagamentoFacade = pagamentoFacade;
        }

        public Pagamento RealizarPagamento(Pedido pedido, Pagamento pagamento)
        {
            pedido.Valor = pedido.Produtos.Sum(p => p.Valor);
            pagamento.ValorPagamento = pedido.Valor;

            Console.WriteLine("Iniciando pagamento com Cartão de Crédito - Valor Pedido : R$ "+ pedido.Valor);

            pagamento = _pagamentoFacade.RealizarPagamento();

            if (pagamento.StatusPagamento == StatusPagamento.Autorizado)
                Console.WriteLine("Pagamento realizado com sucesso!!!");
            else if (pagamento.StatusPagamento == StatusPagamento.Recusado)
                Console.WriteLine("Pagamento recusado junto a operadora de cartão de credito!!!");
            else if (pagamento.StatusPagamento == StatusPagamento.Analise)
                Console.WriteLine("Pagamento em análise junto a operadora de cartão de credito!!!");

            return pagamento;
        }

    }
}
