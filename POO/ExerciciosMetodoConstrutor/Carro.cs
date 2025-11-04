namespace PrimeiraClasse
{
    public class Carro
    {
        //Propriedades
        public  String Marca = ""; // Deixamos nulo só para não dar Warning
        public String Modelo = ""; // Deixamos nulo só para não dar Warning

        public int Ano; // Deixamos nulo só para não dar Warning

        public void Dados(string Ma, string Mo, int A)
        {
            Marca = Ma;
            Modelo = Mo;
            Ano = A;

            System.Console.WriteLine(@$"Dados do carro:
                                        Marca: {Marca}
                                        Modelo: {Modelo}
                                        Ano de lancamento: {Ano}");
        }
    }
}