namespace ExerciciosMetodoConstrutor
{
    public class Funcionario()
    {
        public string nome = "";
        public string cargo = "";
        public int salario;



        public Funcionario()
        {
            nome = "Desconhecido";
            cargo = "Desconhecido";
            salario = 0;
        }
        public Funcionario(string n, string c)
        {
            nome = "Desconhecido";
            cargo = "Desconhecido";
            salario = 0;
        }
    }
}