using System;
using System.Threading;

namespace Aula_10_Objetos1
{
    public class Pessoa{
        // propriedades da classe

        //tipo nome ;
        public string Cpf;
        public string Nome;
        double SaldoConta;

        // Construtor default
        public Pessoa(){}

        // Construtor com parametros
        // parametro: tipo, nome
        public Pessoa(string Nome){
            this.Nome = Nome;
        }

        public Pessoa(string Cpf, string Nome, double SaldoInicial){
            this.Cpf = Cpf;
            this.Nome = Nome;
            this.SaldoConta = SaldoInicial;
        }

        // Metodos
        // metodo: tipo de retorno, nome (){...}
        public void Correr(){
            // TODO = ingles to do
            Console.WriteLine("Correndo...");
            // delay
            Thread.Sleep(1000);
        }
        public void Parar(){
            // TODO
            Console.WriteLine("Parando...");
            // delay
            Thread.Sleep(1000);
            Console.WriteLine("Parou.");
        }
        public void DepositarDinheiro(double Valor){
            this.SaldoConta += Valor;
            Console.WriteLine("Depositando dinheiro...");
            Thread.Sleep(2000);
            Console.WriteLine("Depósito efetuado.");
        }
        public void SacarDinheiro(double Valor){
            this.SaldoConta -= Valor;
            Console.WriteLine("Sacando dinheiro...");
            Thread.Sleep(2000);
            Console.WriteLine("Saque efetuado.");
        }

        public double ConsultarSaldo(){
            Console.WriteLine("Consultando saldo...");
            Thread.Sleep(2000);
            return this.SaldoConta;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Instanciar objetos
            // Criar variaveis na memoria baseado em uma classe
            // Objetos: são instancias de classes

            // Tipo, nome = new = instanciar
            Pessoa pessoa = new Pessoa();
            pessoa.Nome = "Maria";
            pessoa.Cpf = "01552764095";

            pessoa.Correr();
            pessoa.Parar();
            pessoa.DepositarDinheiro(100.00);

            Console.WriteLine("Pessoa 1: Nome: "+pessoa.Nome);
            Console.WriteLine("Pessoa 1: Cpf: "+pessoa.Cpf);
            Console.WriteLine("Pessoa 1: Saldo: "+pessoa.ConsultarSaldo());

            pessoa.Correr();
            pessoa.Parar();
            pessoa.SacarDinheiro(10.00);

            Console.WriteLine("Pessoa 1: Saldo: "+pessoa.ConsultarSaldo());

            Console.WriteLine("=======================");

            Pessoa pessoa2 = new Pessoa("Igor Gassen");
            Console.WriteLine("Pessoa 2: Nome: "+pessoa2.Nome);
            Console.WriteLine("Pessoa 2: Cpf: "+pessoa2.Cpf);
            Console.WriteLine("Pessoa 2: Saldo: "+pessoa2.ConsultarSaldo());

            pessoa2.Correr();
            pessoa2.Parar();
            pessoa2.DepositarDinheiro(500.00);
            Console.WriteLine("Pessoa 2: Saldo: "+pessoa2.ConsultarSaldo());
            pessoa2.SacarDinheiro(100.00);
            Console.WriteLine("Pessoa 2: Saldo: "+pessoa2.ConsultarSaldo());
        }
    }
}
