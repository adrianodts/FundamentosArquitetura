namespace DesignPatterns.Facade.CrossCutting
{
    public interface IPaypalGateway
    {
        bool CommitTransaction(string orderId, decimal amount, string numeroCartao,
            string nomeTitular, string vencimentoMes, string vencimentoAno, string cvv);
        
    }
}