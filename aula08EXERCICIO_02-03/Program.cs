using System;

namespace aula08EXERCICIO_02_03
{
    class Program
    {
        static void Main(string[] args)
        {
            Funcionario f1 = new Funcionario("Carlos Silva", 5300);
            Funcionario f2 = new Funcionario("Ana Marques", 2400);

            double m = f1.SalarioMedio(f1.Salario, f2.Salario); 

            Console.WriteLine("A media dos salarios: $ "+m.ToString("F2")); 
            Console.WriteLine("Salário 1: $ "+f1.Salario);
            Console.WriteLine("Salário 2: $ "+f2.Salario);
        }
    }
}
