namespace aula14_2303
{
    public class Celular
    {
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public string Cor { get; set; }
        public double Valor { get; set; }
        public Capa Capa { get; set; }  //objeto Capa

        public Celular(string marca, string modelo, string cor, double valor, Capa capa)
        {
            Marca = marca;
            Modelo = modelo;
            Cor = cor;
            Valor = valor;
            Capa = capa;
        }

        public double ValorTotal()
        {
            return (Valor + Capa.Valor);
        }
    }
}