namespace Exercicio2
{
    public class Relatorio : IImprimivel
    {
        public string Dono = "";
        public string TextRelatorio = "";
        public Relatorio(string responsavel, string txtRelatorio)
        {
            Dono = responsavel;
            TextRelatorio = txtRelatorio;
        }
        public void Imprimir()
        {
            System.Console.WriteLine($@"Responsavel: {Dono}
            Texto do relatorio: {TextRelatorio}
            --");
        }
    }
}