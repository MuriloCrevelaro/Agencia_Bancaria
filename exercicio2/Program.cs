/*  Desenvolva um programa que recebe do usuário, o placar de um jogo de futebol (os gols de cada time)
 e informa se o resultado foi um empate, se a vitória foi do primeiro time ou do segundo time. */

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