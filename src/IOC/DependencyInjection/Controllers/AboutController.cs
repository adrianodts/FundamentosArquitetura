using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DependencyInjection.Repository;
using Microsoft.AspNetCore.Mvc;

namespace DependencyInjection.Controllers
{
    public class AboutController : Controller
    {
        // Injeção de Dependencia via propriedade
        // Dificulta os testes
        // Usar caso não for possível usar no construtor

        public IActionResult Index([FromServices] IGenericRepository<About> genericRepository)
        {
            genericRepository.Adicionar(new About());
            return View();
        }
    }
}