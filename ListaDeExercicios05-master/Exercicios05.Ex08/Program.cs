﻿namespace Exercicios05.Ex08
{
    internal class Program
    {
        static void Main(string[] args)
        {
            LataDeOleo lataOleo = new LataDeOleo();
            lataOleo.altura = 7;
            lataOleo.raio = 1;
            Console.WriteLine($"Volume: + {lataOleo.CalcularVolume()}");
        }
    }
}