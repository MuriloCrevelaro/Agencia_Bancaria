namespace PrimeiraClasse
{
    public class Carro
    {
        //Propriedades
        public int qtdRodas;
        public int qtdPortas;
        public  String Marca = ""; // Deixamos nulo só para não dar Warning
        public String Modelo = ""; // Deixamos nulo só para não dar Warning

        public String Cor = ""; // Deixamos nulo só para não dar Warning


        //Métodos
        public void Ligar()
        {
            Console.WriteLine($"Carro Ligando");
        }
        //Métodos
        public void Desligar()
        {
            Console.WriteLine($"Carro Desligando");
        }
        public void Acelerar()
        {
            Console.WriteLine($"Carro Acelerando");
        }
        public void Feiar()
        {
            Console.WriteLine($"Carro Freando");
        }
    }
}