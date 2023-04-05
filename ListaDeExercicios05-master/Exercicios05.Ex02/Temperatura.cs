using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios05.Ex02
{
    internal class Temperatura
    {
        public int grauFahrenheit { get; set; }

        public double ConverterGraus()
        {
            return (grauFahrenheit - 32) / 1.8;
        }
    }
}