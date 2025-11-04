// Personalização de Garrafas - Classe Garrafa
// Crie uma classe que represente uma garrafa com pelo menos 3 propriedades e 2 métodos.
// Peça ao usuário para informar os dados para personalizar a garrafa e preencha as propriedades do objeto
// Peça também o nome do usuário e ao final exiba o nome do usuário e as informações da garrafa personalizada
//  e a execução dos dois métodos

namespace ClassesEObjetos
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