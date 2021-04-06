namespace aula08EXERCICIO_02_03
{
    public class Funcionario
    {
        public Funcionario(string nome, double salario)
        {
            Nome = nome;
            Salario = salario;

        }
        public string Nome { get; set; }
        public double Salario { get; set; }
        
        public double SalarioMedio(double salario1, double salario2)
        {
            double media;
            media = (salario1 + salario2) / 2;
            return media;
        }
    }
}