using System;

namespace DesignPatterns.Strategy
{
    public class Boleto
    {
        public string NumeroCodigoBarras { get; set; }
        public string NomeBeneficiario { get; set; }
        public string NomePagador { get; set; }
        public DateTime DataVencimento { get; set; }
        public decimal Valor { get; set; }

    }
}