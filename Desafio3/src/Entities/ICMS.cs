using Desafio3.src.interfaces;

namespace Desafio3.src.Entities
{
    public class ICMS : IImposto
    {
        public double CalcularImposto(double valor)
        {
            double imposto = 0.3;

            return valor * imposto;
        }
    }
}