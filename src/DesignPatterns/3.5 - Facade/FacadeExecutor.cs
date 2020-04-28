using DesignPatterns.Facade.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Facade
{
    public class FacadeExecutor
    {
        public static void Execute()
        {
            var produtos = new List<Produto>()
            {
                new Produto {Id = Guid.NewGuid(), Descricao = "Alcool Gel 70 vol.", Valor = 15.01M},
                new Produto {Id = Guid.NewGuid(), Descricao = "Mascara Especial", Valor = 27.35M},
                new Produto {Id = Guid.NewGuid(), Descricao = "Roupa Especial", Valor = 150.50M},
            };

            var pedido = new Pedido(produtos)
            {
                Id = new Random().Next(999999999),
                DataPedido = DateTime.Now,
                Valor = 0.0M
            };

            var pagamento = new Pagamento(pedido, MeioPagamento.CartaoCredito)
            {
                CartaoCredito = new CartaoCredito
                {
                    NomeTitular = "Fulano de Tal", //Faltou Bandeiras (Visa, AMEX, Dinners, etc)
                    NumeroCartao = "1111-1111-1111-1111",
                    DataValidadeMes = "01",
                    DataValidadeAno = "30",
                    CodigoSeguranca = "123"
                }
            };

            //Resolver com Injeção de Dependência
            var pagamentoService = new PedidoService(new PagamentoCartaoCreditoFacade(pagamento));
            var pagamentoResult = pagamentoService.RealizarPagamento(pedido, pagamento);



        }   
        
    }
}
