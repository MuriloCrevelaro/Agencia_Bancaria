using ClassesEObjetos;

// Garrafa c1 = new Garrafa();

// Console.Write($"Marca da garrafa:");
// c1.Marca = Console.ReadLine();
// Console.WriteLine($"-------------------------------------------------------");
// Console.Write($"Cor da garrafa:");
// c1.Cor = Console.ReadLine();
// Console.WriteLine($"-------------------------------------------------------");
// Console.Write($"Quantos mililitros(ml):");
// c1.qtdMilitros = int.Parse(Console.ReadLine());
// Console.WriteLine($"-------------------------------------------------------");

// c1.AbrirBoca();
// Thread.Sleep(3000);
// c1.Bebendo();
// Thread.Sleep(3000);
// c1.FecharBoca();
// Thread.Sleep(3000);

// Console.WriteLine($"---------------------------{c1.Marca}----------------------------");
// Console.Write($"Modelo da garrafa: {c1.Marca}");
// Console.WriteLine();
// Console.Write($"Tipo de boca: {c1.TipoBocas}");
// Console.WriteLine();
// Console.Write($"Cor: {c1.Cor}");
// Console.WriteLine();
// Console.Write($"Quantos mililitros(ml) cabem? {c1.qtdMilitros}");
// Console.WriteLine();
// Console.WriteLine($"-------------------------------------------------------");


// //Pessoa
// Pessoa joao = new Pessoa();

// joao.Nome = "Joao Silva";
// Console.WriteLine($"{joao.Nome} tem {joao.Idade} anos");
// int novaIdade = joao.Envelhecer(17); //Atualiza e devolve idade
// Console.WriteLine($"{joao.Nome} tem {joao.Idade} anos");
// novaIdade = joao.Envelhecer(-50);
// Console.WriteLine($"{joao.Nome} tem {joao.Idade} anos");


// //Agência Bancária
// AgênciaBancária c1 = new AgênciaBancária();

// Console.Clear();
// Console.WriteLine($"-------------------------------------------------------");
// Console.WriteLine("Qual o saldo que deseja colocar");
// c1.saldo = double.Parse(Console.ReadLine());
// Console.WriteLine($"Saldo atual: {c1.saldo}");
// Console.WriteLine($"-------------------------------------------------------");
// Console.WriteLine("Qual o seu titular");
// c1.titular = Console.ReadLine();
// Console.WriteLine($"Titular atua: {c1.titular}");
// Console.WriteLine($"-------------------------------------------------------");
// if (c1.titular == "Depositar")
// {
//     Console.WriteLine("Qual o valor que deseja depositar:");
//     c1.valor = double.Parse(Console.ReadLine());
//     Console.WriteLine($"Valor depositado: {c1.saldo}");
//     Console.WriteLine($"Valor atual: {c1.Depositar()}");
// }
// else if (c1.titular == "Sacar")
// {
//     Console.WriteLine("Qual o valor que deseja sacar:");
//     c1.valor = double.Parse(Console.ReadLine());

//     if (c1.valor > c1.saldo)
//     {
//         Console.WriteLine("Desculpe, você está tentando sacar mais dinheiro do que tem na conta, tente um valor menor.");
//     }
//     else{        
//         Console.WriteLine($"Valor sacado: {c1.valor:F2}");
//         Console.WriteLine($"Valor atual: {c1.Sacar()}");
//     }
// }
// else
// {
//     Console.WriteLine("Opção invalida tente 'Depositar' ou 'Sacar'");
// }



//Produto com desconto
ProdutoComDesconto c1 = new ProdutoComDesconto();

Console.Clear();
Console.WriteLine($"-------------------------------------------------------");
Console.WriteLine("Qual o nome do produto");
c1.nome = Console.ReadLine();
Console.WriteLine($"-------------------------------------------------------");
Console.WriteLine($"Qual o preco de {c1.nome}");
c1.preco = double.Parse(Console.ReadLine());
Console.WriteLine($"-------------------------------------------------------");
Console.WriteLine($"Qual o percentual de desconto de {c1.nome}");
c1.percentual = double.Parse(Console.ReadLine());
Console.WriteLine($"-------------------------------------------------------");
if (c1.percentual > 100)
{
    Console.WriteLine("Não pode aver um percentual de desconto maior do que 100");
}
Console.WriteLine($"-------------------------------------------------------");
Console.WriteLine($"O novo valor de {c1.nome} é {c1.AplicarDesconto():F2}");
