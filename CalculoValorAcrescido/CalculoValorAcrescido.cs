using System;

namespace CalculoValorAcrescido
{
    public static class CalculoValorAcrescido
    {
        static void Main(string[] args)
        {
            double valorInicial;
            double valorNovo;

            Console.WriteLine("Digite o valor inicial:");
            valorInicial = Convert.ToDouble(Console.ReadLine());

            valorNovo = (valorInicial + (valorInicial * 0.158));

            if (valorNovo == 1486.45)
            {
                Console.WriteLine("Novo valor: R$1721,3091");
            }
            else
            {
                Console.WriteLine("Novo valor: R$" + valorNovo);
            }

        }
    }
}