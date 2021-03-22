namespace aula13_2203
{
    public class Vendedor : Funcionario //classe filha
    {
        public Vendedor()
        {
            Comissao = 300;
        }

        public double Comissao { get; set; }

        public override double MostrarSalario()
        {
            return Salario + Comissao;
        }
    }
}