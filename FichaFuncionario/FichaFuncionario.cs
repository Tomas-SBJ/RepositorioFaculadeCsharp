using System;

namespace FichaFuncionario
{
    public static class FichaFuncionario
    {
        static void Main(string[] args)
        {
            string nome;
            double horasTrabalhadas;
            int dependetes;
            double valorHora = 32.00;
            double valorDependente = 40.00;
            double inss;
            double ir;
            double salarioLiquido;
            double salarioBruto;

            Console.WriteLine("Digite seu nome:");
            nome = Console.ReadLine();
            Console.WriteLine("Digite a quantidade de horas trabalhadas:");
            horasTrabalhadas = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Digite a quantidade de dependentes:");
            dependetes = Convert.ToInt32(Console.ReadLine());

            salarioBruto = (horasTrabalhadas * valorHora) + (valorDependente * dependetes);
            inss = salarioBruto * 0.085;
            ir = salarioBruto * 0.05;
            salarioLiquido = salarioBruto - inss - ir;

            Console.WriteLine("Boa tarde " + nome);
            Console.WriteLine("Salario bruto: " + salarioBruto);
            Console.WriteLine("Desconto do INSS: " + inss);
            Console.WriteLine("Desconto do IR: " + ir);
            Console.WriteLine("Salario liquido: " + salarioLiquido);
        }
    }
}