using System;

namespace MediaAritmetica
{
    public static class MediaAritmetica
    {
        static void Main(string[] args)
        {
            double nota1;
            double nota2;
            double nota3;
            double nota4;
            double media;
            string sexo;

            Console.WriteLine("Informe seu sexo (M ou F):");
            sexo = Console.ReadLine().ToUpper();
            ValidarSexo(sexo);

            Console.WriteLine("Informe sua primeira nota (0 à 100):");
            nota1 = Convert.ToDouble(Console.ReadLine());
            ValidarNota(nota1);

            Console.WriteLine("Informe sua segunda nota (0 à 100):");
            nota2 = Convert.ToDouble(Console.ReadLine());
            ValidarNota(nota2);

            Console.WriteLine("Informe sua terceira nota (0 à 100):");
            nota3 = Convert.ToDouble(Console.ReadLine());
            ValidarNota(nota3);

            Console.WriteLine("Informe sua quarta nota (0 à 100):");
            nota4 = Convert.ToDouble(Console.ReadLine());
            ValidarNota(nota4);

            media = (nota1 + nota2 + nota3 + nota4) / 4;

            if (sexo.Equals("M"))
            {
                if (media >= 70)
                {
                    Console.WriteLine("Caro aluno, você foi aprovado. Média: " + media);
                }
                else
                {
                    Console.WriteLine("Caro aluno, você foi reprovado. Média: " + media);
                }
            }
            else
            {
                if (media >= 70)
                {
                    Console.WriteLine("Cara aluna, você foi aprovada. Média: " + media);
                }
                else
                {
                    Console.WriteLine("Cara aluna, você foi reprovada. Média: " + media);
                }
            }
        }

        private static void ValidarNota(double nota)
        {
            if (nota > 100 || nota < 0)
            {
                throw new ArgumentException("Nota inserida inválida.");
            }
        }

        private static void ValidarSexo(string sexo)
        {
            if (!sexo.Equals("M") && !sexo.Equals("F"))
            {
                throw new ArgumentException("Sexo inválido. Digite M ou F");
            }
        }
    }
}