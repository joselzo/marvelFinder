using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using marvelFinder.Helper;
using marvelFinder.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Caching.Memory;
using Newtonsoft.Json;

namespace marvelFinder.Controllers
{
    public class CharacterController : Controller
    {
        SuperHeroesAPI _api = new SuperHeroesAPI();
        Utilidades _Util = new Utilidades();
        private IMemoryCache _cache;
        public CharacterController(IMemoryCache cache)
        {
            _cache = cache;
        }
        public async Task<IActionResult> Character(string Param)
        {
            List<SuperHeroViewModel.Result> data = new List<SuperHeroViewModel.Result>();
            try
            {
                Param = Param ?? "0";
                var PalabraBUscada = Param;
                SuperHeroViewModel.Root list = new SuperHeroViewModel.Root();
                HttpResponseMessage res;
            

                HttpClient client = _api.Finder(Param);
                if (!_cache.TryGetValue(PalabraBUscada, out data))
                {
                    if (data == null)
                    {
                        res = await client.GetAsync("");
                        if (res.IsSuccessStatusCode)
                        {
                            var result = res.Content.ReadAsStringAsync().Result;
                            list = JsonConvert.DeserializeObject<SuperHeroViewModel.Root>(result);
                        }
                        if (list.response == "error")
                            data = (_Util.getNotResult("NO RESULT"));
                        else
                        {
                            if (_Util.IsNumeric(Param))
                                data = (_Util.getResultForNumber(list));
                            else
                                data = (list.results);
                        }
                    }
                    var cacheConf = new MemoryCacheEntryOptions().SetSlidingExpiration(TimeSpan.FromMinutes(60));
                    _cache.Set(PalabraBUscada, data, cacheConf);
                }
                return View(data);
            }
            catch (Exception)
            {
                data = (_Util.getNotResult("ERROR, CONTACT THE ADMIN"));
                return View(data);
            }

        }




    }
}