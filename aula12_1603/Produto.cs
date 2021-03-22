namespace aula12_1603
{
    public class Produto    //classe mãe
    {
        
        public string Nome { get; set; }
        public double Preco { get; set; }
        
        public virtual string PrecoEtiqueta()
        {
            return ("Nome: " + Nome + " Preço:  R$ " + Preco.ToString("F2"));
        }

    }
}