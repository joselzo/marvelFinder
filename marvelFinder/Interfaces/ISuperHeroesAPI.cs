using marvelFinder.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace marvelFinder.Interfaces
{
    interface ISuperHeroesAPI
    {
        public interface IDetailsRepository
        {
            public HttpClient Finder(string Param);
         
        }
    }
}
