using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioTriangulo
{
    public class Triangulo
    {
        public double A { get; set; }
        public double B { get; set; }
        public double C { get; set; }

        public double Perimetro { get; set; }
        public double Area { get; set; }

        public double RetornaPerimetro(double A,double B, double C)
        {
            return (A + B + C) / 2;
        }

        public double RetornaArea(double P, double A, double B, double C)
        {
            return Math.Sqrt(P * (P - A) * (P - B) * (P - C));
        }
    }
}
