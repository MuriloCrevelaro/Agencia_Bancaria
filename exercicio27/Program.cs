// See https://aka.ms/new-console-template for more information
int Q, N;


Console.WriteLine("Quantos números você quer digitar");
Q = int.Parse(Console.ReadLine());


int i = 0 ;
while ( Q > i)
{
    Console.WriteLine("Digite um numero");
    N = int.Parse(Console.ReadLine());
    Thread.Sleep(2000);
    if (N % 2 == 0)
    {
        Console.WriteLine(N + " - É um número par");
        Console.WriteLine("----------------------------------------");
    }
    else
    {
        Console.WriteLine("Tente um número par");
        Console.WriteLine("----------------------------------------");
    }
    i++;
}