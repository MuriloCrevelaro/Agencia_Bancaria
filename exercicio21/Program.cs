/* Faça um programa que receba 3 números inteiros e imprima na tela a somatória dos números */
double N1 = 0, N2 = 0, N3 = 0;


for (int i = 0; i < 3; i++)
{
    Console.WriteLine($"-------------------------------------------------------------");
    Console.WriteLine($"Escolha um número");
    if (i == 0)
    {
        N1 = double.Parse(Console.ReadLine());
    }
    else if (i == 1)
    {
        N2 = double.Parse(Console.ReadLine());
    }
    else if(i == 2)
    {
        N3 = double.Parse(Console.ReadLine());
    }
}

double soma = N1 + N2 + N3;

    Console.WriteLine($"-------------------------------------------------------------");
Console.WriteLine($"A soma dos números escolhidos dão: {soma}");



/*                                      OU
    int n, soma = 0;
    
    for(int i = 0; i <= 3; i++)
    {
        Console.WriteLine(Console.ReadLine());
        n = int.Parse(Console.ReadLine)
        resultado += n;
    }

        Console.WriteLine($"Somatoria total {soma}");


*/