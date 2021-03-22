namespace aula12_1603
{
    public class Funcionario    //classe mãe
    {
        public string Nome { get; set; }
        public int Horas { get; set; }
        public double ValorPorHora { get; set; }

        public Funcionario()
        {
           
        }

        public virtual double pagamento()
        {
            return Horas * ValorPorHora;
        }
    }
}