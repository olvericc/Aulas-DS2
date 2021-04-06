namespace aula08_02_03
{
    public class Pessoa
    {
        public Pessoa(string nome, int idade)
        {
            Nome = nome;
            Idade = idade;

        }
        public string Nome { get; set; }
        public int Idade { get; set; }

        public Pessoa Maisvelho(Pessoa id1, Pessoa id2)
        {

            if(id1.Idade>id2.Idade)
            {
                return id1;
            }
            else
            {
                return id2;
            }
        }
    }
}