using System;

namespace Desafio4
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int valor = random.Next(0,11);
            int palpite;
            while(true)
            {
                Console.Write("Digite um número de 0 a 10: ");
                palpite = int.Parse(Console.ReadLine());

                if(palpite == valor)
                    break;

                Console.WriteLine("Você errou ... Tente novamente.");
            }

            Console.WriteLine("Parabéns, você acertou!");
        }
    }
}
