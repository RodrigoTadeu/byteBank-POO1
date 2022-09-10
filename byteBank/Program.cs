using byteBank;
using byteBank.Titular;

Console.WriteLine("Bem vindo!");

//contaCorrente conta1 = new contaCorrente();

//conta1.titular = "Rodrigo Tadeu";
//conta1.conta = "102345-x";
//conta1.numero_agencia = 23;
//conta1.nome_agencia = "Agencia Central";
//conta1.saldo = 93.50; 

//contaCorrente conta2 = new contaCorrente();

//conta2.titular = "Amanda Silva";
//conta2.conta = "128394-a";
//conta2.numero_agencia = 25;
//conta2.nome_agencia = "Agencia Lateral";
//conta2.saldo = 100;

//Console.WriteLine("Saldo " + conta2.saldo);
//conta2.Sacar (40);
//Console.WriteLine("saldo " + conta2.saldo);

//conta2.Depositar(60);
//Console.WriteLine("depositado " + conta2.saldo);

//conta1.Transferir(50, conta2);
//Console.WriteLine(conta2.saldo);

// Cliente cliente1 = new Cliente();

//cliente1.nome = "Gustavo Henrique";
//cliente1.cpf = "12345678239";
//cliente1.profissao = "Programador";

//contaCorrente conta3 = new contaCorrente();
//conta3.titular = new Cliente();

//conta3.titular.nome = "Gustavo Henrique";
//conta3.conta = "102345-x";
//conta3.numero_agencia = 23;
//conta3.nome_agencia = "Agencia Central";
//conta3.saldo = 93.50;

//Console.WriteLine(conta3.titular.nome);

contaCorrente conta4 = new contaCorrente(23, "102345-x");
conta4.Saldo = 10;
Console.WriteLine(contaCorrente.TotalDeContasCriadas);
