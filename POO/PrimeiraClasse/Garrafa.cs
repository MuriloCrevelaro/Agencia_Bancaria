namespace PrimeiraClasse
{
    public class Garrafa
    {
        //Propriedades
        public int qtdMilitros;
        public string Cor = "";
        public string Marca = "";

        //Metodos`
        public void AbrirBoca()
        {
            Console.WriteLine("Abrindo garrafa");
        }
        public void Bebendo()
        {
            Console.WriteLine("Bebendo aguá");
        }
        public void FecharBoca()
        {
            Console.WriteLine("Fechando garrafa");
        }
    }
}