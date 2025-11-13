namespace Exemplos
{
    public class Carro : IMotor
    {
        public void Acelerar()
        {
            System.Console.WriteLine($"Vrum, Vrum");
        }
    }
}