using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.Options;

namespace CalculadoraApi.Models
{
    public class CalculadoraModels
    {
        public double valor1 { get; set; }
        public double valor2 { get; set; }

        public CalculadoraModels(double valor1, double valor2)
        {
            this.valor1 = valor1;
            this.valor2 = valor2;
        }

        public double Somar(double valor1, double valor2)
        {
            return valor1 + valor2;
        }

        public double Diminuir(double valor1, double valor2)
        {
            return valor1 - valor2;
        }

        public double Multiplicar(double valor1, double valor2)
        {
            return valor1 * valor2;
        }

        public double Dividir(double valor1, double valor2)
        {
            return valor1 / valor2;
        }
    }
}