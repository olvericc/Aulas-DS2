using System;

namespace aula12_1603
{
    class Program
    {
        static void Main(string[] args)
        {
           Funcionario f1 = new Funcionario();

           f1.Nome = "Eric Lopes";
           f1.Horas = 120;
           f1.ValorPorHora = 200;

           double pag = f1.pagamento(); 

           Console.WriteLine("----------------------------------"); 
           Console.WriteLine("Funcionário: "+f1.Nome);
           Console.WriteLine("Salário: "+pag);

           Terceirizado t1 = new Terceirizado();

           t1.Nome = "João Pedro";
           t1.Horas = 120;
           t1.ValorPorHora = 100;
           t1.Adicional = 100;

           pag = t1.pagamento();

           Console.WriteLine("----------------------------------");
           Console.WriteLine("Terceirizado: "+t1.Nome);
           Console.WriteLine("Salário: "+pag);
        }
    }
}
