namespace Exercicio2
{
    public class Contrato : IImprimivel
    {
        public string Contratante = "";
        public string PrestadorServiso = "";
        public string TextoClausulas = "";

        public Contrato(string contratante, string contrada ,string txtClausulas)
        {
            Contratante = contratante;
            PrestadorServiso = contrada;
            TextoClausulas = txtClausulas;
        }

        public void Imprimir()
        {
            System.Console.WriteLine($@"Partes:
                Constante: {Contratante}
                Contratada: {PrestadorServiso}
                Claúsulas do contrato: 
                    :{TextoClausulas}
                    --");;
        }
    }
}