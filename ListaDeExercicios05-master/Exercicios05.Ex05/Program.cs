using ListaExercicios05.Ex05;

namespace Exercicios05.Ex05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Esfera esfera = new Esfera();
            esfera.raio = 1;
            Console.WriteLine($"Volume: {esfera.CalcularVolume()}");
        }
    }
}