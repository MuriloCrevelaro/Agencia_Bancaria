/*  Escreva     um     programa     que     verifique     a     validade  
    de     uma     senha     fornecida pelo     usuário.     A     senha     válida  
    é     o     número     1234.    Devem     ser    impressas     as    seguintes     mensagens:     

   - ACESSO    PERMITIDO    caso    a    senha    seja    válida.     
   - ACESSO    NEGADO    caso    a    senha    seja    inválida  */
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
