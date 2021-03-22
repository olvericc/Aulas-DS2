using System;

namespace aula12_1603
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Produto p1 = new Produto();

            p1.Nome = "Notebook";
            p1.Preco = 3500.00;

            Console.WriteLine("-----------------------");
            Console.WriteLine(p1.PrecoEtiqueta()); 
            
            Usado p2 = new Usado();

            p2.Nome = "iPhone 7";
            p2.Preco = 1700.00;
            p2.AnoFabricacao = 2017;

            Console.WriteLine("-----------------------");    
            Console.WriteLine(p2.PrecoEtiqueta());

            Importado p3 = new Importado();

            p3.Nome = "Tablet";
            p3.Preco = 260.00;
            p3.TaxaImportacao = 20.00;

            Console.WriteLine("-----------------------");
            Console.WriteLine(p3.PrecoEtiqueta());  
        }
    }
}
