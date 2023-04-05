using ListaExercicios05.Ex06;

namespace Exercicios05.Ex06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Temperatura temperatura = new Temperatura();
            temperatura.grausCelsius = 0;
            Console.WriteLine($"Graus Fahrenheit: {temperatura.ConverterGraus()}");
        }
    }
}