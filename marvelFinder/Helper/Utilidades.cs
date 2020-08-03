using marvelFinder.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace marvelFinder.Helper
{
    public class Utilidades
    {
        public bool IsNumeric(string value)
        {
            return value.All(char.IsNumber);
        }

        public List<SuperHeroViewModel.Result> getNotResult(string MensajeP)
        {
            try
            {
                List<SuperHeroViewModel.Result> lista = new List<SuperHeroViewModel.Result>();
                SuperHeroViewModel.Result model = new SuperHeroViewModel.Result();
                SuperHeroViewModel.Appearance Appearance = new SuperHeroViewModel.Appearance();
                model.name = "MESSAGE: " + MensajeP;
                Appearance.race = "MESSAGE";
                model.appearance = Appearance;
                lista.Add(model);
                return (lista);
            }
            catch (Exception ex)
            {

                throw;
            }
          
        }
        public List<SuperHeroViewModel.Result> getResultForNumber(SuperHeroViewModel.Root list)
        {
            try
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
                return lista;
            }
            catch (Exception)
            {

                throw;
            }
           
        }
        
    }
}
