namespace PrimeiraClasse
{

    public class Moto
    {
        //Propriedades
        public int qtdRodas;
        public string Marca = "";
        public string Modelo = "";
        public string Cor = "";

        //Métodos
        public void Ligar()
        {
            Console.WriteLine("Vrum, Vrum ...");
        }
        public void Acelerar()
        {
            Console.WriteLine("Vruuuuuuuuuuuum, tu tu tu tu");
        }
        public void Desligar()
        {
            Console.WriteLine("Desligando moto");
        }
        
    }
}