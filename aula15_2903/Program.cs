using System;

namespace aula15_2903
{
    class Program
    {
        static void Main(string[] args)
        {
            Veiculo v1 = new Veiculo("Ford", "Ka", "preta", 50.00);
            
            Locacao loc1 = new Locacao(v1, 30, "05/04/2021", "Eric");
            
            Console.WriteLine(loc1.Dados());
            Console.WriteLine("Valor da Locação: "+loc1.ValorLocacao().ToString("C"));
        }
    }
}
