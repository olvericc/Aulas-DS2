namespace aula13_2203
{
    public class Funcionario    //classe mãe
    {
        
        public int Matricula { get; set; }
        public string Nome { get; set; }
        public int Idade { get; set; }
        public double Salario { get; set; }
    
        public virtual string MostrarDados()    //mostra os dados
        {
            return ("Matrícula: " + Matricula + "Nome: " + Nome + "Idade: " + Idade);
        }

        public virtual double MostrarSalario()  //mostra os salários
        {
            return Salario;
        }
    }
}