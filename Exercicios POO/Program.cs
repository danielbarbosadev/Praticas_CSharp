using Exercicios_POO;

// 1. Apresentação de pessoas
Pessoa pessoa1 = new("Caynam", 20, "Santo André");
Pessoa pessoa2 = new("Kevin", 21, "Heliópolis");

pessoa1.Apresentar();
pessoa2.Apresentar();
// 2. Métodos de instância e métodos estáticos
Calculadora soma = new();

Console.WriteLine(soma.Somar(2, 5));
Calculadora.Dividir(2, 5);

// 3. Propriedades com validação
Veiculo Mini_Cooper = new();

Mini_Cooper.alterarVelocidade(200);
Mini_Cooper.alterarVelocidade(210);

// 4. Propriedades e controle de acesso
Funcionario funcionario1 = new("Caynem", "Developer", 110000);

funcionario1.AumentarSalario(10);
funcionario1.ConsultarSalario();

// 5. Construtores e sobrecarga
Livro livro1 = new();
Livro livro2 = new("Harry Potter");
Livro livro3 = new("Pequeno Principe", "Antoine");
Livro livro4 = new("Noites Brancas", "Dostoiévski", 96);

livro1.ConsultarLivro();
livro2.ConsultarLivro();
livro3.ConsultarLivro();
livro4.ConsultarLivro();

