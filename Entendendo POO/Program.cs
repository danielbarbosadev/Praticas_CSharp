using Entendendo_POO;

Produto p1 = new()
{
    Nome = "Notebook",
    Preco = 4500m
};

p1.Exibir();

Produto p2 = new()
{
    Nome = "Mouse",
    Preco = 100m
};

p2.Exibir();

// Classes e métodos static

int resultado = Calculadora.Somar(15, 25);