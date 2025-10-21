        // Pedir o nome do usuario, dois números e mostrar a soma dos números
        string nome;
        int N1, N2;

        // Pedir o nome do usuario
        Console.WriteLine("Digite seu nome:");
        nome = Console.ReadLine();

        // Pedir os dois numeros
        Console.WriteLine("------------------------------------------");
        Console.WriteLine("Digite seu primeiro número:");
        N1 = int.Parse(Console.ReadLine());

        Console.WriteLine("------------------------------------------");
        Console.WriteLine("Digite seu segundo número:");
        N2 = int.Parse(Console.ReadLine());

        // Somar os dois números
        int soma = N1 + N2;

        Console.WriteLine("------------------------------------------");
        Console.WriteLine($"{nome}, a soma dos seus números é: {soma}");
        Console.WriteLine("------------------------------------------");

        // Mostrar qual número é maior
        if (N1 > N2)
        {
            Console.WriteLine($"O primeiro número é maior: {N1}");
            Console.WriteLine($"{N1} > {N2}");
        }
        else if (N1 < N2)
        {
            Console.WriteLine($"O segundo número é maior: {N2}");
            Console.WriteLine($"{N2} > {N1}");
        }
        else
        {
            Console.WriteLine("Os dois números são iguais:");
            Console.WriteLine($"{N1} = {N2}");
        }
