using System;

namespace aula24._2805_lista_
{
    class Program
    {
        static void Main(string[] args)
        {
          
            //Questão 1 - Elabore um algoritmo que calcule a idade média de 5 alunos.
           
            /*
            Double IdadeN1 = 0, IdadeN2 = 0, IdadeN3 = 0, IdadeN4 = 0, IdadeN5 = 0;
            Double CalcMedia = 0;

            //Inserindo valores para calcular a média dos alunos

            Console.WriteLine("Calcule a média das idades dos alunos: ");
            Console.WriteLine("-------------------------------------");
            Console.WriteLine("Insira a idade do aluno 1: "); 
            IdadeN1 = Double.Parse(Console.ReadLine());
            Console.WriteLine("Insira a idade do aluno 2: "); 
            IdadeN2 = Double.Parse(Console.ReadLine());
            Console.WriteLine("Insira a idade do aluno 3: "); 
            IdadeN3 = Double.Parse(Console.ReadLine());
            Console.WriteLine("Insira a idade do aluno 4: "); 
            IdadeN4 = Double.Parse(Console.ReadLine());
            Console.WriteLine("Insira a idade do aluno 5: "); 
            IdadeN5 = Double.Parse(Console.ReadLine());

            //Calculando a média
            
            CalcMedia = (IdadeN1 + IdadeN2 + IdadeN3 + IdadeN4 + IdadeN5) / 5;

            //Mostrando a média

            Console.WriteLine("A média das idades dos alunos é: " + CalcMedia);
            Console.ReadKey();
            */

            //Questão 2 - Crie um algoritmo que verifique se um número informado é par ou impar
            
            /*
            int Numero = 0;
            int Calculo = 0;

            Console.WriteLine("Descubra se o número é PAR ou ÍMPAR");
            Console.WriteLine("-----------------------------------");

            Console.WriteLine("Digite o um número qualquer: ");
            Numero = int.Parse(Console.ReadLine());

            //Lógica para descobrir se o número é PAR OU ÍMPAR

            Calculo = Numero % 2;

            //Estrutura de Decisão

            if (Calculo == 1)
            {
                Console.WriteLine("O número é ÍMPAR");
            }
            else
            {
                Console.WriteLine("O número é PAR");
            }
            Console.ReadKey();
            */

            //Questão 3 - Faça um algoritmo que exiba quantas pessoas possuem mais de 18 anos. O algoritmo deverá ler a idade de 10 pessoas.
            
            /*
            int Quantidade = 0;
            int Idade = 0;
            
            Console.WriteLine("Verificar se é a idade é maior que 18 anos");
            Console.WriteLine("------------------------------------------");
            int x = 0;

            while (x < 10)
            {

                x = x + 1;
                Console.WriteLine("Informe a idade: ");

                Idade = int.Parse(Console.ReadLine());

                if (Idade >= 18)
                {
                    Quantidade = Quantidade + 1;
                }
            }
            Console.WriteLine("Existem " + Quantidade + " pessoas com idade maior que 18 anos");
            Console.ReadKey();
            */

            //Questão 4 - Faça um algoritmo que calcule e exiba o salário reajustado de dez funcionários de acordo com a seguinte regra: Salário até 300, reajuste de 50%; Salários maiores que 300, reajuste de 30%.

            Double Salario = 0;
            Double Reajuste = 0;

            Console.WriteLine("Reajustando o salário");
            Console.WriteLine("---------------------");

            for(int x = 0; x < 3; x++)
            {
                Console.WriteLine("Insira o salário: ");
                Salario = D
            }

        }
    }
}
