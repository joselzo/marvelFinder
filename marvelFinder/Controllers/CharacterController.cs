using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using marvelFinder.Helper;
using marvelFinder.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace marvelFinder.Controllers
{
    public class CharacterController : Controller
    {
        SuperHeroesAPI _api = new SuperHeroesAPI();
        Utilidades _Util = new Utilidades();
        public async Task<IActionResult> Character(BuscarViewModel buscar)
        {
            buscar.Param = buscar.Param ??  "0";
          
            SuperHeroViewModel.Root list = new SuperHeroViewModel.Root();
            HttpClient clientNum = _api.FinderId(buscar.Param);
            HttpClient clientName = _api.FinderName(buscar.Param);
            HttpResponseMessage res;
            var data = new List<SuperHeroViewModel>();
            if (_Util.IsNumeric(buscar.Param))
            {
                res = await clientNum.GetAsync("");
                if (res.IsSuccessStatusCode)
                {
                    var result = res.Content.ReadAsStringAsync().Result;
                    list = JsonConvert.DeserializeObject<SuperHeroViewModel.Root>(result);
                }
                if (list.response == "error")
                {
                    return View(_Util.getNotResult());
                }
                else
                {
                    return View(_Util.getResultForNumber(list));
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
                    return View(_Util.getNotResult());
                }
                else
                {
                    return View(list.results);
                }
            }



        }
        
    }
}