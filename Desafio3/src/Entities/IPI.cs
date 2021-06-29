using Desafio3.src.interfaces;

namespace Desafio3.src.Entities
{
    public class IPI : IImposto
    {
        public double CalcularImposto(double valor)
        {
            double imposto;

            if(25000 > valor)
            {
                imposto = 0.05;
            }
            else
            {
                imposto = 0.10;
            }

            return valor * imposto;
        }
    }
}