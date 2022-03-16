using System;

namespace AlunoOO // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
           Aluno aluno = new Aluno();

            
            Console.WriteLine("Nome do aluno: ");
            aluno.Nome = Console.ReadLine();    
            Console.WriteLine("Digite as três notas do aluno:");
            aluno.Nota1 =double.Parse( Console.ReadLine());
            aluno.Nota2 =double.Parse( Console.ReadLine());
            aluno.Nota3 =double.Parse( Console.ReadLine());
            aluno.VerificaMedia();
        }
    }
}