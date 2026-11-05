using Entendendo_POO;

// Produto 1
Produto p1 = new();

p1.AlterarNome("");
p1.AlterarPreco(4500m);

p1.Exibir();


// Produto 2
Produto p2 = new();

p2.AlterarNome("Mousepad");
p2.AlterarPreco(0m);

p2.Exibir();




// Classes e métodos static

int resulSoma = Calculadora.Somar(15, 25);
Console.WriteLine($"Resultado: {resulSoma}");


// Utilizando a classe estática
// Conta.Depositar(100m);
// Conta.Depositar(50m);

Conta contaCorrente = new();
Conta contaPoupanca = new();

contaCorrente.Depositar(100m);
contaPoupanca.Depositar(50m);

Pessoa pessoa1 = new("Cordeiro", 19);

Console.WriteLine
($"""
=== INFORMAÇÕE PESSOAIS ===
Nome: {pessoa1.Nome}
Idade: {pessoa1.Idade}
""");
