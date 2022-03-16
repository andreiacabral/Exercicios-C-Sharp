using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculoRetangulo
{
    public class Retangulo
    {
        public double Largura { get; set; }
        public double Altura { get; set; }

        public double Area()
        {
            return Largura*Altura;
        }

        public double Perimetro()
        {
            return (Altura+Largura)*2;
        }

        public double Diagonal()
        {
            return Math.Sqrt((Altura*Altura)+(Largura*Largura));
        }
    }
}
