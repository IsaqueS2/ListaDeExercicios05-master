

namespace ListaExercicios05.Ex07
{
    internal class Vendedor
    {
        public double salarioBase { get; set; }
        public int totalVendas { get; set; }
        public double comissao { get; set; }

        public double CalcularSalario()
        {
            return salarioBase + (totalVendas * (comissao / 100));
        }
    }
}