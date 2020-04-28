namespace DesignPatterns.Facade.CrossCutting
{
    public class DadosCartao
    {
        public string NumeroCartao { get; set; }
        public string NomeTitular { get; set; }
        public string VencimentoMes { get; set; }
        public string VencimentoAno { get; set; }
        public string Cvv { get; set; }
        public decimal Valor { get; set; }
    }
}