using marvelFinder.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace marvelFinder.Helper
{
    public class SuperHeroesAPI : ISuperHeroesAPI
    {
        Utilidades _Util = new Utilidades();
       
        public HttpClient Finder(string Param)
        {
            try
            {
                var client = new HttpClient();
                if (_Util.IsNumeric(Param))
                {
                    client.BaseAddress = new Uri(" https://superheroapi.com/api/3208655845889385/" + Param);
                }
                else
                {
                    client.BaseAddress = new Uri("https://www.superheroapi.com/api.php/3208655845889385/search/" + Param);
                }

                return client;
            }
            catch (Exception)
            {

                throw;
            }
           
        }

    }
}
