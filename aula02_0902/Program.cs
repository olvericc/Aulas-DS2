using System;

namespace aula02
{
    class Program
    {
        static void Main(string[] args)
        {
            //aula 02(09/02/21)

            Console.WriteLine("Hello World!");

            //Exemplo split
            /*
            string frase = Console.ReadLine();
            string x = Console.ReadLine();
            string y = Console.ReadLine();
            string z = Console.ReadLine();

            string[] v = frase.Split(' ');
            string palavra1 = v[0];
            string palavra2 = v[1];
            string palavra3 = v[2];

            Console.WriteLine("Você digitou: ");
            Console.WriteLine(frase);
            Console.WriteLine(x);
            Console.WriteLine(y);
            Console.WriteLine(z);

            Console.WriteLine(palavra1);
            Console.WriteLine(palavra2);
            Console.WriteLine(palavra3);
            */
            
            //Exercício de fixação
            
            string nome;
            int quartos; 
            double valor;

            Console.WriteLine("Entre com o seu nome completo: ");
            nome = Console.ReadLine();

            Console.WriteLine("Quantos quartos tem em sua casa? ");
            quartos = int.Parse(Console.ReadLine());

            Console.WriteLine("Entre com o preço do produto: ");
            valor = double.Parse(Console.ReadLine());

            Console.WriteLine(nome);
            Console.WriteLine(quartos);
            Console.WriteLine(valor.ToString("F2"));
        }
    }
}
