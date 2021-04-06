using System;
using System.Collections.Generic;

namespace aula17_0604
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Funcionario> lista = new List<Funcionario>();
            
            Funcionario f1 = new Funcionario("Roberval", 8, 125.00);
            Funcionario f2 = new Funcionario("Claudia", 12, 500.00);
            Funcionario f3 = new Funcionario("Fernando", 6, 75.00);
            Funcionario f4 = new Funcionario("Maria", 4, 50.00);

            lista.Add(f1);
            lista.Add(f2);
            lista.Add(f3);
            lista.Add(f4);

            foreach(Funcionario func in lista){
                Console.WriteLine("-------------------------------");
                Console.WriteLine("Nome do funcionário: " + func.Nome);
                Console.WriteLine("Horas trabalhadas: " + func.Horas);
                Console.WriteLine("Valor por hora: " + func.Valor);
                Console.WriteLine("-------------------------------");
                Console.WriteLine("Pagamento: " + func.Pagamento().ToString("C"));
            }

            
        }
    }
}
