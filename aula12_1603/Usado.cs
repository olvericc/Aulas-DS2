namespace aula12_1603
{
    public class Usado : Produto    //classe filha
    {
        public int AnoFabricacao { get; set; }

        public override string PrecoEtiqueta()
        {
            return ("Nome: " + Nome + " (usado)" +  " Preço: R$ " + Preco.ToString("F2") + " Ano de Fabricação: " + AnoFabricacao);
        }
    }
}