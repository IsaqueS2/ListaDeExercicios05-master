using ListaExercicios05.Ex03;

namespace Exercicios05.Ex03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Cilindro cilindro = new Cilindro();
            cilindro.raio = 3;
            cilindro.altura = 2;

            Console.WriteLine($"Volume Cilindro: {cilindro.CalcularVolume()}");
        }
    }
}