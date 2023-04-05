using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios05.Ex01
{
    public class Retangulo
    {
        public double volume { get; set; }
        public double largura { get; set;}
        public double comprimento { get; set;}
        public double altura { get; set;}

        public double CalcularVolume()
        {
            volume = altura * largura * comprimento;
            return volume;
        }
    }
}
