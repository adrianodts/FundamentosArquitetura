using DesignPatterns.Facade.CrossCutting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPatterns.Facade.Domain
{
    public class PagamentoCartaoCreditoFacade : IPagamentoFacade
    {
        public Pagamento Pagamento { get; private set; }

        public PagamentoCartaoCreditoFacade(Pagamento pagamento)
        {
            Pagamento = pagamento;
        }

        public Pagamento RealizarPagamento()
        {
            //Realizar Pagamento Externo ou em algum sistema interno
            //Para esse motivo serve a FACADE
            if (ObterTipoParceiro().Equals(TipoParceiro.PayPal)){
                IPaypalGateway paypal = new PaypalGateway();

                try
                {
                    bool resultado = paypal.CommitTransaction(Pagamento.Pedido.Id.ToString(), Pagamento.ValorPagamento,
                        Pagamento.CartaoCredito.NumeroCartao, Pagamento.CartaoCredito.NomeTitular,
                        Pagamento.CartaoCredito.DataValidadeMes, Pagamento.CartaoCredito.DataValidadeAno,
                        Pagamento.CartaoCredito.CodigoSeguranca);

                    if (resultado)
                        Pagamento.StatusPagamento = StatusPagamento.Autorizado;
                    else
                        Pagamento.StatusPagamento = StatusPagamento.Recusado;
                } catch (Exception ex)
                {
                    Console.WriteLine(ex.StackTrace);
                }
            }
            return Pagamento;
        }

        /**
         *  Preciso identificar qual adquirente de cartão de credito vou trabalhar para processar 
         *  a compra. 
         *  Para isso pode ser consultado no banco de dados ou obtido do arquivo de resources
         *  Por simplicidade usei um fixo 
         */
        private TipoParceiro ObterTipoParceiro()
        {
            return TipoParceiro.PayPal;
        }


    }
}
