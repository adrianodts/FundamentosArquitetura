using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using DependencyInjection.Models;
using DependencyInjection.Repository;

namespace DependencyInjection.Controllers
{
    public class HomeController : Controller
    {
        //Injeção de Dependencia via construtor

        public IGenericRepository<Cliente> _genericRepository;

        public HomeController(IGenericRepository<Cliente> genericRepository)
        {
            _genericRepository = genericRepository;
        }

        public IActionResult Index()
        {
            _genericRepository.Adicionar(new Cliente());
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
