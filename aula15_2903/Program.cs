using System;

namespace aula15_2903
{
    class Program
    {
        static void Main(string[] args)
        {
            Veiculo v1 = new Veiculo("Ford", "Ka", "preta", 28000.00);
            Veiculo v2 = new Veiculo("Chevrolet", "Onix", "cinza", 35000.00);

            Locacao loc1 = new Locacao(v1, 1, "29/03/2021", "Eric");
            Locacao loc2 = new Locacao(v2, 2, "30/03/2021", "Brunin");

            Console.WriteLine("\n Nome do cliente: " + loc1.Nome_cliente);
            Console.WriteLine("\n Data da locação: "+loc1.Data_Loc);
            Console.WriteLine("\n Modelo do veículo: "+v1.Modelo);
            Console.WriteLine("\n Cor do veículo: "+v1.Cor);
            Console.WriteLine("Calculando a quantidade de dias: "+loc1.Data_Loc+" o valor da diária do carro: "+v1.Valor);

        }
    }
}
