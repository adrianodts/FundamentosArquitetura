using System;
using System.Collections.Generic;
using System.Text;

namespace OOP
{
    public class Pessoa {
        public string Nome { get; set; }
    }

    public interface IRepository<T>
    {
        void Adicionar(T entity);

        void Excluir(T entity);
    }

    public interface IPessoaRepository
    {
        void Adicionar(Pessoa entity);
    }

    public class Repository<T> : IRepository<T>
    {
        public void Adicionar(T entity)
        {
            //Metodo Concreto
        }

        public void Excluir(T entity)
        {
            //Metodo Concreto
        }
    }

    public class PessoaHerancaRepository : Repository<Pessoa>, IPessoaRepository
    {    
    }

    public class PessoaComposicaoRepository : IPessoaRepository
    {
        private IRepository<Pessoa> _repository;

        public PessoaComposicaoRepository(IRepository<Pessoa> repository)
        {
            _repository = repository;
        }

        public void Adicionar(Pessoa entity)
        {
            _repository.Adicionar(entity);
        }
    }

    public class Teste
    {
        public void testar()
        {
            //Muito acoplado, pois usa Herança
            var heranca = new PessoaHerancaRepository();
            heranca.Adicionar(new Pessoa());
            heranca.Excluir(new Pessoa());

            //Menos acoplado, pois usa composição
            var composicao = new PessoaComposicaoRepository(new Repository<Pessoa>()); //Usa injeção de Dependencia
            composicao.Adicionar(new Pessoa());
            //composicao.Excluir(new Pessoa());
        }
    }
}

