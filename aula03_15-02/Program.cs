using System;

namespace aula03
{
    class Program
    {
        static void Main(string[] args)
        {
            //Aula do dia 15/03/21
            
            /*
            int x, y, soma;

            Console.WriteLine("Digite um valor");
            x = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite um valor");
            y = int.Parse(Console.ReadLine());
            soma = x + y;
            Console.WriteLine("Soma = " + soma);
            */
            double r, A;

            Console.WriteLine("Digite o valor do raio");
            r = double.Parse(Console.ReadLine());

            A = 3.14159 * (r*r);

            
        }
    }
}
