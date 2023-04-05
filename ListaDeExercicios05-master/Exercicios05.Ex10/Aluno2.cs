using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios05.Ex10
{
    internal class Aluno2
    {

        public int nota1 { get; set; }
    public int nota2 { get; set; }
    public int peso1 { get; set; }
    public int peso2 { get; set; }

    public double CalcularMediaPonderada()
    {
        return (nota1 * peso1 + nota2 * peso2) / (peso1 + peso2);
    }
}
}
