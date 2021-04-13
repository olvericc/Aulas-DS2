namespace aula18_1204
{
    public class Turma
    {
        public Turma(int numero, int matriculaAluno, string alunoNome, string alunoSobrenome, double nota1, double nota2, double nota3)
        {
            Numero = numero;
            MatriculaAluno = matriculaAluno;
            AlunoNome = alunoNome;
            AlunoSobrenome = alunoSobrenome;
            Nota1 = nota1;
            Nota2 = nota2;
            Nota3 = nota3;
        }
        public int Numero { get; set; }
        public int MatriculaAluno { get; set; }
        public string AlunoNome { get; set; }
        public string AlunoSobrenome { get; set; }
        public double Nota1 { get; set; }
        public double Nota2 { get; set; }
        public double Nota3 { get; set; }

        public double Media()
        {
            double m;
            m = (Nota1 + Nota2 + Nota3) / 3;
            return m;
        }


    }
}