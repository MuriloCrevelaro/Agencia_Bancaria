using ExerciciosMetodoConstrutor;
using PrimeiraClasse;

// //                                                     Carro
// Carro c1 = new Carro();

// Console.Clear();
// Console.WriteLine($"-------------------------------------------------------");
// System.Console.WriteLine("Qual a marca do carro?");
// c1.Marca = Console.ReadLine();
// Console.WriteLine($"-------------------------------------------------------");
// System.Console.WriteLine("Qual a modelo do carro?");
// c1.Modelo = Console.ReadLine();
// Console.WriteLine($"-------------------------------------------------------");
// System.Console.WriteLine("Qual o ano de lancamento do carro?");
// c1.Ano = int.Parse(Console.ReadLine());
// Console.WriteLine($"-------------------------------------------------------");
// System.Console.WriteLine(@$"Dados do carro:
//                              Marca: {c1.Marca}
//                              Modelo: {c1.Modelo}
//                              Ano de lancamento: {c1.Ano}");



// //                                                     Aluno

// Aluno a1 = new Aluno();
// Aluno a2 = new Aluno("Murilo", 10);

// System.Console.WriteLine(@$"Aluno 1:
//                             Nome: {a1.Nome}
//                             Nota:{a1.Nota}");
// System.Console.WriteLine(@$"Aluno 2:
//                             Nome: {a2.Nome}
//                             Nota:{a2.Nota}");




//                                                      Produto


//                                                    Conta Bancaria


//                                                    Média Aluno
MediaAluno a1 = new MediaAluno(6, 7, 2);
a1.Nome = "Carlos";
a1.Media();

MediaAluno a2 = new MediaAluno();
a2.Nome = "Samuel";
a2.Media();