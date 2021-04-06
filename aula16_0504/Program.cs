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

            //ADD//

            Console.WriteLine("--------------");
            lista.Add("Maria");
            lista.Add("Alex");
            lista.Add("Bob");
            lista.Add("Anna");
            lista.Add("Sidney");

            //mostrando no console
            
            foreach(string objeto in lista)
            {
                Console.WriteLine(objeto);
            }

            //inserir na lista
            /*
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
            
            //mostra o index que tem letra A

            int resultado4 = lista.FindIndex(objeto => objeto[0] == 'A');
            Console.WriteLine("--------------");
            Console.WriteLine("Nome encontrado na casa: "+ resultado4);

            //mostra o index que tem a última letra A

            int resultado5 = lista.FindLastIndex(objeto => objeto[0] == 'A');
            Console.WriteLine("--------------");
            Console.WriteLine("Último com letra A: "+ resultado5);
            Console.WriteLine("--------------");
            */
            //Busca composta

            /*
            List<string> lista2 = lista.FindAll(objeto => objeto.Length < 5);
            foreach(string resultado in lista2){             
                Console.WriteLine(resultado);
            }
            */

            //REMOVE//

            //Remove apenas um

            /*
            lista.Remove("Sidney");
            Console.WriteLine("------------------");
            foreach(string objeto in lista){
                Console.WriteLine(objeto); 
            }
            */

            //Remove todos enquanto... (length => tamanho)

            /*
            lista.RemoveAll(objeto => objeto.Length == 6);
            Console.WriteLine("------------------");
            */

            //Remove de acordo com a casa

            /*
            lista.RemoveAt(3);
            Console.WriteLine("------------------");
            foreach(string objeto in lista){
                Console.WriteLine(objeto);
            }
            */

            //Remove mais de uma casa

            /*
            lista.RemoveRange(1, 3);
            Console.WriteLine("------------------");
            foreach(string objeto in lista){
                Console.WriteLine(objeto);
            }
            */   
        }
    }
}
