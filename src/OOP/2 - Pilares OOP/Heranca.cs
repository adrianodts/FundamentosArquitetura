using System;
using System.Collections.Generic;
using System.Text;

namespace OOP
{
    public abstract class EletroDomestico
    {
        public string Nome { get; private set; }
        public int Voltagem { get; private set; }

        protected EletroDomestico(string nome, int voltagem)
        {
            this.Nome = nome;
            this.Voltagem = voltagem;
        }

        protected abstract void Ligar();
        protected abstract void Desligar();

        protected virtual void Testar()
        {
            //Fazer teste
            System.Diagnostics.Debug.WriteLine("Teste Eletrodomestico Generico");
        }
    }
}
