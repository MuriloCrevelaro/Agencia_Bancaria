namespace ExerciciosMetodoConstrutor
{
    public class Produto
    {
        public string Nome = "";
        public double Preco ;
        public int Estoque;


        public void Dados()
        {
            Nome = "Desconhecido";
            Preco = 0;
            Estoque = 0;
        }
        public void Dados(string n, double p, int e)
        {
            Nome = n;
            Preco = p;
            Estoque = e;
        }
    }
}