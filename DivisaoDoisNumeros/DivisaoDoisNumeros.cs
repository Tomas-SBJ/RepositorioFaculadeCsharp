using System;

namespace DivisaoDoisNumeros
{
    public static class DivisaoDoisNumeros
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


            if (num2 == 0)
            {
                throw new ArgumentException("Seu segundo não pode ser 0.");
            }

            resultado = num1 / num2;

            Console.WriteLine("Resultado da sua divisão: " + resultado);
        }
    }
}
