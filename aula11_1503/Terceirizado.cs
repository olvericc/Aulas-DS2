namespace aula12_1603
{
    public class Terceirizado : Funcionario //classe filha
    {
        
        public double Adicional { get; set; }

        public override double pagamento()  //override => sobrescrever o método.
        {
            double add = (Adicional*110)/100;
            return (Horas * ValorPorHora) + add;
        }
    }
}