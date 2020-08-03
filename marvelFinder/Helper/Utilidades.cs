using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace marvelFinder.Helper
{
    public class Utilidades
    {
        public bool IsNumeric(string value)
        {
            return value.All(char.IsNumber);
        }
    }
}
