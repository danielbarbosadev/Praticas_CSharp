using Heranca;

Gerente gerente = new()
{
    Nome = "Carlos"
};

gerente.Trabalhar();
gerente.GerenciarEquipe();
gerente.ExibirSalario();

Funcionario f = new Gerente();

Gerente gerente2 = new()
{
    Nome = "Kessia"
};

gerente.DefinirSalario(2000);

IPagamento p1 = new PagamentoPix();

p1.Pagar(20m);

IPagamento p2 = new PagamenteCartoes();
p2.Pagar(200m);