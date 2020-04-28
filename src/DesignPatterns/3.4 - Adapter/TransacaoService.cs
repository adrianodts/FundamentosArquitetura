namespace DesignPatterns.Adapter
{
    //Client
    public class TransacaoService
    {
        private readonly ILogger _logger;

        public TransacaoService(ILogger logger)
        {
            _logger = logger;
        }

        public void ExecutarTransacao()
        {
            _logger.Log("[TransacaoService] -> Executar()");
        }
    }
}