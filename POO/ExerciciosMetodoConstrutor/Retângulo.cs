namespace ExerciciosMetodoConstrutor
{
    public class Retângulo
    {
        public double Largura;
        public double Altura;


        public Retângulo()
        {
            Largura = 1;
            Altura = 1;
        }
        public double Calculo(double l, double a)
        {
            Largura = l;
            Altura = a;
            return a * l;
        }
    }
}