using System;
using System.Collections.Generic;

namespace DesignPatterns.Strategy
{
    public class Pedido
    {
        public int Id { get; set; }
        public DateTime DataPedido { get; set; }
        public decimal Valor { get; set; }
        public List<Produto> Produtos { get; private set; }

        public Pedido(List<Produto> produtos)
        {
            Produtos = produtos;
        }
    }
}