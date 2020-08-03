using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace marvelFinder.Helper
{
    public class SuperHeroesAPI
    {
        public HttpClient FinderName(string Param)
        {
            var client = new HttpClient();
            client.BaseAddress = new Uri("https://www.superheroapi.com/api.php/3208655845889385/search/"+ Param);
            return client;
        }
        public HttpClient FinderId(string Param)
        {
            var client = new HttpClient();
            client.BaseAddress = new Uri(" https://superheroapi.com/api/3208655845889385/"+Param);
            return client;
        }
    }
}
