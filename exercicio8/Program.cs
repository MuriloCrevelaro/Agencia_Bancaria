/* Faça uma alteração no programa acima do menu para que ele funcione em loop. Pra isso utilize o laço do while do c#. */
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
Faça uma alteração no programa acima do menu para que ele funcione em loop. Pra isso utilize o laço "do while" do c#.*/

int escolha;

Console.Clear();

do
{
    
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
            Console.WriteLine("-------------------------------------------------------");
            Console.WriteLine("Você escolheu a opção 1");
            break;
        case 2:
            Console.WriteLine("-------------------------------------------------------");
            Console.WriteLine("Você escolheu a opção 2");
            break;
        case 3:
            Console.WriteLine("-------------------------------------------------------");
            Console.WriteLine("Você escolheu a opção 3");
            break;
        case 0:
            Console.WriteLine("-------------------------------------------------------");
            Console.WriteLine("Você escolheu sair");
            Console.WriteLine("Ok. Espero que tenha aproveitado o nosso programa");
            break;
        default:
            Console.WriteLine("-------------------------------------------------------");
            Console.WriteLine("Essa opção está invalida");
            break;
    }

} while (escolha != 0);

