int opcao = -1;

Console.WriteLine("-------------------------------------------------------");
Console.WriteLine("                  Bem Vindo, Usuário");
Console.WriteLine("-------------------------------------------------------");

Console.WriteLine("Escolha uma opção no menu abaixo:");
Console.WriteLine("");
Console.WriteLine("1) Exercicio 1");
Console.WriteLine("2) Exercicio 2");
Console.WriteLine("3) Exercicio 3");
Console.WriteLine("4) Exercicio 4");
Console.WriteLine("5) Exercicio 5");
Console.WriteLine("6) Exercicio 6");
Console.WriteLine("0) Sair");
opcao = int.Parse(Console.ReadLine());
do
{

    switch (opcao)
    {
        case 0:
            Console.WriteLine("Você escolheu sair. Obrigado por usar nosso programa.");
            break;
        case 1:
            exercicio1();
            break;
        case 2:
            exercicio2();
            break;
        case 3:
            exercicio3();
            break;
        case 4:
            exercicio4();
            break;
        case 5:
            exercicio5();
            break;
        case 6:
            exercicio6();
            break;
        default:
            Console.WriteLine("Exercicio invalido");
            break;
    }

} while (opcao != 0);
void exercicio1()
{
    int salario, gastos;


    Console.WriteLine("Qual o seu salario");
    salario = int.Parse(Console.ReadLine());

    Console.WriteLine("Qual o valor dos gastos");
    gastos = int.Parse(Console.ReadLine());

    if (salario >= gastos)
    {
        Console.WriteLine("Gastos dentro do orçamento");
    }
    else
    {
    Console.WriteLine("Orçamento estourado");
    }

}

void exercicio2()
{
        int N1, N2;

    Console.WriteLine("quantos gols fez o primeiro time");
    N1 = int.Parse(Console.ReadLine());

    Console.WriteLine("quantos gols fez o segundo time");
    N2 = int.Parse(Console.ReadLine());


    if (N1 > N2)
    {
        Console.WriteLine("O 1º time ganhou");
    }
    else if (N1 < N2)
    {
        Console.WriteLine("O 2º time ganhou");
    }
    else
    {
        Console.WriteLine("Nenhum time ganhou. Deu empate");
    }
}

void exercicio3()
{
        int l1, l2, l3;

    Console.WriteLine("Qual a 1º medida do triângulo");
    l1 = int.Parse(Console.ReadLine());

    Console.WriteLine("Qual a 2º medida do triângulo");
    l2 = int.Parse(Console.ReadLine());

    Console.WriteLine("Qual a 3º medida do triângulo");
    l3 = int.Parse(Console.ReadLine());

    if (l1 == l2 && l1 == l3)
    {
        Console.WriteLine("É um triângulo Equilátero");
    }
    else if (l2 == l3)
    {
        Console.WriteLine("É um triângulo Equilátero");
    }
    else if (l1 == l2 || l1 == l3)
    {
        Console.WriteLine("É um triângulo Isóscele");
    }
    else if (l1 != l2 && l1 != l3)
    {
        Console.WriteLine("É um triângulo Escaleno");
    }
    else
    {
        Console.WriteLine("É um triângulo Escaleno");
    }
}
void exercicio4()
{
        int senha = 1234;
    int N;

    Console.WriteLine("----------------------------------------------------------");
    Console.WriteLine("Digite a senha");
    N = int.Parse(Console.ReadLine());

    if (N == senha)
    {
        Console.WriteLine("----------------------------------------------------------");
        Console.WriteLine("ACESSO PERMITIDO");
    }
    else
    {
        Console.WriteLine("----------------------------------------------------------");
        Console.WriteLine("ACESSO NEGADO");
    }

}
void exercicio5()
{
        double N,total;

    Console.WriteLine("Quantas maçãs deseja comprar");
    N = double.Parse(Console.ReadLine());

    if (N >= 12)
    {
        total = N * 0.25;
        Console.WriteLine("Cada maçã será R$0,25");
        Console.WriteLine($"O valor total é de R${total}");
    }
    else
    {
        total = N * 0.30;
        Console.WriteLine("Cada maçã será R$0,30");
        Console.WriteLine($"O valor total é de R${total}");
    }
}
void exercicio6()
{
    int frequencia;
    int nota;

    Console.WriteLine("Qual a frequencia do aluno?");
    frequencia = int.Parse(Console.ReadLine());


    if(frequencia < 75)
    {
        Console.WriteLine("O aluno está reprovado por conta da frequencia");
    }
    else
    {
        Console.WriteLine("Qual a média do aluno?");
        nota = int.Parse(Console.ReadLine());

        if (nota <= 7 && nota >= 3)
        {
            Console.WriteLine("O aluno pode fazer uma prova de recuperação para melhorar a nota");
        }
        else if (nota > 7)
        {
            Console.WriteLine("Ótimo, o aluno tem uma nota boa e boa frequencia");
        }
        else
        {
                Console.WriteLine("Está de recuparação");
        }
    }
}








/*
Console.Clear();//limpa tela
Console.WriteLine($"Digite seu nome:");//pede o nome do usuário
string nomeUsuario = Console.ReadLine();//guarda o nome na variável
Cumprimento(nomeUsuario);//chama a função e passa o nome

int opcao = -1;

do
{//todo o programa aqui dentro
//desenha um menu de opções
Console.WriteLine("Escolha uma opção no menu abaixo:");
Console.WriteLine(" 1 - Coxinha");
Console.WriteLine(" 2 - Pastel");
Console.WriteLine(" 3 - Caldo de Cana");
Console.WriteLine(" 4 - Bolo de Chocolate");
Console.WriteLine(" 0 - Sair");
//captura a opção do usuário
opcao = int.Parse(Console.ReadLine());

//escolhe a opção indicada pelo usuário
switch (opcao)
{
case 1:
Console.WriteLine($"Você escolheu a opção 1 - Coxinha {opcao * 2}");
break;
case 2:
Console.WriteLine($"Você escolheu a opção 2 - Pastel");
break;
case 3:
Saudacao();
Console.WriteLine($"Você escolheu a opção 3 - Caldo de Cana");
break;

case 4:
Console.WriteLine($"Você escolheu a opção 4 - Bolo de Chocolate");
break;
case 0:
Console.WriteLine($"Você escolheu sair - Obrigado por usar o programa");
break;
default:
Console.WriteLine($"Não temos esta opção {opcao} !!");
break;
}

} while (opcao != 0);

Console.Clear();
Console.WriteLine($"FIM DO PROGRAMA");



// tipoDeDado Nome (parâmetros){corpo}

void Saudacao()
{
Console.WriteLine("Olá, Meu amigo :)");
}

void Cumprimento(string n)
{
    Console.WriteLine($"Olá, {n}");
}*/