using System;

namespace AreaTriangulo
{
     public static class AreaTriangulo
     {
        static void Main(string[] args)
        {
            int baseTriangulo;
            int alturaTriangulo;
            int areaTriangulo;

            Console.WriteLine("Digite o valor da base:");
            baseTriangulo = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digite o valor da altura:");
            alturaTriangulo = Convert.ToInt32(Console.ReadLine());

            areaTriangulo = (baseTriangulo * alturaTriangulo) / 2;

            Console.WriteLine("Área do triângulo: " + areaTriangulo);
        }
     }
}