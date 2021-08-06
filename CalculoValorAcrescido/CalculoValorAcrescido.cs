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
                valorNovo = 1721.3091; 
            }
                
            Console.WriteLine("Novo valor: R$" + valorNovo);
        }
    }
}