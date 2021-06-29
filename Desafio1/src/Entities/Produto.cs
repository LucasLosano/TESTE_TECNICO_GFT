namespace Desafio1.src.Entities
{
    public class Produto
    {
        public string Nome { get; set; }
        public double Valor { get; set; }
        public int Tipo { get; set; }

        public Produto(string nome, double valor, int tipo)
        {
            this.Nome = nome;
            this.Valor = valor;
            this.Tipo = tipo;
        }
    }
}