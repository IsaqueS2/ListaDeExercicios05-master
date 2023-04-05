namespace Exercicios05.Ex02
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Temperatura temperatura = new Temperatura();
            temperatura.grauFahrenheit = 32;

            Console.WriteLine("Temperatura em Celsius:" + temperatura.ConverterGraus());
        }
    }
}