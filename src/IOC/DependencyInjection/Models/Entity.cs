using System;

namespace DependencyInjection.Models
{
    public abstract class Entity
    {
        protected Guid Id { get; set; }
        protected DateTime DataCadastro { get; set; }
    }
}