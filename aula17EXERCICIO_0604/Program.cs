using System;
using System.Collections.Generic;

namespace aula17EXERCICIO_0604
{
    class Program
    {
        static void Main(string[] args)
        {
            Pessoa p1 = new Pessoa("Eric", "eric@gmail.com", 601);
            Pessoa p2 = new Pessoa("Sidney", "sid@gmail.com", 602);
            Pessoa p3 = new Pessoa("Maria", "maria@gmail.com", 603);
            Pessoa p4 = new Pessoa("Jenifer", "jenifer@gmail.com", 604);

            List<Pessoa> lista = new List<Pessoa>();

            lista.Add(p1);
            lista.Add(p2);
            lista.Add(p3);
            lista.Add(p4);

            foreach(Pessoa people in lista)
            {
                Console.WriteLine("---------------------------");
                Console.WriteLine("Aluguel: ");
                Console.WriteLine("Nome: " + people.Nome);
                Console.WriteLine("Email: "+ people.Email);
                Console.WriteLine("Quarto: " + people.Quarto);
            }
                //quartos ocupados
                Console.WriteLine("---------------------------");
                Console.WriteLine("Quartos ocupados:");
                Console.WriteLine(p1.Quarto + ": " + p1.Nome + ", " + p1.Email);
                Console.WriteLine(p2.Quarto + ": " + p2.Nome + ", " + p2.Email);
                Console.WriteLine(p3.Quarto + ": " + p3.Nome + ", " + p3.Email);
                Console.WriteLine(p4.Quarto + ": " + p4.Nome + ", " + p4.Email);

                Console.WriteLine("---------------------------");
                Pessoa result = lista.Find(objeto => objeto[0] == 'M');
        }
    }
}
