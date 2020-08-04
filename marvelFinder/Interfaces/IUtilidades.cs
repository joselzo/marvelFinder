using marvelFinder.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace marvelFinder.Interfaces
{
    interface IUtilidades
    {
        public bool IsNumeric(string value);
        public List<SuperHeroViewModel.Result> getNotResult(string MensajeP);
        public List<SuperHeroViewModel.Result> getResultForNumber(SuperHeroViewModel.Root list);
    }
}
