using Exemplos;

//1
// /* Criar uma classe ControleRemoto, implementar os métods e propriedades da interface.
//    Criar um objeto controleTV e testar os métodos*/


// ControleRemoto controleTV = new ControleRemoto();
// controleTV.Ligar();
// controleTV.NivelVolume = 50;
// controleTV.AumentarVolume();
// System.Console.WriteLine($"Nivel do volume: {controleTV.NivelVolume}");
// controleTV.DiminuairVolume();
// System.Console.WriteLine($"Nivel do volume: {controleTV.NivelVolume}");
// controleTV.Desligar();
// Thread.Sleep(2000);





/*Crie uma interface IMotor com o Método:
    void Acelerar();
    Crie as classes Carro e Moto que implemente a interface.
    Depois, crie um objeto da classe Carro e rode o método Acelerar*/

Carro c1 = new Carro();
c1.Acelerar();
Moto m1 = new Moto();
m1.Acelerar();