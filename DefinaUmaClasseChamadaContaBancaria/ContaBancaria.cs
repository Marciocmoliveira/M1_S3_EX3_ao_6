
using Exercicios03ao06.Classes.Enum;

namespace Exercicios03ao06
{
    public class ContaBancaria
    {
        //Resposta exercício 04_M1_S3
        private int _numero;
        private int _agencia;
        private string _nomeDoTitular;
        private decimal _saldo = 0;
        private TipoContaEnum _tipoConta;

        //Resposta exercício 03_M1_S3
        public ContaBancaria(int numero, int agencia, string nomeDoTitular, TipoContaEnum tipoConta)
        {
            //Atribui os valores do construtor
            this._numero = numero;
            this._agencia = agencia;
            this._nomeDoTitular = nomeDoTitular;
            this._tipoConta = tipoConta;
        }

        //Resposta exercíco 05_M1_S3
        public ContaBancaria(string nomeDoTitular, TipoContaEnum tipoConta)
        {
            //instancia uma classe Random para gerar números aleatórios
            Random random = new Random();

            //gera um numero aleatório entre 0000 e 9999
            _numero = random.Next(0000, 9999);
            _agencia = random.Next(0000, 9999);

            //atribui valor ao construtor
            _nomeDoTitular = nomeDoTitular;
            _tipoConta = tipoConta;
        }

        //Resposta exercício 06_M1_S3
        public void Transferir(ContaBancaria conta, Decimal valor)
        {
            //validar se o valor transferido é maior que zero!
            if(valor <=0)
            {
                Console.WriteLine("O valor precisa ser maior do que zero.");
            }
            //validar se o saldo é suficiente para realizar a transferencia.
            if(valor > _saldo) 
            {
                Console.WriteLine("Saldo insuficiente>");
            }
            _saldo -= valor;
            conta.Depositar(valor);

            Console.WriteLine($"Valor de {valor} transferido com susesso!");

        }
        public void Depositar(decimal valor)
        {
            if (valor <= 0)
            {
                Console.WriteLine("O valor precisa ser maior do que 0");
            }
            else
            {
                _saldo = _saldo + valor;
            }
        }

        
        public void Sacar(decimal valor)
        {
            if (valor <= 0)
            {
                Console.WriteLine("O valor precisa ser maior do que 0");

            }
            else if (valor > _saldo)
            {
                Console.WriteLine("O valor é maior do que o saldo atual!");

            }
            else
            {
                _saldo = _saldo - valor;
            }
        }

       
        public void ExibirSaldo()
        {
            Console.WriteLine($"O saldo atual da conta é de R$ {_saldo}");
        }
       
    }
}
