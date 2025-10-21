/* Escreva     um     programa que leia     as     medidas     dos     lados     de     um 
   triângulo     e    escreva    se    ele    é    Equilátero,    Isósceles    ou    Escaleno.    Sendo    que:     

   − Triângulo    Equilátero:    possui    os    3    lados    iguais.     
   − Triângulo    Isóscele:    possui    2    lados    iguais.     
   − Triângulo    Escaleno:    possui    3    lados    diferentes. */

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