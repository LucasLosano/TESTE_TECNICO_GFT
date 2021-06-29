using System;
using System.Collections.Generic;
using Desafio1.src.Entities;

namespace Desafio1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Produto> produtos = new List<Produto>(){
                new Produto(
                nome:"Banana",
                valor:0.99,
                tipo:2
            ),
                new Produto(
                nome:"Energético",
                valor:5.49,
                tipo:3
            ),
                new Produto(
                nome:"Arroz",
                valor:20,
                tipo:1
            ),
                new Produto(
                nome:"Chocolate",
                valor:4.50,
                tipo:1
            ),
                new Produto(
                nome:"Leite",
                valor:3.73,
                tipo:3
            ),
                new Produto(
                nome:"Abacaxi",
                valor:2.40,
                tipo:2
            )};

            Caixa caixa = new Caixa();
            int[] quantidades = {3, 7, 1, 12, 5, 1};
            for (int i = 0; i < produtos.Count; i++)
            {
                string nome = produtos[i].Nome;
                int quantidade = quantidades[i]; 
                double valor = caixa.CalcularValorFinal(produtos[i], quantidade);

                Console.WriteLine($"Produto:{nome} custou {valor.ToString("c")}");
            }


        }
    }
}
