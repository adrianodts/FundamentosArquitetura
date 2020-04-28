using DependencyInjection.Models;

namespace DependencyInjection.Repository
{
    public interface IGenericRepository<T> where T : Entity
    {
        void Adicionar(T entity);
    }
}