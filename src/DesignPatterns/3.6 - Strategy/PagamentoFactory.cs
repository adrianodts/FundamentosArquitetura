using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Strategy
{
    public class PagamentoFactory
    {
        public static IPagamento CreatePagamento(MeioPagamento meioPagamento)
        {
            switch (meioPagamento)
            {
                case MeioPagamento.TransferenciaBancaria:
                    return new PagamentoTransferenciaService(
                        new PagamentoTransferenciaFacade());
                case MeioPagamento.Boleto:
                    return new PagamentoBoletoService(
                        new PagamentoBoletoFacade());
                case MeioPagamento.CartaoCredito:
                    return new PagamentoCartaoCreditoService(
                        new PagamentoCartaoCreditoFacade(
                            new PayPalGateway(),
                                new ConfigurationManager()));
                default:
                    throw new ApplicationException("Meio de pagamento não reconhecido");
            }
        }
    }
}
