using Heranca_Exercicios;
using Heranca_Exercicios.Documentos;

//* 1. Sistema de veículos
Veiculo carro = new Carro() 
{
    Marca = "Fiat",
    Modelo = "Uno",
    QuantidadePortas = 4
};

Veiculo motocicleta = new Motocicleta()
{
    Marca = "Kawasaki",
    Modelo = "Ninja 500",
    Cilindradas = 451
};

carro.ExibirInformacoes();
motocicleta.ExibirInformacoes();

//* 2. Sistema de produtos digitais
ProdutoDigital ebook = new Ebook("Harry Potter", 100m, 150);
ProdutoDigital cursoOnline = new CursoOnline("POO", 80m, 80);

ebook.ExibirInformacoes();
cursoOnline.ExibirInformacoes();

//* 3. Sistema de jogos
Jogo jogoDigital = new JogoDigital("Zelda", "Nintendo");
Jogo jogoFisico = new JogoFisico("God of War 2", "Playstation 2");

jogoDigital.ExibirInformacoes();
jogoFisico.ExibirInformacoes();

//* 4. Sistema de notificações
Notificacao generico = new();
Notificacao email = new NotificacaoEmail();
Notificacao sms = new NotificacaoSMS();
Notificacao push = new NotificacaoPush();

generico.Enviar();
email.Enviar();
sms.Enviar();
push.Enviar();


//* 5. Sistema de cálculo de frete
Entrega expressa = new EntregaExpressa(100);
Entrega economico = new EntregaEconomica(100);
Entrega local = new RetiradaLocal(100);

List<Entrega> listaFrete = new()
{
    expressa,
    economico,
    local
};

Console.WriteLine("=== RESUMO EX-05 FRETE ===");
foreach (var lista in listaFrete)
{
    Console.WriteLine($"Frete: {lista.CalcularFrete():C2}");
}

//* 6. Sistema de documentos
Relatorio relatorio = new();
Contrato contrato = new();

relatorio.Exportar();
relatorio.Imprimir();
contrato.Imprimir();



