using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using Newtonsoft.Json;

namespace DesignPatterns.Facade.CrossCutting
{
    public class PaypalGateway : IPaypalGateway
    {

        public DadosCartao _dadosCartao { get; private set; }

        public bool CommitTransaction(string orderId, decimal amount, string numeroCartao,
            string nomeTitular, string vencimentoMes, string vencimentoAno, string cvv)
        {
            _dadosCartao = new DadosCartao
            {
                Valor = amount,
                NumeroCartao = numeroCartao,
                NomeTitular = nomeTitular,
                VencimentoMes = vencimentoAno,
                VencimentoAno = vencimentoAno,
                Cvv = cvv
            };
            string token = GetCardToken();
            return new Random().Next(2) == 0;
        }

        private string GetCardToken()
        {
            Parceiro parceiro = GetCardHashKey();

            WebClient wc = new WebClient();
            wc.Headers["accept"] = "application/json";
            wc.Headers["accept-language"] = "en_US";
            wc.Headers["authorization"] = "Basic " + parceiro.ApiKey;
            wc.Headers["content-Type"] = "application/x-www-form-urlencoded";

            string response = wc.UploadString(new Uri(parceiro.EndPoint), 
                "POST",  "grant_type=client_credentials"); 
            
            return JsonConvert.DeserializeObject<ResponseToken>(response).access_token;
        }
       
        /**
         *  Obtem os dados adquirente do cartão de credito 
         */
        private Parceiro GetCardHashKey()
        {
            return new Parceiro
            {
                Id = 1,
                Nome = "Paypal",
                EndPoint = "https://api.sandbox.paypal.com/v1/oauth2/token",
                ApiKey = "QWJMenpZODdhYVZjZmJITms0NGFWVlduSktwXzB2SDlnWFg1T24tMGFFTnhlcnlwNENHcGxCX1VqWkNiYkdnX0g4NUg0SWJab19YSFFqV2I6RVBub1gyUDkzU05DVlhUNzZLQnJfOTc0QVN1MS1NdHhLeEI5a0FNYzk3ZjVJSDNOV1V5cG1rcm5TTm5YWTVJNS05N0htaVdGUGtrNFpPSWo="
            };
        }
    }
}
