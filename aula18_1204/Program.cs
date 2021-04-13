using System;
using System.Collections.Generic;

namespace aula18_1204
{
    class Program
    {
        static void Main(string[] args)
        {
            //atribuindo valores aos objetos.
            Turma ds2 = new Turma(1234, 102030, "Eric", "Lopes", 7.5, 8.5, 9.0);
            Turma db = new Turma(4321, 302010, "Gabriel", "Silva", 9.8, 7.0, 8.5);
            Turma tcc = new Turma(5678, 908070, "João", "Dias", 7.0,6.5,7.9);
            Turma dsm = new Turma(0987, 708060, "Humberto", "Freitas", 6.0, 7.5,8.4);

            //adicioar o using System.Collections.Generic;
            List<Turma> list = new List<Turma>();

            //criando as listas respectivas
            list.Add(ds2);
            list.Add(db);
            list.Add(tcc);
            list.Add(dsm);

            //usamos o foreach para visualização da lista
            //mostrando todos os dados da lista...
            
            /*
            foreach (Turma dados in list)
            {
                Console.WriteLine("Nome do aluno: " + dados.AlunoNome);
                Console.WriteLine("Sobrenome do aluno: " + dados.AlunoSobrenome);
                Console.WriteLine("Número da disciplina: " + dados.Numero);
                Console.WriteLine("Matrícula do aluno: " + dados.MatriculaAluno);
                Console.WriteLine("Notas: " + "1 - " + dados.Nota1);
                Console.WriteLine("Notas: " + "2 - " + dados.Nota2);
                Console.WriteLine("Notas: " + "3 - " + dados.Nota3);
                Console.WriteLine("-------------------------------");
            }
            */

            /*
            list.RemoveAll(dados => dados.MatriculaAluno == 708060);
            //removendo aluno com matricula -> 708060
            foreach (Turma dados in list)
            {
                Console.WriteLine("Nome do aluno: " + dados.AlunoNome);
                Console.WriteLine("Sobrenome do aluno: " + dados.AlunoSobrenome);
                Console.WriteLine("Número da disciplina: " + dados.Numero);
                Console.WriteLine("Matrícula do aluno: " + dados.MatriculaAluno);
                Console.WriteLine("Notas: " + "1 - " + dados.Nota1);
                Console.WriteLine("Notas: " + "2 - " + dados.Nota2);
                Console.WriteLine("Notas: " + "3 - " + dados.Nota3);
                Console.WriteLine("-------------------------------");
            }
            */

            //mostrando apenas nome e notas dos alunos
            /*
            foreach (Turma dados in list)
            {
                Console.WriteLine("Nome do aluno: " + dados.AlunoNome);
                Console.WriteLine("Notas: " + "1 - " + dados.Nota1);
                Console.WriteLine("Notas: " + "2 - " + dados.Nota2);
                Console.WriteLine("Notas: " + "3 - " + dados.Nota3);
                Console.WriteLine("Média do aluno: "+dados.Media().ToString("F1"));
                Console.WriteLine("-------------------------------");
            }
            */

            //mostrando um aluno específico e calculando a média dele  
            /*  
            Turma x = list.Find(obj => obj.MatriculaAluno == 102030);

            Console.WriteLine("O aluno " + x.AlunoNome + " obeteve a média: " + x.Media().ToString("F2"));
            */

            //mostrar o aluno de uma turma específica usando o número
            List<Turma> list2 = list.FindAll(obj => obj.Numero == 1234);

            foreach (Turma dados in list2)
            {
                Console.WriteLine("Nome do aluno: " + dados.AlunoNome);
                Console.WriteLine("Sobrenome do aluno: " + dados.AlunoSobrenome);
                Console.WriteLine("Número da disciplina: " + dados.Numero);
                Console.WriteLine("Matrícula do aluno: " + dados.MatriculaAluno);
                Console.WriteLine("Notas: " + "1 - " + dados.Nota1);
                Console.WriteLine("Notas: " + "2 - " + dados.Nota2);
                Console.WriteLine("Notas: " + "3 - " + dados.Nota3);
                Console.WriteLine("Média do aluno: "+dados.Media().ToString("F1"));
                Console.WriteLine("-------------------------------");
            }

        }
    }
}
