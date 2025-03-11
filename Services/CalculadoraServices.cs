using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CalculadoraApi.Services
{
    public class CalculadoraServices
    {
        public string AutorizarOperacao(int codigo)
        {
            if (codigo == 123)
            {
                return "Autorizado";
            }
            return "Não autorizado";
        }
    }
}