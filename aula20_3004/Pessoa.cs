namespace aula20_3004
{
    public class Pessoa
    {
        public string Nome { get; set; }
        public int Idade { get; set; }
        public Pessoa(string nome, int idade)
        {
            Nome = nome;
            Idade = idade;
        }
    }
}