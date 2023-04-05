namespace Exercicios05.Ex01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Retangulo retangulo = new Retangulo();

            retangulo.altura = 12;
            retangulo.largura = 12;
            retangulo.comprimento = 12;

            Console.WriteLine($"O volume deste retangulo é: {retangulo.volume}");
        }
    }
}