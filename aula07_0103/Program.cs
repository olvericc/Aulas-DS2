using System;

namespace aula07_01_03
{
    class Program
    {
        static void Main(string[] args)
        {
            
        Produto p1 = new Produto("Celular", 850, 10);

        double Vtotal = p1.ValorTotal();
        Console.WriteLine("");
        Console.WriteLine("valor total");
        Console.WriteLine("Dados do produto: " +p1.Nome);
        Console.WriteLine("Preço do produto: $ " +p1.Preco.ToString("F2"));
        Console.WriteLine("Quantidade do produto: " +p1.Quantidade+" unidades");
        Console.WriteLine("Valor total: $ "+Vtotal.ToString("F2"));       

        p1.Adicionar(5);

        Vtotal = p1.ValorTotal();
        Console.WriteLine("");
        Console.WriteLine("adicionando 5");
        Console.WriteLine("Dados do produto: " +p1.Nome);
        Console.WriteLine("Preço do produto: $ " +p1.Preco.ToString("F2"));
        Console.WriteLine("Quantidade do produto: " +p1.Quantidade+" unidades");
        Console.WriteLine("Valor total: $ "+Vtotal.ToString("F2")); 

        p1.Remover(14);

        Vtotal = p1.ValorTotal();
        Console.WriteLine("");
        Console.WriteLine("removendo 14");
        Console.WriteLine("Dados do produto: " +p1.Nome);
        Console.WriteLine("Preço do produto: $ " +p1.Preco.ToString("F2"));
        Console.WriteLine("Quantidade do produto: " +p1.Quantidade+" unidades");
        Console.WriteLine("Valor total: $ "+Vtotal.ToString("F2")); 

        }
    }
}
