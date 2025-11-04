namespace ExerciciosMetodoConstrutor
{
    public class Pessoa
    {
        public string Nome = "";
        public int Idade;


        public Pessoa()
        {
            Nome = "Desconhecido";
            Idade = 0;
        }
        public Pessoa(string n)
        {
            Nome = n;
            Idade = 0;
        }
        public Pessoa(string n, int i)
        {
            Nome = n;
            Idade = i;
        }
    }
}