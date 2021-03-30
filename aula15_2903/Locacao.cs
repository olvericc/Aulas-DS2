namespace aula15_2903
{
    public class Locacao
    {
        public Locacao(Veiculo veiculo, int quantidade, string data_Loc, string nome_cliente)
        {
            Veiculo = veiculo;
            Quantidade = quantidade;
            Data_Loc = data_Loc;
            Nome_cliente = nome_cliente;

        }
        public Veiculo Veiculo { get; set; }
        public int Quantidade { get; set; }
        public string Data_Loc { get; set; }
        public string Nome_cliente { get; set; }

        public double ValorLocacao()
        {
            return (Quantidade * Veiculo.Valor);
        }
    }
}