using System;

namespace MultiplicacaoNumeros
{
    public static class MultiplicacaoNumeros
    {
        static void Main(string[] args)
        {
            double num1;
            double num2;
            double resultado;

            Console.WriteLine("Digite seu primeiro número:");
            num1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Digite seu segundo número:");
            num2 = Convert.ToDouble(Console.ReadLine());

            resultado = num1 * num2;

            Console.WriteLine("Resultado de sua multiplicação: " + resultado);
        }
    }
}