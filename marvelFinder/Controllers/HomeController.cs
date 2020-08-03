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
        SuperHeroesAPI _api = new SuperHeroesAPI();
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

        [HttpGet]
        public async Task<IActionResult> Character(BuscarViewModel buscar)
        {
            if (buscar.Param == null)
            {
                buscar.Param = "0";
            }
            //buscar.Param = buscar.Param ?? default("");
            SuperHeroViewModel.Root list = new SuperHeroViewModel.Root();
            HttpClient clientNum = _api.FinderId(buscar.Param);
            HttpClient clientName = _api.FinderName(buscar.Param);
            HttpResponseMessage res;
            var data = new List<SuperHeroViewModel>();
            if (IsNumeric(buscar.Param))
            {
                res = await clientNum.GetAsync("");
                if (res.IsSuccessStatusCode)
                {
                    var result = res.Content.ReadAsStringAsync().Result;
                    list = JsonConvert.DeserializeObject<SuperHeroViewModel.Root>(result);
                }
                if (list.response == "error")
                {
                    List<SuperHeroViewModel.Result> lista = new List<SuperHeroViewModel.Result>();
                    SuperHeroViewModel.Result model = new SuperHeroViewModel.Result();
                    model.name = "NO HAY RESULTADOS";
                    lista.Add(model);
                    return View(lista);
                }
                else
                {
                    List<SuperHeroViewModel.Result> lista = new List<SuperHeroViewModel.Result>();
                    SuperHeroViewModel.Result model = new SuperHeroViewModel.Result();
                    model.name = list.name;
                    model.image = list.image;
                    model.powerstats = list.powerstats;
                    model.id = list.id;
                    model.work = list.work;
                    model.appearance = list.appearance;
                    model.biography = list.biography;
                    model.connections = list.connections;
                    lista.Add(model);
                    return View(lista);
                }
               
            }
            else
            {
                res = await clientName.GetAsync("");
                if (res.IsSuccessStatusCode)
                {
                    var result = res.Content.ReadAsStringAsync().Result;
                    list = JsonConvert.DeserializeObject<SuperHeroViewModel.Root>(result);
                }
                if (list.response == "error")
                {
                    List<SuperHeroViewModel.Result> lista = new List<SuperHeroViewModel.Result>();
                    SuperHeroViewModel.Result model = new SuperHeroViewModel.Result();
                    model.name = "NO HAY RESULTADOS";
                    lista.Add(model);
                    return View(lista);
                }
                else
                {
                    return View(list.results);
                }
            }



        }
        public bool IsNumeric(string value)
        {

            return value.All(char.IsNumber);
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
