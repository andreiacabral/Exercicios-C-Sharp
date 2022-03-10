using System;
using System.Globalization;

namespace ExercicioTriangulo // Note: actual namespace depends on the project name.
{
    internal class Program
    {

        static void Main(string[] args)
        {
            Triangulo triangulo1, triangulo2;
            triangulo1 = new Triangulo();
            triangulo2 = new Triangulo();

            Console.WriteLine("Entre com as medidas do triangulo X:");
            triangulo1.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            triangulo1.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            triangulo1.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Entre com as medidas do triangulo Y:");
            triangulo2.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            triangulo2.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            triangulo2.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            triangulo1.Perimetro = triangulo1.RetornaPerimetro(triangulo1.A, triangulo1.B, triangulo1.C);
            triangulo1.Area= triangulo1.RetornaArea(triangulo1.Perimetro,triangulo1.A,triangulo1.B,triangulo1.C);

            triangulo2.Perimetro= triangulo2.RetornaPerimetro(triangulo2.A,triangulo2.B,triangulo2.C);
            triangulo2.Area = triangulo2.RetornaArea(triangulo2.Perimetro,triangulo2.A, triangulo2.B, triangulo2.C);

            Console.WriteLine("Área de triangulo 1 = " + triangulo1.Area.ToString("F4", CultureInfo.InvariantCulture));
            Console.WriteLine("Área de triangulo 2  = " + triangulo2.Area.ToString("F4", CultureInfo.InvariantCulture));

            if (triangulo1.Area > triangulo2.Area)
            {
                Console.WriteLine("Maior area: triangulo 1");
            }
            else
            {
                Console.WriteLine("Maior área: triangulo 2");
            }
        }


    }
}