using System;

namespace aula08_02_03
{
    class Program
    {
        static void Main(string[] args)
        {
            Pessoa p1 = new Pessoa("Sidney Silva", 28);
            Pessoa p2 = new Pessoa("Ana Maria", 38);

            Pessoa vivido = p1.Maisvelho(p1, p2);

            Console.WriteLine("A pessoa mais velha é: "+vivido.Nome+" com idade: "+vivido.Idade);
        }
    }
}
