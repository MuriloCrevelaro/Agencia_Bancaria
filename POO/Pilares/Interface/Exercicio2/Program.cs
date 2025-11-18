using System.Reflection.Metadata;
using Exercicio2;

// Cria uma lista de objetos Fatura
List<IImprimivel> documentos = new List<IImprimivel>();

int opcao;
do
{
System.Console.WriteLine("Menu de opção");
System.Console.WriteLine($@"
0) Sair
1) Cadastrar Fatura
2) Cadastrar Relatorio
3) Cadastrar Contrato
4) Listar Faturas
5) Listar Relatório
6) Listar Contratos

Escolher a opção:
");
opcao = int.Parse(Console.ReadLine());
System.Console.WriteLine("Digite <Enter> para continuar ...");
Console.ReadLine();

    switch (opcao)
    {
        case 0:
            System.Console.WriteLine("Sair");
            return;
        case 1:
            System.Console.WriteLine("Cadastrar fatura");
            return;
        case 2:
            System.Console.WriteLine("Cadastrar Relatorio");
            return;
        case 3:
            System.Console.WriteLine("Cadastrar Contrato");
            return;
        case 4:
            System.Console.WriteLine("Listar Faturas");
            return;
        case 5:
            System.Console.WriteLine("Listar Relatório");
            return;
        case 6:
            System.Console.WriteLine("Listar Contratos");
            return;
    }
} while (opcao != 0);



//Funções auxiliares
void CadastrarFatura()
{
    System.Console.WriteLine("Digite o nome do devedor: ");
    string dev = Console.ReadLine();
    System.Console.WriteLine("Digite o nome do credor: ");
    string cred = Console.ReadLine();
    System.Console.WriteLine("Digite o valor da fatura: ");
    float valor = float.Parse(Console.ReadLine());
    System.Console.WriteLine("Quantos dias de fatura está atrasado: ");
    int diasAtraso = int.Parse(Console.ReadLine());


    Fatura f = new Fatura(dev, cred, valor, diasAtraso);
    documentos.Add(f);

    System.Console.WriteLine("Fatura cadastrado com sucesso");
}

void CadastrarContrato()
{
    System.Console.WriteLine("Digite o nome do contratante: ");
    string conte = Console.ReadLine();
    System.Console.WriteLine("Digite o nome da pessoa contratada: ");
    string contra = Console.ReadLine();
    System.Console.WriteLine("Digite o texto do contrato: ");
    string txtClausulas = Console.ReadLine();

    Contrato c = new Contrato(conte, contra, txtClausulas);
    documentos.Add(c);

    System.Console.WriteLine("Contrato cadastrado com sucesso");
}

void CadastrarRelatorio()
{
    System.Console.WriteLine("Digite o nome do responsavel: ");
    string responsavel = Console.ReadLine();
    System.Console.WriteLine("Digite o texto do relatorio: ");
    string txtRelatorio = Console.ReadLine();

    Relatorio f = new Relatorio( responsavel, txtRelatorio);
    documentos.Add(f);

    System.Console.WriteLine("Relatório cadastrado com sucesso");
}

void ListarFatura()
{
    System.Console.WriteLine($"Listando os faturas:");
    
    foreach (var item in documentos)
    {
        //Valida o tipo de classe só se for Fatura
        if (item is Fatura)
        {
            item.Imprimir();       
        }
    }
}

void ListarContratos()
{
    System.Console.WriteLine($"Listando os contratos:");

    foreach (var item in documentos)
    {
        //Valida o tipo de classe só se for Contrato
        if (item is Contrato)
        {
            item.Imprimir();       
        }
    }
}

void ListarRelatorios()
{
    System.Console.WriteLine($"Listando os relatórios:");

    foreach (var item in documentos)
    {
        //Valida o tipo de classe só se for Relatorio
        if (item is Relatorio)
        {
            item.Imprimir();       
        }
    }
}


