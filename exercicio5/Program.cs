/* As maçãs custam R$ 0,30 cada se forem compradas menos do que uma dúzia, e R$ 0,25 se forem compradas pelo menos doze.
   Escreva um programa que leia o número de maçãs compradas, calcule e escreva o valor total da compra. */

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
