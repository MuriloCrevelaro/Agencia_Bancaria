// See https://aka.ms/new-console-template for more information

float saldoConta = 300.97f;//numero real com 64 bits
double dinheiro = 0.90;//numero real com 32 bits
saldoConta = (saldoConta + (float)dinheiro); //Você tem que colocar o float par deixar a unidades iguais para a soma ser possivel
string nome = "Nathan";
string sobrenome = "Jeferson";

//Exibir nome, sobrenome e saldo da conta
Console.WriteLine(nome);
Console.WriteLine(sobrenome);
Console.WriteLine(saldoConta);

