namespace aula17_0604
{
    public class Funcionario
    {
        public string Nome { get; set; }
        public int Horas { get; set; }
        public double Valor { get; set; }
        public Funcionario(string nome, int horas, double valor)
        {
            Nome = nome;
            Horas = horas;
            Valor = valor;
        }

        public double Pagamento(){
            return (Valor * Horas);
        }
    }
}