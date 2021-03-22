namespace aula13_2203
{
    public class Supervisor : Funcionario //classe filha
    {
        public Supervisor()
        {
            Comissao = 600;
        }

        public double Comissao { get; set; }

        public override double MostrarSalario()
        {
            return Salario + Comissao;
        }
    }
}