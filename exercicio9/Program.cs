
/* 7) Crie um menu de console igual ao exibido abaixo, utilizando a estrutra switch do c#:

-------------------------------------------------------
        Bem Vindo, Usuário
-------------------------------------------------------


Escolha uma opção no menu abaixo:

   1) Opção 1
   2) Opção 2
   3) Opção 3
   0) Sair

O programa deve exibir uma mensagem informando a opção que o usuário escolheu ou uma mensagem de opção Inválida. 
 altere o exercício anterior para que cada opção escolhida pelo usuário
 seja respondida por uma função, ou seja, cada opção deve dar um Console.WriteLine() da opção escolhida. 
 */

int escolha;


Console.WriteLine("-------------------------------------------------------");
Console.WriteLine("                  Bem Vindo, Usuário");
Console.WriteLine("-------------------------------------------------------");

Console.WriteLine("Escolha uma opção no menu abaixo:");
Console.WriteLine("");
Console.WriteLine("1) Opção 1");
Console.WriteLine("2) Opção 2");
Console.WriteLine("3) Opção 3");
Console.WriteLine("0) Sair");
escolha = int.Parse(Console.ReadLine());


switch (escolha)
{
    case 1:
        Console.WriteLine("Você escolheu a opção 1");
        break;
    case 2:
        Console.WriteLine("Você escolheu a opção 2");
        break;
    case 3:
        Console.WriteLine("Você escolheu a opção 3");
        break;
    case 0:
        Console.WriteLine("Você escolheu a sair");
        break;
    default:
        Console.WriteLine("Essa opção está invalida");
        break;
}


