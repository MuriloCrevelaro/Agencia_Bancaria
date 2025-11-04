namespace MetodoConstrutor
{
    public class Pessoa
    {
        public string Nome = "";
        public int Idade;
            

        //Método COntrutor de Pessoa
        /*Parametros representam valores para as suas respectivas props, ou seja,
        estamos inicializando valores para as props nome e idade*/
        public Pessoa(string n, int i)
        {
            Nome = n; //Inicaliza o valor de n
            Idade = i; //Inicaliza o valor de i
        }

        public void ExibirDados() //   O "()" são os parametros
        {
            Console.WriteLine($"Nome: {Nome} Idade:{Idade}");
        }

    }
}