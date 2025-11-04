using MetodoConstrutor;

//PESSOA
// Pessoa João = new Pessoa("João",17);

// // João.Nome = "Felipe Fontes";
// // João.Idade = 18;

// System.Console.WriteLine(@$"O objeto pessoa que 
// criei é o {João.Nome} com a idade {João.Idade}");


// // João.Nome = "Gustavo Olivera";

// // System.Console.WriteLine(@$"O objeto pessoa que 
// // criei é o {João.Nome}");

// João.ExibirDados();






//3 Pessoas Sobre Carga

// Primeiro metodo construtor da class Pessoa3SobreCarva
Pessoa3SobreCarga PrimeiraPessoa = new Pessoa3SobreCarga();

System.Console.WriteLine(@$"Primeira pessoa cadastrada
                            Nome :{PrimeiraPessoa.Nome}
                            Idade :{PrimeiraPessoa.Idade}");

// Segunda metodo construtor da class Pessoa3SobreCarva
Pessoa3SobreCarga SegundaPessoa = new Pessoa3SobreCarga("Matheus Felix");
System.Console.WriteLine("Qual o nome da segunda pessoa?");
SegundaPessoa.Nome = Console.ReadLine();
System.Console.WriteLine(@$"Segunda pessoa cadastrada
                            Nome :{SegundaPessoa.Nome}
                            Idade :{SegundaPessoa.Idade}");

// Terceira metodo construtor da class Pessoa3SobreCarva
Pessoa3SobreCarga TerceiraPessoa = new Pessoa3SobreCarga("Bruno, 10");
System.Console.WriteLine("Qual o nome da terceira pessoa?");
TerceiraPessoa.Nome = Console.ReadLine();
System.Console.WriteLine("Qual a idade da terceira pessoa?");
TerceiraPessoa.Idade = int.Parse(Console.ReadLine());
System.Console.WriteLine(@$"Terceira pessoa cadastrada  
                            Nome :{TerceiraPessoa.Nome}
                            Idade :{TerceiraPessoa.Idade}");
