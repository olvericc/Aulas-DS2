using System;

namespace lista
{
    class Program
    {
        static void Main(string[] args)
        {

            //Questão 1

            /*
            1.	Faça um algoritmo que leia 10 salários. 
                Depois de lidos e armazenados, mostre o maior valor.    
                Utilize vetores.
            */

            /*
            int tam;
            Console.WriteLine("Digite o tamanho do vetor: ");
            tam = int.Parse(Console.ReadLine());

            float[] salarios = new float[tam];
            float Maior = -1;
            int cont;
            int i;
            
            for (i = 0; i < salarios.Length; i ++)
            {
                Console.WriteLine("Digite os salários: ");
                salarios[i] = float.Parse (Console.ReadLine());
            }

            for (cont = 0; cont < salarios.Length; cont ++)
            {
                Console.WriteLine(salarios[cont]);
                if (salarios[cont] >  Maior)
                {
                    Maior = salarios[cont];
                }
            }
            Console.WriteLine("Maior salário: " + Maior);
            */

            //Questão 2 

            /*
            2.	Armazene num vetor de 5 posições o salário de 5 pessoas. 
                Se o salário for menor que 1000 reais, forneça um aumento de 10% e sobrescreva o valor antigo. 
                Ao final, mostre a lista de salários atualizada.
            */
           
            /*
            float [] salarios = new float[5];
            int cont;
            float aumento = 1.1f;

            for(cont = 0; cont < salarios.Length; cont++)
            {
                Console.WriteLine("Informe o valor do salário");
                salarios[cont] = float.Parse(Console.ReadLine());
                if(salarios[cont] < 1000)
                {
                    salarios[cont] = salarios[cont] * aumento;
                }           
            }
                for (cont = 0; cont < 5; cont++)
                {
                    Console.WriteLine($"Os salários: {salarios[cont].ToString("F2")}" );
                }
            */

            //Questão 3 

            /*
            3.	Faca um programa que leia n valores reais. 
                Armazene estes valores num vetor. 
                Ao final, imprima a média aritmética destes valores. 
            */

            /*
            double[] grades = new double[3];
            double sumGrades = 0;
            double media = 0;

            for(int x = 0; x < grades.Length; x++)
            {
                Console.WriteLine($"Digite a {x + 1}ª nota: ");
                grades[x] = double.Parse(Console.ReadLine());

                sumGrades += grades[x];
            }

            media = sumGrades / grades.Length;

            Console.WriteLine($"A média aritmética das notas digitas é {media:F1}");    
            */

            //Questão 4 

            /*
            4.	Faça um programa que pergunte ao usuário o número de alunos a ser lido. 
                O tamanho dos vetores será o número informado pelo usuário. 
                Armazene num vetor as notas G1 destes alunos; num outro vetor, armazene as notas G2 destes alunos. 
                Ambas notas, G1 e G2, são informadas pelo usuário. 
                Calcule a média aritmética destes alunos e armazene num terceiro vetor. 
                Ao final, mostre as 3 notas dos alunos. 
            */

            /*
                int tam;
                Console.Writeline("Digite o tamanho do vetor: ");
                tam = int.Parse(Console.ReadLine());

                float [] G1 = new float[tam];   //vetor G1
                float [] G2 = new float[tam];   //vetor G2
                float [] Result = new float[tam];   //vetor Result
                
                for (int i = 0; i < tam; i++)
                {
                    //vetor 1
                    Console.WriteLine("G1-Digite a nota"+(i+1)+":");
                    G1[i] = float.Parse(Console.ReadLine());
                    //vetor 2
                    Console.WriteLine("G2-Digite a nota"+(i+1)+":");
                    G2[i] = float.Parse(Console.ReadLine());
                    Result[i] = (G1[i] + G2[i]) / 2;
                }
                for(int j = 0; j < tam; j++)
                {
                    Console.WriteLine("Média das notas" + Result[j]);
                }
            */

            //Questão 5

            /*
            5.	Faça um algoritmo que leia e armazene 5 valores inteiros em um vetor Vet1. 
                Leia outros 5 valores inteiros e armazene num vetor Vet2. A partir destes valores lidos, mostre na tela:

                1.	A soma dos elementos de cada vetor, nas respectivas posições
                2.	A diferença dos elementos de cada vetor, nas respectivas posições
                3.	O produto dos elementos de cada vetor, nas respectivas posições 
                4.	A divisão entre os elementos de cada vetor, nas respectivas posições 
            */

            /*
            int[] Vet1 = new int[5];
            int[] Vet2 = new int[5];
            int soma;
            int dif;
            int prod;
            int div;

            for (int i = 0; i < Vet1.Length; i++)
            {
                Console.WriteLine("Vet1 - Digite um valor:");
                Vet1[i] = int.Parse(Console.ReadLine());

                Console.WriteLine("Vet2 - Digite um valor:");
                Vet2[i] = int.Parse(Console.ReadLine());
            }
            for (int j = 0; j < Vet2.Length; j++)
            {
                soma = Vet1[j] + Vet2[j];
                Console.WriteLine("Soma: "+soma); 
                Console.WriteLine("-----------------");
                dif = Vet1[j] - Vet2[j];
                Console.WriteLine("Diferença: "+dif);
                Console.WriteLine("-----------------");
                prod = Vet1[j] * Vet2[j];
                Console.WriteLine("Produto: "+prod);
                Console.WriteLine("-----------------");
                div = Vet1[j] / Vet2[j];
                Console.WriteLine("Divisão: "+div);
                Console.WriteLine("----------------");
            }
            */
        }
    }
}
