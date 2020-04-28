namespace DesignPatterns.Strategy
{
    internal class PagamentoCartaoCreditoFacade : IPagamentoCartaoCreditoFacade
    {
        private readonly PayPalGateway _payPalGateway;
        private readonly ConfigurationManager _configurationManager;

        public PagamentoCartaoCreditoFacade(PayPalGateway payPalGateway, ConfigurationManager configurationManager)
        {
            _payPalGateway = payPalGateway;
            _configurationManager = configurationManager;
        }

        public string GerarPagamentoCartaoCredito()
        {
            //Realizar Pagamento Gatway
            return _payPalGateway.Pagar();
        }
    }
}