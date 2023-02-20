using Exercicios03ao06;
using Exercicios03ao06.Classes.Enum;

ContaBancaria conta1 = new ContaBancaria(2508, 1324, "Márcio Oliveria", TipoContaEnum.POUPANCA );
ContaBancaria conta2 = new ContaBancaria(2398, 4798, "Márcio Cristiano", TipoContaEnum.POUPANCA);


// testando metodo depositar
conta1.Depositar(200);

conta1.Transferir(conta2, 50);

// exibe saldo conta1
conta1.ExibirSaldo();

// exibi saldo conta2
conta2.ExibirSaldo();

