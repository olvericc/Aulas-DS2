using System;

namespace aula14_2303
{
    class Program
    {
        static void Main(string[] args)
        {
            Capa c1 = new Capa("azul", "silicone", 20.00);  //valor da capa c1 = 20 reais
            Capa c2 = new Capa("preta", "couro", 150.00);   //valor da capa c2 = 150 reais

            Celular cel1 = new Celular("Apple", "iPhone 12 Pro Max", "dourada", 4800.00, c2);   //atributos do celular cel1

            Celular cel2 = new Celular("Xiaomi", "Mi 11", "violeta", 2300.00, c1);              //atributos do celular cel2

            Console.WriteLine("O valor total do celular " + cel1.Marca + " com capa " + cel1.Capa.Cor
            + " de " + c1.Material + " ficou de: " + cel1.ValorTotal().ToString("C"));
            Console.WriteLine("--------------------------------------------------------------");
            Console.WriteLine("O valor total do celular " + cel2.Marca + " com capa " + cel2.Capa.Cor
            + " de " + c2.Material + " ficou de: " + cel2.ValorTotal().ToString("C"));

        }
    }
}
