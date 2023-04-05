using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios05.Ex09
{ 
    internal class Aluno
    {
        public int nota1 { get; set; }
        public int nota2 { get; set; }
        public int peso1 { get; set; }
        public int peso2 { get; set; }


        public double CalcularMediaHarmonica()
        {
            double x = 1.0 / nota1;
            double y = 1.0 / nota2;
            return 2.0 / (x + y);
        }

      
    }
}
