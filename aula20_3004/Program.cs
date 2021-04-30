using System;
using System.Collections.Generic;

namespace aula20_3004
{
    class Program
    {
        static void Main(string[] args)
        {
            Pessoa p1 = new Pessoa("Maria", 18);
            Pessoa p2 = new Pessoa("Roberto", 21);
            Pessoa p3 = new Pessoa("Henrique", 24);
            Pessoa p4 = new Pessoa("Carolina", 19);

            /*
                Outro jeito de criar lista

                static List<Pessoa>pessoas

                static void Main(string[] args)
                {
                    pessoas.Add(new Pessoa("Maria", 18));
                    pessoas.Add(new Pessoa("Roberto", 21));
                    pessoas.Add(new Pessoa("Henrque", 24));
                    pessoas.Add(new Pessoa("Carolina", 19));
                }
            */

            List<Pessoa> list = new List<Pessoa>();

            list.Add(p1);
            list.Add(p2);
            list.Add(p3);
            list.Add(p4);

            foreach (Pessoa dados in list)
            {
                Console.WriteLine("Nome: "+ dados.Nome);
                Console.WriteLine("Idade: " + dados.Idade);
            }

            //usar o dotnet build para compilar e verificar os erros existentes.

            list.foreach (delegate(Pessoa dados in list))
            {
                
            }

        }
    }
}
