namespace aula14_2303
{
    public class Capa
    {
        
        public string Cor { get; set; }
        public string Material { get; set; }
        public double Valor { get; set; }

        public Capa(string cor, string material, double valor)
        {
            Cor = cor;
            Material = material;
            Valor = valor;
        }
    }
}