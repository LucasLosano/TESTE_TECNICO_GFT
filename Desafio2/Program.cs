using System;
using System.Collections.Generic;

namespace Desafio2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<double> valores = new List<double>();

            while(valores.Count != 10)
            {
                Console.Write("Digite um número: ");
                int valorEntrada = int.Parse(Console.ReadLine());

                if(!valores.Contains(valorEntrada))
                {
                    valores.Add(valorEntrada);
                } 
                else
                {
                    Console.WriteLine("Este número já foi utilizado.");
                }
            }

            valores.Sort();

            double  maiorNumero = valores[valores.Count-1];
            double  menorNumero = valores[0];

            List<double> maioresQueDez = new List<double>();
            List<double> maioresQueCinquenta = new List<double>();
            double soma = 0;

            foreach(var valor in valores)
            {
                if(valor > 50)
                {
                    maioresQueCinquenta.Add(valor);
                    maioresQueDez.Add(valor);
                }
                else if(valor > 10)
                {
                     maioresQueDez.Add(valor);
                }

                soma += valor;
            }

            double media = soma / valores.Count;

            Console.WriteLine("O maior número é " + maiorNumero);
            Console.WriteLine("O menor número é " + menorNumero);
            Console.WriteLine("A média aritmética é " + media);
            Console.WriteLine("Quantos números são acima de 10: " + maioresQueDez.Count + " e quais são eles " + printList(maioresQueDez));
            Console.WriteLine("Quantos números são acima de 50: " + maioresQueCinquenta.Count + " e quais são eles " + printList(maioresQueCinquenta));
        }

        public static string printList(List<double> lista)
        {
            string retorno = "";
            foreach(var item in lista)
            {
                retorno += item + " ";
            }

            return retorno;
        }
    }
}
