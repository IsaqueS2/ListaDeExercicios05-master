using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaExercicios05.Ex04
{
    internal class Carro
    {
        public int consumoCombustivel { get; set; }
        public int kmInicial { get; set; }
        public int kmFinal { get; set; }

        public double CalcularConsumo()
        {
            return (kmFinal - kmInicial) / consumoCombustivel;
        }
    }
}