using System;
using System.Linq;

namespace DesignPatterns.Strategy
{
    public class PagamentoBoletoService : IPagamento
    {
        private readonly PagamentoBoletoFacade _pagamentoBoletoFacade;

        public PagamentoBoletoService(PagamentoBoletoFacade pagamentoBoletoFacade)
        {
            _pagamentoBoletoFacade = pagamentoBoletoFacade;
        }

        public Pagamento RealizarPagamento(Pedido pedido, Pagamento pagamento)
        {
            pagamento.ValorPagamento = pedido.Produtos.Sum(p => p.Valor);
            Console.WriteLine("Iniciando pagamento via boleto - Valor R$ " + pagamento.ValorPagamento);

            pagamento.LinhaDigitavelBoleto = _pagamentoBoletoFacade.GerarBoleto();
            pagamento.Status = "Aguardando Pagamento";

            return pagamento;
        }

    }
}