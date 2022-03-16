namespace AlunoOO
{
    public class Aluno
    {
        public string Nome { get; set; }
        public double Nota1 { get; set; }
        public double Nota2 { get; set; }
        public double Nota3 { get; set; }

        public double CalculaMedia()
        {
            return (Nota1 + Nota2 + Nota3);
        }

        public void VerificaMedia()
        {
            double resultado = CalculaMedia();
            Console.WriteLine("NOTA FINAL = " + resultado);

            if (resultado >= 60)
            {
                Console.WriteLine("APROVADO");
            }
            else
            {
                Console.WriteLine("REPROVADO");
                Console.WriteLine("FALTARAM " + (60 - resultado).ToString("F2") + "PONTOS");
            }
        }
    }
}





