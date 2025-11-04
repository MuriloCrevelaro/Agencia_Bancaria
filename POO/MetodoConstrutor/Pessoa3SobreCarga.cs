namespace MetodoConstrutor
{
    public class Pessoa3SobreCarga
    {
        public string Nome = "";
        public int Idade;

        public Pessoa3SobreCarga() //Não tem sobrecarga
        {
            Nome = "Desconhecido"; //Valor inicial fixo
            Idade = 0; //Valor inicial fixo
        }
        
        public Pessoa3SobreCarga(string n) //Sobrecarrega a idade pois iguala a algo que ele acabou de criar
        {
            Nome = n; //Valor inicial dinamico
            Idade = 0; //Valor inicial fixo
        }
        public Pessoa3SobreCarga(string n, int i) //Sobrecarrega o Nome e idade pois iguala a algo pré determinado
        {
            Nome = n; //Valor inicial dinamico
            Idade = i; //Valor inicial dinamico
        }

        public void ExibirDados() //   O "()" são os parametros
        {
            Console.WriteLine($"Nome: {Nome} Idade:{Idade}");
        }
    }
}