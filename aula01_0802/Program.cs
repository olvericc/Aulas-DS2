using System;

namespace Primeiro_Projeto
{
    class Program
    {
        static void Main(string[] args)
        {   
            //aula 01(08/02/21)

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

            //Exercício de Fixação 08-02-21 

            string produto1 = "Computador";
            string produto2 = "Mesa de Escritório";

            byte anos = 30;
            int codigo = 5290;
            char genero = 'M';

            double preco1 = 2100.0;
            double preco2 = 650.0;
            double medida = 53.234567;

            Console.WriteLine("Produtos: ");
            Console.WriteLine(produto1 + ", cujo o preço é $ " + preco1.ToString("F2"));
            Console.WriteLine(produto2 + ", cujo o preço é $ " + preco2.ToString("F2"));
            Console.WriteLine("Registro: " + anos + " anos de idade, código: " + codigo + "e gênero: " + genero);
            Console.WriteLine("Medidas com oito casas decimais: " + medida.ToString("F8"));
            Console.WriteLine("Arrendodamento (três casas decimais): " + medida.ToString("F3"));

        }
    }
}