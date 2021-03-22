using System;

namespace aula13_2203
{
    class Program
    {
        static void Main(string[] args)
        {
            Gerente g1 = new Gerente();

            g1.Matricula = 2;
            g1.Nome = "Roberto";
            g1.Idade = 31;
            g1.Salario = 1200.00;

            Console.WriteLine("-----------------------");
            Console.WriteLine("Matrícula: " + g1.Matricula);
            Console.WriteLine("Nome: " + g1.Nome);
            Console.WriteLine("Idade: " + g1.Idade);
            Console.WriteLine("Salário Total: R$ " + g1.MostrarSalario());

            Supervisor s1 = new Supervisor();

            s1.Matricula = 3;
            s1.Nome = "João";
            s1.Idade = 27;
            s1.Salario = 2500.00;

            Console.WriteLine("-----------------------");
            Console.WriteLine("Matrícula: " + s1.Matricula);
            Console.WriteLine("Nome: " + s1.Nome);
            Console.WriteLine("Idade: " + s1.Idade);
            Console.WriteLine("Salário Total: R$ " + s1.MostrarSalario());

            Vendedor v1 = new Vendedor();

            v1.Matricula = 4;
            v1.Nome = "Arthur";
            v1.Idade = 18;
            v1.Salario = 800.00;

            Console.WriteLine("-----------------------");
            Console.WriteLine("Matrícula: " + v1.Matricula);
            Console.WriteLine("Nome: " + v1.Nome);
            Console.WriteLine("Idade: " + v1.Idade);
            Console.WriteLine("Salário Total: R$ " + v1.MostrarSalario());
        }
    }
}
