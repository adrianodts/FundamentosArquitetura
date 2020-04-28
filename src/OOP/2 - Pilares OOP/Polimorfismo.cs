using System;
using System.Collections.Generic;
using System.Text;

namespace OOP
{
    public class CafeteiraExpressa : EletroDomestico
    {
        public CafeteiraExpressa(string nome, int voltagem) : base (nome, voltagem)
        {
            //Acoes da especificacao
        }
        
        public void Preparar()
        {
            Ligar();
            Testar();
            Desligar();
        }

        protected override void Desligar()
        {
            //Ligar 
        }

        protected override void Ligar()
        {
            //Desligar
        }

        protected override void Testar()
        {
            //Implementacao Testar
            System.Diagnostics.Debug.WriteLine("Teste Cafeteira");
        }
    }
}
