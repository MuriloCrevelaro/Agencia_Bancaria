namespace ExerciciosMetodoConstrutor
{
    public class Aluno
    {
        public string Nome = "";
        public int Nota;


        public Aluno()
        {
            Nome = "Deconhecido";
            Nota = 0;
        }
        public Aluno(string n, int no)
        {
            Nome = n;
            Nota = no;
        }
    }
}