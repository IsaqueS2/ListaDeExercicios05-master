using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaExercicios05.Ex05
{
    internal class Esfera
    {
        public int raio { get; set; }
        public double CalcularVolume()
        {
            return 4 * Math.PI * Math.Pow(raio, 3) / 3;
        }
    }
}