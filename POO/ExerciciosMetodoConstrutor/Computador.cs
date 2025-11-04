namespace ExerciciosMetodoConstrutor
{
    public class Computador
    {
        public string marca = "";
        public int memoriaRam;
        public int armazenamento;



        public Computador()
        {
            marca = "Desconhecida";
            memoriaRam = 0;
            armazenamento = 0;
        }
        public Computador(string m, int me, int a)
        {
            marca = m;
            memoriaRam = me;
            armazenamento = a;
        }
    }
}