using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using marvelFinder.Models;
using marvelFinder.Helper;
using System.Net.Http;
using Newtonsoft.Json;

namespace marvelFinder.Controllers
{
    public class HomeController : Controller
    {
       
        //SuperHeroViewModel _api = new SuperHeroViewModel();

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        private readonly ILogger<HomeController> _logger;


        [HttpGet]
        public IActionResult Index()
        {
            List<SuperHeroViewModel.Result> lista = new List<SuperHeroViewModel.Result>();
            SuperHeroViewModel.Result model = new SuperHeroViewModel.Result();
            model.name = "NO HAY RESULTADOS";
            lista.Add(model);
            return View(lista);
        }

       


       
    }
}
