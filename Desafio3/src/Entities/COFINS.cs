using Desafio3.src.interfaces;

namespace Desafio3.src.Entities
{
    public class COFINS : IImposto
    {
        public double CalcularImposto(double valor)
        {
            double imposto = 0;

            if(17000 < valor)
            {
                imposto = 0.08;
            }

            return valor * imposto;
        }
    }
}