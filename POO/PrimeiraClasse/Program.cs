using PrimeiraClasse;

//Hello
// //lEMBRANDO DE ABRIR O Hello.cs PARA ENTENDER MELHOR

// //Serve para usar a variavel criada no Hello.cs(Lembrando que, no caso, a Primeira Classe tem que estar como principal)

// string nome = "Murilo";

// //Cria um objeto do tipo Hello
// Hello cumprimento = new Hello();

// cumprimento.TextoHello = "Olá usuário";

// cumprimento.SaldarUsuario();
// //Se você fizer isso ele substitui o valor de n
// cumprimento.SaldarComNome("Murilo");



// //Carro
// //c1
//     Carro c1 = new Carro();
//     c1.Marca = "Lamburghini";
//     c1.Modelo = "Urus";
//     c1.Cor = "Verde";
//     c1.qtdPortas = 4;
//     c1.qtdRodas = 4;
//     c1.Ligar();
//     c1.Acelerar();
//     c1.Feiar();
//     c1.Desligar();

// //c2
//     Carro c2 = new Carro();
//     c2.Marca = "Chevrole";
//     c2.Modelo = "Camaro";
//     c2.Cor = "Amarelo";
//     c2.qtdPortas = 2;
//     c2.qtdRodas = 4;
//     c2.Ligar();
//     c2.Acelerar();
//     c2.Feiar();
//     c2.Desligar();

//     Console.WriteLine($"----------------------------{c1.Marca}---------------------------");
//     Console.WriteLine($"Carro: {c1.Marca}");
//     Console.WriteLine($"Modelo: {c1.Modelo}");
//     Console.WriteLine($"Cor: {c1.Cor}");
//     Console.WriteLine($"Quantidades de Portas: {c1.qtdPortas}");
//     Console.WriteLine($"Quantidades de Rodas: {c1.qtdRodas}");
//     Console.WriteLine();
//     Console.WriteLine("---");
//     Console.WriteLine();

//     Console.WriteLine();
//     Console.WriteLine("Características");
//     Console.WriteLine();

//     Console.WriteLine($"----------------------------{c2.Marca}---------------------------");
//     Console.WriteLine($"Carro: {c2.Marca}");
//     Console.WriteLine($"Modelo: {c2.Modelo}");
//     Console.WriteLine($"Cor: {c2.Cor}");
//     Console.WriteLine($"Quantidades de Portas: {c2.qtdPortas}");
//     Console.WriteLine($"Quantidades de Rodas: {c2.qtdRodas}");
//     Console.WriteLine();
//     Console.WriteLine("---");
//     Console.WriteLine();





// //Moto
// // Criar uma classe que represente uma moto, Pelo menos 4 propriedades e 3 metodos
// // na classe programa, instancia 2 objetos moto e exibir as propriedades e rodar os métodos igual fizemos com o do carro

//     Moto c1 = new Moto();
//     c1.Marca = "Yamaha";
//     c1.Modelo = "MT-03";
//     c1.Cor = "Verde";
//     c1.qtdRodas = 2;
//     c1.Ligar();
//     c1.Acelerar();
//     c1.Desligar();

//     Carro c2 = new Carro();
//     c2.Marca = "Honda";
//     c2.Modelo = "CG 160";
//     c2.Cor = "Amarelo";
//     c2.qtdRodas = 2;
//     c2.Ligar();
//     c2.Acelerar();
//     c2.Desligar();

//     Console.WriteLine($"----------------------------{c1.Marca}---------------------------");
//     Console.WriteLine($"Carro: {c1.Marca}");
//     Console.WriteLine($"Modelo: {c1.Modelo}");
//     Console.WriteLine($"Cor: {c1.Cor}");
//     Console.WriteLine($"Quantidades de Rodas: {c1.qtdRodas}");
//     Console.WriteLine();
//     Console.WriteLine("---");
//     Console.WriteLine();

//     Console.WriteLine();
//     Console.WriteLine("Características");
//     Console.WriteLine();

//     Console.WriteLine($"----------------------------{c2.Marca}---------------------------");
//     Console.WriteLine($"Carro: {c2.Marca}");
//     Console.WriteLine($"Modelo: {c2.Modelo}");
//     Console.WriteLine($"Cor: {c2.Cor}");
//     Console.WriteLine($"Quantidades de Rodas: {c2.qtdRodas}");
//     Console.WriteLine();
//     Console.WriteLine("---");
//     Console.WriteLine();




//Garrafa

//Criar uma classe para representar uma garrafa
//propriedades
//métodos


Garrafa c1 = new Garrafa();

Console.Write($"Marca da garrafa:");
c1.Marca = Console.ReadLine();
Console.WriteLine($"-------------------------------------------------------");
Console.Write($"Cor da garrafa:");
c1.Cor = Console.ReadLine();
Console.WriteLine($"-------------------------------------------------------");
Console.Write($"Quantos mililitros(ml):");
c1.qtdMilitros = int.Parse(Console.ReadLine());
Console.WriteLine($"-------------------------------------------------------");

c1.AbrirBoca();
Thread.Sleep(3000);
c1.Bebendo();
Thread.Sleep(3000);
c1.FecharBoca();
Thread.Sleep(3000);

Console.WriteLine($"-------------------------------------------------------");
Console.Write($"Modelo da garrafa: {c1.Marca}");
Console.WriteLine();
Console.Write($"Tipo de boca: {c1.TipoBocas}");
Console.WriteLine();
Console.Write($"Cor: {c1.Cor}");
Console.WriteLine();
Console.Write($"Quantos mililitros(ml) cabem? {c1.qtdMilitros}");
Console.WriteLine();
Console.WriteLine($"-------------------------------------------------------");


