using System.Globalization;

namespace Exercicios
{
    internal class Conta
    {
        // atributo 'Taxa' pra armazenar um valor fixo
        private double _taxa = 5.0;

        // Auto Properties
        // propriedade 'Numero' que pode ser exibida mas não alterada fora da classe
        public int Numero { get; private set; }
        // propriedade 'Titular' que pode tanto ser exibida quanto alterada
        public string Titular { get; set; }
        // propriedade 'Saldo' que pode ser exibida mas não alterada fora da classe
        public double Saldo { get; private set; }

        // construtor 2 parâmetros
        // utilizado caso o usuário decida NÃO fazer um depósito inicial
        public Conta(int numeroConta, string titular)
        {
            // pega o input recebido por parâmetro e bota na variável Numero
            Numero = numeroConta;
            // pega o input recebo por parâmetro e bota na variável Titular
            Titular = titular;
        }

        // construtor 3 parâmetros usando sobrecarga
        // utilizado apenas se o usuário decidir fazer um depósito inicial
        public Conta(int numeroConta, string titular, double depositoInicial) : this(numeroConta, titular)
        {
            // pega o input recebido por meio do construtor de 3 parâmetros e chama o método 'Deposito' passando esse mesmo input por parâmetro
            Deposito(depositoInicial);
        }

        // metodo Deposito
        public void Deposito(double valor)
        {
            // pega o saldo atual e adiciona o valor recebido no parâmetro
            Saldo += valor;
        }

        // metodo Saque
        public void Saque(double valor)
        {
            // pega o saldo atual e diminui o valor recebido por parâmetro somado com a taxa fixa definida no ínicio da classe
            Saldo -= valor + _taxa;
        }

        // metodo ToString
        // utilizado para facilitar a reutilização dessa mesma frase durante o programa
        public override string ToString()
        {
            return "Conta "
                 + Numero
                 + ", Titular: "
                 + Titular
                 + ", Saldo: $ "
                 + Saldo.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
