namespace Exemplos
{
    public class ControleRemoto : IControle
    {
        public int NivelVolume;

        public void AumentarVolume()
        {
            if(NivelVolume > 100)
            {
                System.Console.WriteLine($"Atingiu o nivel maximo do volume: {NivelVolume}");
            }else
            {
            NivelVolume++;                
            }
        }

        public void Desligar()
        {
            System.Console.WriteLine($"Desligando o controle");
        }

        public void DiminuairVolume()
        {
            if(NivelVolume <= 0)
            {
                System.Console.WriteLine($"Atingiu o nivel minimo do volume: {NivelVolume}");
            }else{
                NivelVolume--;
            }
        }

        public void Ligar()
        {
            System.Console.WriteLine($"Ligando o controle");
        }
    }
}