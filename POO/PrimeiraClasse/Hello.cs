
namespace PrimeiraClasse
{
    public class Hello
    {
        //Propriedades/Caracteristicas - Variaveis internas dessas classes
        public string TextoHello = "";

        //Métodos - Ações e comportamentos
        public void SaldarUsuario()
        {
            Console.WriteLine(this.TextoHello); // O this é um acessor, ele referencia a própria classe
        }

        public void SaldarComNome(String n)
        {
            Console.WriteLine($"Olá {n}");
        }

    }
}