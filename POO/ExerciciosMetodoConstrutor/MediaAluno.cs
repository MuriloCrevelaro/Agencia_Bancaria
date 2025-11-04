namespace ExerciciosMetodoConstrutor
{
    public class MediaAluno
    {
        public string Nome = "";
        public double N1, N2, N3;



        //Construtor com parametros
        public MediaAluno()
        {
            Nome = "Desconhecido";
            N1 = N2 = N3 = 0;
        }
        public MediaAluno(double n1, double n2, double n3)
        {
            Nome = "Desconhecido";
            N1 = n1;
            N2 = n2;
            N3 = n3;
        }
        
        public void Media()
        {
            double media = (N1 + N2 + N3) / 3;
            System.Console.WriteLine($"A média do(a) {Nome} é: {media}");
        }
    }
}