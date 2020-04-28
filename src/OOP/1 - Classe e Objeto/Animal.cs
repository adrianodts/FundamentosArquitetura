using System;
using System.Collections.Generic;
using System.Text;

namespace OOP
{
    //Estrutura Classe

    public class Animal
    {
        private readonly string _nome;
        private readonly DateTime _dataNascimento;

        public string Nome()
        {
            return this._nome;
        }

        public DateTime DataNascimento()
        {
            return this._dataNascimento;
        }

        public Animal(string nome, DateTime dataNascimento)
        {
            this._nome = nome;
            this._dataNascimento = dataNascimento;
        }

        public int CalcularIdade()
        {          
            int anos = DateTime.Now.Year - _dataNascimento.Year;
            if (DateTime.Now.Month < _dataNascimento.Month ||
                (DateTime.Now.Month == _dataNascimento.Month && DateTime.Now.Day < _dataNascimento.Day))
            {
                anos--;
            }
            return anos;
        }

        public override string ToString()
        { 
            return "Animal [ _nome : " + _nome + ", _dataNascimento : " + _dataNascimento + " ]";
        }
    }

    //Objeto
    public class TesteObjeto
    {
        public void Testar()
        {
            var humano = new Animal("Adriano", new DateTime(1974, 11, 25));
            System.Diagnostics.Debug.WriteLine("Nome : " + humano.Nome());
            System.Diagnostics.Debug.WriteLine("DataNascimento : " + humano.DataNascimento());
            System.Diagnostics.Debug.WriteLine("ToString: " + humano.ToString());
            System.Diagnostics.Debug.WriteLine("Idade: " + humano.CalcularIdade());
        }
    }
}
