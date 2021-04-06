namespace aula07_01_03
{
    public class Produto
    {
        
        public string Nome { get; set; }
        public double Preco { get; set; }
        public int Quantidade { get; set; }
        public Produto(string nome, double preco, int quantidade)
        {
            Nome = nome;
            Preco = preco;
            Quantidade = quantidade;

        }

        public void Adicionar(int qtd)
        {
            Quantidade += qtd;
        }

        public void Remover(int qtd)
        {
            Quantidade -= qtd;
        }

        public double ValorTotal()
        {
            return Quantidade*Preco;
        }
    }

}