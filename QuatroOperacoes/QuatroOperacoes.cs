using System;

namespace QuatroOperacoes
{
    public static class QuatroOperacoes
    {
        static void Main(string[] args)
        {
            int num1;
            int num2;
            int resultadoSoma;
            int resultadoSubtracao;
            int resultadoMultiplicacao;
            double resultadoDivisao;

            Console.WriteLine("Digite seu primeiro número:");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digite seu segundo número:");
            num2 = Convert.ToInt32(Console.ReadLine());

            resultadoSoma = num1 + num2;
            resultadoSubtracao = num1 - num2;
            resultadoMultiplicacao = num1 * num2;

            Console.WriteLine("Resultado da soma: " + resultadoSoma);
            Console.WriteLine("Resultado da subtração: " + resultadoSubtracao);
            Console.WriteLine("Resultado da multiplicação: " + resultadoMultiplicacao);

            if (num2 == 0)
            {
                Console.WriteLine("Número 0 inválido para divisão");
            }
            else
            {
                resultadoDivisao = (double)num1 / num2;
                Console.WriteLine("Resultado da divisão: " + resultadoDivisao);
            }
        }
    }
}