using DependencyInjection.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DependencyInjection.Repository
{
    public class GenericRepository<T> : IGenericRepository<T>  where T : Entity
    {
        public void Adicionar(T entity)
        {
            //codigo para adicionar 
        }
    }
}
