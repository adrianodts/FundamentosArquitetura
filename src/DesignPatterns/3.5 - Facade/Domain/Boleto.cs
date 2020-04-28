using System;

namespace DesignPatterns.Facade.Domain
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