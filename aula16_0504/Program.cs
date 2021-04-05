using System;
using System.Collections.Generic;
//importando biblioteca

namespace aula16_0504
{
    class Program
    {

        //Primeira Lista em C#

        static void Main(string[] args)
        {
            List<string> lista = new List<string>();
            //ADD
            Console.WriteLine("--------------");
            lista.Add("Maria");
            lista.Add("Alex");
            lista.Add("Bob");
            lista.Add("Anna");
            //mostrando no console
            /*
            foreach(string objeto in lista)
            {
                Console.WriteLine(objeto);
            }
            */
            //inserir na lista
            lista.Insert(0, "Marcos");

            foreach(string objeto in lista)
            {
                Console.WriteLine(objeto);
            }
            Console.WriteLine("--------------");
            Console.WriteLine("Quantidade de nomes: "+ lista.Count);

            //Buscas
            Console.WriteLine("--------------");

            //primeiro nome com a letra A.
            string resultado1 = lista.Find(objeto => objeto[0] == 'A');
            Console.WriteLine("Primeiro 'A': " + resultado1);
            Console.WriteLine("--------------");

            //último nome com a letra A.
            string resultado2 = lista.FindLast(objeto => objeto[0] == 'A');
            Console.WriteLine("Último 'A': " + resultado2);
            Console.WriteLine("--------------");

            //todos com letra A
            List<string> resultado3 = lista.FindAll(objeto => objeto[0] == 'A');
            
            foreach(string objeto in resultado3){
                Console.WriteLine(objeto);
            }
        }
    }
}
