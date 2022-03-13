using SalarioMedio;
using System;

namespace SalarioMedio // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Funcionario funcionario1, funcionario2;

            funcionario1 = new Funcionario();
            funcionario2 = new Funcionario();
          

            Console.WriteLine("Dados do primeiro funcionário:");
            Console.Write("Nome: ");
            funcionario1.Nome=Console.ReadLine();
            Console.Write("Salario: ");
            funcionario1.Salario= double.Parse(Console.ReadLine());

            Console.WriteLine("Dados do segundo funcionário: ");
            Console.Write("Nome: ");
            funcionario2.Nome=Console.ReadLine();
            Console.Write("Salario: ");
            funcionario2.Salario= double.Parse(Console.ReadLine());

            Console.WriteLine("Salário médio = " +(funcionario1.Salario+funcionario2.Salario)/2);
            




        }
    }
}