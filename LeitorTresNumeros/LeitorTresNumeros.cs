using System;

namespace LeitorTresNumeros
{
    public static class LeitorTresNumeros
    {
        static void Main(string[] args)
        {
            int num1;
            int num2;
            int num3;

            Console.WriteLine("Digite seu primeiro número:");
            num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digite seu segundo número:");
            num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digite seu terceiro número:");
            num3 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Resultado da operação (V1 + V2): " + (num1 + num2));
            Console.WriteLine("Resultado da operação (V2 - V1): " + (num2 - num1));
            Console.WriteLine("Resultado da operação (V3 * V1): " + (num3 * num1));
            Console.WriteLine("Resultado da operação (V3 + V2): " + (num3 + num2));
            Console.WriteLine("Resultado da operação (V3 - V2): " + (num3 - num2));
            Console.WriteLine("Resultado da operação (V1 + V2 + V3): " + (num1 + num2 + num3));
        }
    }
}