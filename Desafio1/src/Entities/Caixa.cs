namespace Desafio1.src.Entities
{
    public class Caixa
    {
        public double CalcularValorFinal(Produto produto, int quantidade)
        {
            var valorFinal = produto.Valor * quantidade;
            double desconto;
            switch(produto.Tipo)
            {
                case 1:
                    desconto = 0.9;
                    return valorFinal * desconto;

                case 2:
                    desconto = 0.8;
                    return valorFinal * desconto;

                case 3:
                    desconto = 1;
                    if(quantidade > 5)
                    {
                        desconto = 0.9;
                    }

                    return valorFinal * desconto;
            }

            return 0;
        }
    }
}