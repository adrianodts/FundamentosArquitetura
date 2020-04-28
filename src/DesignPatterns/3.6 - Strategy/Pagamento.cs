namespace DesignPatterns.Strategy
{
    public class Pagamento
    {
        public Pedido Pedido { get; private set; }

        public MeioPagamento MeioPagamento { get; private set; }
        public CartaoCredito CartaoCredito { get; set; }
        public Boleto Boleto { get; set; }
        public decimal ValorPagamento { get; set; }
        public string ConfirmacaoTransferencia { get; set; }
        public string LinhaDigitavelBoleto { get; internal set; }
        public string Status { get; internal set; }

        public Pagamento(Pedido pedido, MeioPagamento meioPagamento)
        {
            Pedido = pedido;
            MeioPagamento = meioPagamento;
        }

    }
}