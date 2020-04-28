using DesignPatterns.Facade.Domain;

namespace DesignPatterns.Strategy
{
    public interface IPagamento
    {
        Pagamento RealizarPagamento(Pedido pedido, Pagamento pagamento);
    }
}