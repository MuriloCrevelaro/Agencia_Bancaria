namespace Exercicio2
{
    public class Fatura : IImprimivel
    {
        public int DiasDeAtraso;
        public string Devedor = "";
        public string Credor = "";
        public float Valor;
        private float Juros = 0.10f;

        public Fatura(string dev, string cred, float valFat, int qtdAtraso)
        {
            Devedor = dev;
            Credor = cred;
            Valor = valFat;
            DiasDeAtraso = qtdAtraso;
        }

        public void Imprimir()
        {
            CalcularValorDivida();
            System.Console.WriteLine($@"Credor: {Credor}
            Devedor: {Devedor}
            Dias de atraso: {DiasDeAtraso} dias
            Jusros: R${(Juros * DiasDeAtraso):F2}
            Total de juros: R${Valor:F2}");
        }
        public void CalcularValorDivida()
        {
            if(DiasDeAtraso > 0)
            {
                Valor = Valor + DiasDeAtraso * Juros;
            }
            if(DiasDeAtraso >= 5)
            {
                System.Console.WriteLine($"Dívida encaminhada para o SERASA");
            }
        }
    }
}