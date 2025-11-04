// Crie uma classe ContaBancaria com os atributos titular e saldo.
// Crie os métodos Depositar(valor) e Sacar(valor).
// Mostre o saldo atual após cada operação no console.

// O objeto ContaBancaria representa uma conta real.
// Quando o método Depositar for chamado, o saldo aumenta.
// Quando o método Sacar for chamado, o saldo diminui.
// No final, o programa deve mostrar o saldo atualizado.

namespace ClassesEObjetos
{
    public class AgênciaBancária
    {
        //Propriedades
        public string titular = "";
        public double valor;
        public double saldo;

        //Métodos
        public double Depositar()
        {
            saldo += valor;
            return saldo;
        }
        public double Sacar()
        {
            saldo -= valor;
            return saldo;
        }
        
    }
}