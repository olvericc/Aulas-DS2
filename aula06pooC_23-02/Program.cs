using System;

namespace aula06pooC_23_02
{
    class Program
    {
        static void Main(string[] args)
        {
            Aluno A1 = new Aluno(102030, "Eric", 7.5 , 8.0);

            Console.WriteLine("Aluno: " + A1.Nome);
            Console.WriteLine("Matrícula: " + A1.Matricula);  

            Aluno A2 = new Aluno();

            Console.WriteLine("Digite sua matrícula: ");
            A2.Matricula = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite seu nome: ");
            A2.Nome = Console.ReadLine(); 
            Console.WriteLine("Digite a sua primeira nota: ");
            A2.Nota1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite a sua segunda nota");
            A2.Nota2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Aluno: " + A2.Nome);
            Console.WriteLine("Matrícula: " + A2.Matricula); 
            
            double m = A1.media(A1.Nota1, A2.Nota2);

            Console.WriteLine("Media aluno numero 1: " + m); 
            m = A2.media(A2.Nota1, A2.Nota2);  

            Console.WriteLine("Media aluno numero 2: " + m);           

        }
    }
}
