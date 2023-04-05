using ListaExercicios05.Ex07;

namespace Exercicios05.Ex07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Vendedor vendedor = new Vendedor();
            vendedor.salarioBase = 1000;
            vendedor.totalVendas = 120;
            vendedor.comissao = 20;
            Console.WriteLine($"Salário: {vendedor.CalcularSalario()}");
        }
    }
}