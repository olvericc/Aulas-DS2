namespace aula13_2203
{
    public class Gerente : Funcionario  //classe filha
    {
        public Gerente()
        {
            Comissao = 1000;
        }
        public double Comissao { get; set; }

        public override double MostrarSalario()
        {
            return Salario + Comissao;
        }
    }
}