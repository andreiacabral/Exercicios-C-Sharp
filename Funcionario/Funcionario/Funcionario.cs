using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuncionarioOO
{
    public class Funcionario
    {
        public string Nome { get; set; }
        public double SalarioBruto { get; set; }
        public double Imposto { get; set; }

        public double SalarioLiquido()
        {
            return (SalarioBruto - Imposto);
        }
        public double AumentarSalario(double porcentagem)
        {
            var salarioLiquido = SalarioLiquido();
            return salarioLiquido + (SalarioBruto * (porcentagem / 100));
        }


    }


}
