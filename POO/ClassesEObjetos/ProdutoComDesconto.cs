namespace ClassesEObjetos
{
    public class ProdutoComDesconto
    {
        //Propriedade
        public string nome = "";
        public double preco;
        public double percentual;

        //Método
        public double AplicarDesconto()
        {
            percentual = (100 - percentual) / 100;
            preco = preco * percentual;
            return preco;
        }
    }
}