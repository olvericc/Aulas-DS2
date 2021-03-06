namespace aula06pooC_23_02
{
    public class Aluno
    {
        
        public Aluno(int matricula, string nome, double nota1, double nota2)
        {
            Matricula = matricula;
            Nome = nome;
            Nota1 = nota1;
            Nota2 = nota2;

        }
        public Aluno()
        {
            
        }
        public int Matricula { get; set; }
        public string Nome { get; set; }
        public double Nota1 { get; set; }
        public double Nota2 { get; set; }

        public double media(double x, double y){
            double valor;
            
            valor = (x+y)/2;

            return valor;
        }
    }
}