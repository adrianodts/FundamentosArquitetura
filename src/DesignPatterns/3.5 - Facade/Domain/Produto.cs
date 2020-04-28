using System;

namespace DesignPatterns.Facade.Domain
{
    public class Produto
    {
        public Guid Id { get; set; }
        public string Descricao { get; set; }
        public decimal Valor { get; set; }
    }
}