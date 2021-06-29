using System;
using Desafio3.src.Entities;

namespace Desafio3
{
    class Program
    {
        static void Main(string[] args)
        {
            COFINS cofins = new COFINS();
            ICMS icms = new ICMS();
            IPI ipi = new IPI();

            Console.Write("Digite um valor:");
            var valor = double.Parse(Console.ReadLine());

            var valorCofins = cofins.CalcularImposto(valor);
            var valorIcms = icms.CalcularImposto(valor);
            var valorIpi = ipi.CalcularImposto(valor);

            var total = valor + valorCofins + valorIcms + valorIpi;

            Console.WriteLine($"ICMS: {valorIcms}");
            Console.WriteLine($"IPI: {valorIpi}");
            Console.WriteLine($"COFINS: {valorCofins}");
            Console.WriteLine($"Valor Final: {total}");

        }
    }
}
