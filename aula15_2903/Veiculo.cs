using System;
namespace aula15_2903
{
    public class Veiculo
    {
        
        public string Marcas { get; set; }
        public string Modelo { get; set; }
        public string Cor { get; set; }
        public double Valor { get; set; }
        public Veiculo(string marcas, string modelo, string cor, double valor)
        {
            Marcas = marcas;
            Modelo = modelo;
            Cor = cor;
            Valor = valor;
        }
    }
}