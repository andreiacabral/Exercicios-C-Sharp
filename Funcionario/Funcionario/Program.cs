using System;

namespace FuncionarioOO // Note: actual namespace depends on the project name.
{
     class Program
    {
        static void Main(string[] args)
        {
             Funcionario funcionario = new Funcionario();
            
            Console.Write("Nome: ");
            funcionario.Nome =Console.ReadLine();
            Console.Write("Salarío Bruto: ");
            funcionario.SalarioBruto = double.Parse(Console.ReadLine());
            Console.Write("Imposto: ");
            funcionario.Imposto = double.Parse(Console.ReadLine());
           
            Console.WriteLine("Funcionario: " + funcionario.Nome +", $ "+funcionario.SalarioLiquido().ToString("F2"));
            
            Console.WriteLine("Digite a porcentagem para aumentar o salário: ");
            double porcentagem = double.Parse(Console.ReadLine());

            Console.WriteLine("Dados do atualizados: " +funcionario.Nome +", $ "+funcionario.AumentarSalario(porcentagem).ToString("F2"));

        }
    }
}