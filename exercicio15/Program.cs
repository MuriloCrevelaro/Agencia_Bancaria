/* Faça um progama que receba 4 notas de um aluno e imprima a média aritmética das notas e a mensagem de APROVADO 
para média superior ou igual a 7,0, RECUPERAÇÃO entre 5,0 e 7,0 ou a mensagem de REPROVADO para média infrior a 5,0*/

double N1, N2, N3, N4;

Console.WriteLine("------------------------------------------");
Console.WriteLine("Qual a primeira nota do aluno");
N1 = double.Parse(Console.ReadLine());

Console.WriteLine("------------------------------------------");
Console.WriteLine("Qual a segunda nota do aluno");
N2 = double.Parse(Console.ReadLine());

Console.WriteLine("------------------------------------------");
Console.WriteLine("Qual a terceira nota do aluno");
N3 = double.Parse(Console.ReadLine());

Console.WriteLine("------------------------------------------");
Console.WriteLine("Qual a quarta nota do aluno");
N4 = double.Parse(Console.ReadLine());

Console.WriteLine("------------------------------------------");
double media = (N1 + N2 + N3 + N4) / 4;

Console.WriteLine("------------------------------------------");
Console.WriteLine($"Valor da média do aluno é {media}");
Console.WriteLine("------------------------------------------");
if (media >= 7)
{
    Console.WriteLine("O aluno está APROVADO");
    Console.WriteLine($"Nota:{media}");
}
else if (7 < media && media > 5)
{
    Console.WriteLine("O está de RECUPERAÇÃO");
    Console.WriteLine($"Nota:{media}");
}
else
{
    Console.WriteLine("O aluno está REPROVADO");
    Console.WriteLine($"Nota:{media}");
}


