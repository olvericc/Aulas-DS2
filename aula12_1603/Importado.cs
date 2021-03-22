namespace aula12_1603
{
    public class Importado : Produto    //classe filha
    {
       public double TaxaImportacao { get; set; }

       public override string PrecoEtiqueta()
        {
            return ("Nome: " + Nome + " (usado)" + " Preço: R$ " + PrecoTotal().ToString("F2") + " Taxa de Importação " + TaxaImportacao);
        }

        public double PrecoTotal()
        {
            return Preco + TaxaImportacao;
        }
    }
}