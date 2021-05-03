using System;

namespace aula21_0305
{
    class Program
    {
        static void Main(string[] args)
        {
            //aula de array 03/05/2021

            //tamanho definido
            /*
            int[] array1 = new int[5] {1, 3, 7, 12, 8};
            */  

            //tamanho dinâmico
            /*
            int[] array2 = {1, 3, 2, 7, 6};
            */

            //example
            /*
            int[] arrayEx = new int[50];  //defini um limite de 50
            
            for(int i = 0; i < 50; i++)     //Loop de 0 a 49, com incremento i++
            {
                arrayEx[i] = i + 1;         //inserindo dados no array 
            } 
            Console.WriteLine(arrayEx[10]); 
            */

            //Itarações

            //int[] arrayA = new int[10];

            //FOR - icrementa no início
            
            /*
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(arrayA[i]);
            }
            */

            //WHILE - icrementa no final (loop infinito)
            
            /*
            int i = 0;
            while(i < 10)
            {
                Console.WriteLine(arrayA[i]);
            }
            */

            //FOREACH - icrementa do início ao fim

            /*
            foreach(int x in arrayA)
            {
                Console.WriteLine(x);
            }
            */

            //Exemplo de Fixação n1
            
            /*
            string[] pilotos = new string[4]{"Ayrton Senna", "Michael Schumacher",
            "Lewis Hamilton", "Alain Prost"};

            // 0 - Ayrton
            // 1 - Michael
            // 2 - Lewis
            // 3 - Alain

            Console.WriteLine(pilotos[3]);  //imprimindo a ultima linha do array
            Console.WriteLine();            //imprimindo linha em branco

            pilotos[3] = "Rubens Barrichello";  //substituindo o Alain Prost por Rubens Barrichello
            
            foreach(string piloto in pilotos)
            {
                Console.WriteLine(piloto);
            }
            */

            //Exemplo Fixação n2 (questão 4)

            int[] arrayCalc = new int[4];

            arrayCalc[0] = 1 + 0;
            arrayCalc[1] = 3 - 1;
            arrayCalc[2] = 3 * 1;
            arrayCalc[3] = 8 / 2;

            foreach(int calculos in arrayCalc)
            {
                Console.WriteLine(calculos);
            }
        }
    }
}
