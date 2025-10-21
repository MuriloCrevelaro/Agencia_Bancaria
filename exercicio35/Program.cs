// See https://aka.ms/new-console-template for more information
int n = 0, contador = 0,n1 = 0, n2 = 0;

Console.WriteLine("Digite o número de repetições");
n = int.Parse(Console.ReadLine());

while (contador < n )
{
    Console.WriteLine("Digite o primeiro número");
    n1 = int.Parse(Console.ReadLine());
    Console.WriteLine("Digite o segundo numero:");
    n2 = int.Parse(Console.ReadLine());

    if (n1 > n2)
    {
        Console.WriteLine($"O {n1} é maior que {n2}");
    }
    else if (n1 < n2)
    {
        Console.WriteLine($"O {n2} é maior que {n1}");
    }
    else
    {
        Console.WriteLine($"O {n2} e {n1} são iguais");
    }
    contador++;
}




