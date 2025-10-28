/*  */

int opcao = 0;
string[] nomes = new string[3];
double[] saldo = new double[3];
int totalCLientes = 0;

do
{
    Console.Clear();


    Console.WriteLine("------------------------------------------------------");
    Console.WriteLine("------- Sistema Bancario Simples----------------------");
    Console.WriteLine("------------------------------------------------------");
    Console.WriteLine("1) Cadastrar cliente");
    Console.WriteLine("2) Depositar");
    Console.WriteLine("3) Sacar");
    Console.WriteLine("4) Transferir");
    Console.WriteLine("5) Listar clientes");
    Console.WriteLine("0) Sair");
    Console.WriteLine("------------------------------------------------------");
    Console.Write($"\n Escolha uma opção:"); // O \n é para dar um tab
    opcao = int.Parse(Console.ReadLine());



    switch (opcao)
    {
        case 0:
            Sair();
            break;
        case 1:
            Cad();
            break;
        case 2:
            BuscarCliente();
            Dep();
            break;
        case 3:
            Sac();
            break;
        case 4:
            Transferir();
            break;
        case 5:
            Lista();
            break;
        default:
            Console.WriteLine("Opção invalida!");
            break;
    }

    Console.WriteLine("Presione <Enter> para continuar...");
    Console.ReadLine();


} while (opcao != 0);

void Sair()
{
    Console.WriteLine("");
}
void Cad()
{
    if (totalCLientes >= 3)
    {
        Console.WriteLine($"Limite de ocupação atingido");
        return;
    }


    Console.WriteLine($"Digite o nome do cliente");
    nomes[totalCLientes] = Console.ReadLine();//lê o console e guarda o valor digitado na variável temporária "n"
    Console.WriteLine($"Digite a saldo de {nomes[totalCLientes]}");
    int i = int.Parse(Console.ReadLine());

    // guardar/cadastrar no array
    saldo[totalCLientes] = i;
    totalCLientes++;

    Console.WriteLine($"Aluno cadastrado com sucesso");
    Console.WriteLine($"Há {totalCLientes} clientes(s) cadastrado(s) no sistema!");

}
void Dep()
{
    int id = BuscarCliente();
    if (id == -1)
    {
        return;
    }
    Console.WriteLine("Valor para depósito");
    double ValorDepositado = double.Parse(Console.ReadLine());
    saldo[id] += ValorDepositado;
    Console.WriteLine($"Depósito de R${ValorDepositado} realizado!");


//  Console.WriteLine("----------------------------------------------------------------");
//     Console.WriteLine($"Selecione qual cliente fez o deposito");
//     Console.WriteLine("----------------------------------------------------------------");
//     for (int i = 0; i < totalCLientes; i++)
//     {
//         Console.WriteLine("----------------------------------------------------------------");
//         Console.WriteLine($"{i + 1} - {nomes[i]} - Deposito Atual: R$:{saldo[i]}");
//         Console.WriteLine("----------------------------------------------------------------");
//         Console.WriteLine();
//         Thread.Sleep(1000);
//     }
//     ;
//     Console.WriteLine("----------------------------------------------------------------");

//     int n = int.Parse(Console.ReadLine());
//     Console.WriteLine();
//     Console.WriteLine();

//     Console.WriteLine("----------------------------------------------------------------");
//     Console.WriteLine($"Digite de quanto foi o deposito");
//     Console.WriteLine("----------------------------------------------------------------");

//     double deposito = double.Parse(Console.ReadLine());

//     saldo[n - 1] += deposito;

//     Console.Write("Para continuar precione a tecla <Enter>");
//     Thread.Sleep(500);
//     Console.Write($".");
//     Thread.Sleep(500);
//     Console.Write($".");
//     Thread.Sleep(500);
//     Console.WriteLine($".");
//     Console.ReadLine();
}
void Sac()
{
    int id = BuscarCliente();
    if (id == -1)
    {
        return;
    }
    Console.WriteLine("Valor para sacar");
    double ValorSacado = double.Parse(Console.ReadLine());
    saldo[id] -= ValorSacado;
    if (saldo[id] >= ValorSacado)
    {
        Console.WriteLine($"Saque de R${ValorSacado} realizado!");
    }
    else
    {
        Console.WriteLine("Saldo insuficiente");
    }

}
void Transferir()
{
   Console.WriteLine("----------------------------------------------------------------");
    Console.WriteLine($"Selecione qual cliente fez a transferencia");
    Console.WriteLine("----------------------------------------------------------------");
    for (int i = 0; i < totalCLientes; i++)
    {
        Console.WriteLine("----------------------------------------------------------------");
        Console.WriteLine($"{i + 1} - {nomes[i]} - Deposito Atual: R$:{saldo[i]}");
        Console.WriteLine("----------------------------------------------------------------");
        Console.WriteLine();
        Thread.Sleep(1000);
    }
    ;
    Console.WriteLine("----------------------------------------------------------------");

    int n1 = int.Parse(Console.ReadLine());
    Console.WriteLine();
    Console.WriteLine();

    Console.WriteLine("----------------------------------------------------------------");
    Console.WriteLine($"Selecione qual cliente recebeu a transferencia");
    Console.WriteLine("----------------------------------------------------------------");
    for (int i = 0; i < totalCLientes; i++)
    {
        Console.WriteLine("----------------------------------------------------------------");
        Console.WriteLine($"{i + 1} - {nomes[i]} - Deposito Atual: R$:{saldo[i]}");
        Console.WriteLine("----------------------------------------------------------------");
        Console.WriteLine();
        Thread.Sleep(1000);
    }
    ;
    Console.WriteLine("----------------------------------------------------------------");

    int n2 = int.Parse(Console.ReadLine());
    Console.WriteLine();
    Console.WriteLine();

    Console.WriteLine("----------------------------------------------------------------");
    Console.WriteLine($"Digite de quanto foi a transferencia");
    Console.WriteLine("----------------------------------------------------------------");

    double transferencia = double.Parse(Console.ReadLine());

    saldo[n1 - 1] -= transferencia;
    saldo[n2 - 1] += transferencia;
}
void Lista()
{
    Console.WriteLine();//pula uma linha
    Console.WriteLine($" ==== Lista de Clientes ==== ");

    for (int i = 0; i < nomes.Length; i++)
    {
        Console.Write($"{i + 1} - Nome: {nomes[i]} |");
        Console.WriteLine($"Saldo: {saldo[i]: F2}");//O F2 Serve para limitar a quantidade de casas decimais apare
        Console.WriteLine();//pula uma linha
    }

}
int BuscarCliente()
{
    Lista();
    Console.Write("Digite o número do cliente: ");
    int id = int.Parse(Console.ReadLine());

    if (id < 0 || id >= totalCLientes)
    {
        Console.WriteLine("Cliente não encontrado");
        return -1; // Cliente não encontrado
    }
    return 0;
}

