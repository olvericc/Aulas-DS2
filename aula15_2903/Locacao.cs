namespace aula15_2903
{
    public class Locacao
    {
        public Locacao(Veiculo veiculo, int dias, string data_Loc, string nome_cliente)
        {
            Veiculo = veiculo;
            Dias = dias;
            Data_Loc = data_Loc;
            Nome_cliente = nome_cliente;

        }
        public Veiculo Veiculo { get; set; }
        public int Dias { get; set; }
        public string Data_Loc { get; set; }
        public string Nome_cliente { get; set; }

        public string Dados()
        {
            return ("Cliente: " + Nome_cliente + "\nData: " + Data_Loc + "\nModelo: " + Veiculo.Modelo + 
                    "\nCor: " + Veiculo.Cor);
        }

        public double ValorLocacao()
        {
            return Dias * Veiculo.Valor;
        }
        
    }   
}