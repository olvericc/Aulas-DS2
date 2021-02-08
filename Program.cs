using System;

namespace Primeiro_Projeto
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            
            //Exemplo 1

            double a;
            double b;
            
            a = 5.1;
            b = (float)a;

            Console.WriteLine(b);
            Console.Write("");
            Console.WriteLine("teste1");
            Console.Write("teste2");
            Console.WriteLine("");

            //Exemplo 2

            double saldo = 10.35784;
            //com todas casas decimais
            Console.WriteLine("valor: "+saldo);
            //com duas casas decimais
            Console.WriteLine("valor: "+saldo.ToString("F2"));
            //com uma casa decimal
            Console.WriteLine("valor: "+saldo.ToString("F1"));

            //Exemplo 3

            int idade =  32;
            String nome = "Eric";
            double valor = 10.85684;

            //método 1
            Console.WriteLine("{0} tem {1} anos e tem valor igual a {2:F2} reais", nome, idade, valor);
            //método 2
            Console.WriteLine($"{nome} tem {idade} e tem valor igual a {valor:F2} reais");
            //método 3
            Console.WriteLine(nome + " tem " + idade + " anos e tem valor igual a " + valor.ToString ("F2") + " reais");
            Console.WriteLine("--------------------------------------------------------------------");
            //Exercício de fixação

            string produto1 = "Computador";
            string produto2 = "Celular";

            byte anos = 30;
            int codigo = 587475;
            char genero = 'M';

            double preco1 = 2100.0;
            double preco2 = 760.0;
            double medida = 53.484943;

            //saida de dados 1
            Console.WriteLine("Produtos: ");
            Console.WriteLine(produto1 + ", cujo preço é $ " + preco1);
            Console.WriteLine(produto2 + ", cujo preço é $ " + preco2);

            Console.WriteLine();

            Console.WriteLine($"Registro: {anos} anos de idade, código: {codigo} e gênero: {genero} ");

            Console.WriteLine();

            Console.WriteLine($"Medida com oito casas decimais:  {medida} ");
            Console.WriteLine($"Arrendondando (três casas decimais):  {medida:F3}");
            Console.WriteLine($"Separador decimal invariant culture: {medida:F2}");
        }
    }
}
