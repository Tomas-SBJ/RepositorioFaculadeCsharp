using System;

namespace CalculoIdade
{
    public static class CalculoIdade
    {
        static void Main(string[] args)
        {
            int anoNascimento;
            int anoAtual = DateTime.Now.Year;
            int idade;

            Console.WriteLine("Digite seu ano de nascimento:");
            anoNascimento = Convert.ToInt32(Console.ReadLine());

            if (anoNascimento > anoAtual)
            {
                throw new ArgumentException("Ano de nascimento inválido.");
            }

            idade = anoAtual - anoNascimento;

            Console.WriteLine("Sua idade aproximada: " + idade);
        }
    }
}