using System;

namespace CalculoRetangulo // Note: actual namespace depends on the project name.
{
     class Program
    {
        static void Main(string[] args)
        {
            Retangulo retangulo = new Retangulo();

            Console.WriteLine("Entre a largura e altura do retângulo:");
            retangulo.Largura=double.Parse(Console.ReadLine());
            retangulo.Altura=double.Parse(Console.ReadLine());
            Console.WriteLine("Area = " + retangulo.Area().ToString("F2"));
            Console.WriteLine("Perímetro = " + retangulo.Perimetro().ToString("F2"));
            Console.WriteLine("Diagonal = " + retangulo.Diagonal().ToString("F2"));
        }
    }
}