/*  Sabemos que um aluno é aprovado caso apresente média maior ou igual a 7.0 e frequência
    maior ou igual a 75%. Na verdade, em uma situação real, se o aluno obtiver a frequência mínima
    exigida e uma média entre 3 e 7, ainda teria direito a uma última avaliação de recuperação.
    Como faríamos para resolver o problema em questão utilizando apenas estruturas de condição se-então-senão?
    Poderíamos começar avaliando a frequência do aluno, e se a mesma for menor que 75% o aluno já estaria reprovado, porém 
    caso a frequência respeite o mínimo exigido, começaríamos a avaliar a média para saber se está aprovado, em recuperação
    ou reprovado. */


using System.Security.AccessControl;

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