using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaExercicios05.Ex06
{
    internal class Temperatura
    {
        public int grausCelsius { get; set; }

        public double ConverterGraus()
        {
            return (grausCelsius * 1.8) + 32;
        }
    }
}
