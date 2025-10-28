// See https://aka.ms/new-console-template for more information
Console.Clear();

Console.WriteLine("Digite seu nome");
string nome = Console.ReadLine();
Console.WriteLine("Digite seu sobrenome");
string sobrenome = Console.ReadLine();

Console.WriteLine($"Ok {nome}! Agora vamos dar as boas vindas a você!!");
Console.WriteLine($"por favor escolha um aopção a baixo:");
Console.WriteLine($"1 - Saudar com nome"); // receba o nome por parametro e digitar a saudação dentro da função
Console.WriteLine($"2 - Saudar com sobrenome");// receba o sobrenome por parametro e digitar a saudação dentro da função
Console.WriteLine($"3 - Saudar com nome e sobrenome");// receba o nome e o sobrenome e vai desenvolver o nome
Console.WriteLine($"0 - Apenas saudação genérica");// só devolve um texto genérico de saudação


int opcao = 0;
switch (opcao)
{
    case 0:
        saudacaoGene();
        break;
    case 1:
        saudacaoNome(nome);
        break;
    case 2:
        saudacaoSobre(sobrenome);
        break;
    case 3:
        string nomeCompleto = DevolveNomeCompleto(nome, sobrenome);
        Console.WriteLine($"Seja bem vindo{nomeCompleto}");
        break;
    default:

        break;

}




void saudacaoGene()
{
    Console.WriteLine($"Olá, seja bem vindo ao nosso programa, tenha um ótimo dia :)");
}

void saudacaoNome( string nomerecebido )
{
    Console.WriteLine($"Seja bem vindo, {nomerecebido}");
}
string DevolveNomeCompleto(string nomerecebido, string sobrenomeRecebido)
{
// Recebe nome e sobrenome e delve o nome completo
    return nomerecebido + "" + sobrenomeRecebido;
    // return $"{nomerecebido} {sobrenomeRecebido}";
}


void saudacaoSobre( string nomerecebido )
{
    Console.WriteLine($"Olá{sobrenome}, seja bem vindo ao nosso programa, tenha um ótimo dia :)");
}

void saudacaoCompleto()
{
    
}