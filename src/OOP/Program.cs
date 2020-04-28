using System;
using System.Collections.Generic;
using System.Text;

namespace OOP
{
    public class Program
    {
        public static void Main(String[] args)
        {
            var humano = new Animal("Adriano", new DateTime(1974, 11, 25));
            System.Diagnostics.Debug.WriteLine("Nome : " + humano.Nome());
            System.Diagnostics.Debug.WriteLine("DataNascimento : " + humano.DataNascimento());
            System.Diagnostics.Debug.WriteLine("ToString: " +  humano.ToString());
            System.Diagnostics.Debug.WriteLine("Idade: " + humano.CalcularIdade());

            var eletromestico = new CafeteiraExpressa("Douce Gusto", 220);
            eletromestico.Preparar();
        }
    }
}
