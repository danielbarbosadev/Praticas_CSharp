// Exercicio 01 - Apresentação Pessoal

Console.Write("Digite seu nome: ");
string nome = Console.ReadLine()!;

Console.Write("Digite sua idade: ");
if (int.TryParse(Console.ReadLine()!, out int idade))
{
   Console.Write("Digite sua cidade: ");
   string cidade = Console.ReadLine()!;

   Console.WriteLine();

   Console.WriteLine
   ($""" 
   === RESUMO INFORMAÇÕES ===
   Nome do usuário: {nome}
   Idade: {idade}
   Cidade: {cidade}
   """);
}
else Console.WriteLine("Informação inválida (EX 1), o resumo não será preciso.");
Console.WriteLine();

// Exercicio 02 - Calculando uma compra

Console.Write("Nome do produto que deseja comprar: ");
string nomeProduto = Console.ReadLine()!;

Console.Write("Quantidade de produto: ");
if (decimal.TryParse(Console.ReadLine()!, out decimal quantidade))
{
   Console.Write("Preço unitário: ");
   if (decimal.TryParse(Console.ReadLine()!, out decimal preco))
   {
      decimal valorTotal = preco * quantidade;

      Console.WriteLine
      ($""" 

      === RESUMO INFORMAÇÕES ===
      Produto escolhido: {nomeProduto}
      Preço Unitário: {preco:c2}
      Quantidade: {quantidade}
      Valor Final: {valorTotal: c2}
      """);
   }
   else Console.WriteLine("Informação inválida (EX 2), o resumo não será preciso.");
}
else Console.WriteLine("Informação inválida (EX 2), o resumo não será preciso.");
Console.WriteLine();

// Exercício 3 — Classificação de notas

Console.Write("Digite o nome do aluno: ");
string nomeAluno = Console.ReadLine()!;

Console.Write($"Digite a nota do {nomeAluno}: ");
if (int.TryParse(Console.ReadLine()!, out int notaAluno) && !(notaAluno > 10 || notaAluno < 0))
{
   string situacaoAluno;
   if (notaAluno >= 7)
   {
      situacaoAluno = "Aprovado";
   }
   else if (notaAluno < 5)
   {
      situacaoAluno = "Reprovado";
   }
   else
   {
      situacaoAluno = "Recuperação";
   }

   Console.WriteLine
   ($""" 
   === RESUMO INFORMAÇÕES ===
   Nome do Aluno: {nomeAluno}
   Nota do Aluno: {notaAluno}
   Situação do Aluno: {situacaoAluno}
   """);
}
else Console.WriteLine("Nota inválida, tente novamente!");
Console.WriteLine();

// Exercício 4 — Tabuada

Console.Write("Digite um número: ");
if (int.TryParse(Console.ReadLine()!, out int numero))
{
   for (int i = 1; i <= 10; i++)
      Console.Write($"{numero} x {i} = {numero * i} \n");
}
else { Console.WriteLine("Número invalido. Tente novamente!"); }
Console.WriteLine();

// Exercício 5 — Adivinhe o número

const int numeroSorteado = 75;
int tentativas = 0;
int numeroEscolhido;

do
{
   Console.Write("Um número foi definido, tente adivinhar qual número foi sorteado: ");
   if (int.TryParse(Console.ReadLine()!, out numeroEscolhido))
   {
      if (numeroEscolhido < numeroSorteado)
      {
         Console.WriteLine($"Seu número é MENOR que número sorteado");
         tentativas++;
      }
      else if (numeroEscolhido > numeroSorteado)
      {
         Console.WriteLine($"Seu número é MAIOR que número sorteado");
         tentativas++;
      }
      else
      {
         Console.WriteLine();

         Console.WriteLine
         ($"""
            PARABÉNS VOCÊ ACERTOU O NÚMERO SORTEADO!!
            ==== RESUMO =======
            Número sorteado: {numeroSorteado}
            Quantidade de tentativas: {tentativas} 
         """);
      }
   }
   else
   {
      Console.WriteLine("Número inválido. Tente novamente!");
      break;
   }

} while (numeroEscolhido != numeroSorteado);
Console.WriteLine();

// Exercício 6 — Calculadora com métodos

Console.Write("Digite o primeiro número: ");
if (int.TryParse(Console.ReadLine()!, out int num1))
{
   Console.Write("Digite o segundo número: ");
   if (int.TryParse(Console.ReadLine()!, out int num2))
   {
      Console.WriteLine();

      Console.Write
      (""" 
      ==== ESCOLHA ====
      [1] Somar
      [2] Multiplicar
      [3] Ambos
      
      Coloque sua escolha aqui: 
      """);
      if (int.TryParse(Console.ReadLine()!, out int escolha) && escolha < 4 && escolha > 0)
      {
         Console.WriteLine();
         switch (escolha)
         {
            case 1:
               Console.WriteLine($"{num1} + {num2} = {somar(num1 , num2)}");
               break;

            case 2:
               Console.WriteLine($"{num1} x {num2} = {multiplicar(num1, num2)}");
               break;

            case 3:
               Console.WriteLine
               ($"""
               === RESULTADO DE AMBOS ===
               Soma: {num1} + {num2} = {somar(num1 , num2)}
               Multiplicação: {num1} x {num2} = {multiplicar(num1, num2)} 
               """);
               break;
            default:
               break;
         }
         
      }

   }
}

else Console.WriteLine("Número inválido. Tente novamente!");

int somar(int num1, int num2)
{
   int resultado = num1 + num2;

   return resultado;
}

int multiplicar(int num1, int num2)
{
   int resultado = num1 * num2;

   return resultado;
}
 Console.WriteLine();

// Exercício 7 — Cadastro de notas em um array

int[] notas = new int[3];

for (int i = 0; i < notas.Length; i++)
{
   Console.Write($"Escreva a {i + 1}º nota: ");
   if (!int.TryParse(Console.ReadLine()!, out notas[i]))
   {
      Console.WriteLine("Nota inválida. Tente novamente!");
      break;
   }
}

Console.Write("As notas do aluno foram: ");
for (int i = 0; i < notas.Length; i++)
{
   Console.Write($"{notas[1]}, ");
}

Console.WriteLine();

int media = 0;
int soma = 0;
foreach (var nota in notas)
{
  
   soma += nota;
   
   media = soma / notas.Length;
}

Console.Write($"Media das notas: {media}");
Console.WriteLine();

// Exercício 8 — Análise de números

int[] numeros = new int[5];
int numPar = 0;
int maiorNumero = 0;
for (int i = 0; i < numeros.Length; i++)
{
   Console.Write($"Digite o {i + 1}º número: ");
   if (int.TryParse(Console.ReadLine()!, out numeros[i]))
   {
      if (numeros[i] % 2 == 0)
      {
         numPar++;
      }

      if (numeros[i] >= maiorNumero)
      {
         maiorNumero = numeros[i];
      }
   }
   else
   {
      Console.WriteLine("Número inválido. Tente novamente!");
      break;
   }
}

Console.WriteLine();

Console.Write
($"""
Quantidade de números pares: {numPar}
Maior número digitado: {maiorNumero}
""");

Console.WriteLine();

// Exercício 9 e 10 — Lista de produtos - Busca de produtos
int opcao = 0;
bool opcaoEscolhida = false;
List<String> produtos = new List<string>();

do
{
  if (!opcaoEscolhida)
  {
      Console.Write
      ("""
      === ESCOLHA ===
      [1] Adicionar produto
      [2] Exibir Lista 
      [3] Remover Produto
      [4] Verificar Produto
      [5] Sair
      Digite aqui sua escolha: 
      """);
      if (!int.TryParse(Console.ReadLine()!, out opcao) || opcao > 5)
      {
         Console.WriteLine("[ERRO] Escolha inválida. Tente novamente!");
         break;
      }
  }

  Console.WriteLine();

  opcaoEscolhida = true;
  string produto;

  switch (opcao)
  {
   case 1:
      opcaoEscolhida = false;
      Console.Write("Adicione o produto: ");
      produto = Console.ReadLine()!;
      
      produtos.Add(produto);
   break;

   case 2:
   opcaoEscolhida = false;

   Console.WriteLine("LISTA COMPLETO DOS PRODUTOS:");
   foreach (var listaProduto in produtos)
   {
      Console.WriteLine($"- {listaProduto}");
   }
   break;

   case 3:
      opcaoEscolhida = false;

      Console.WriteLine("ESCOLHA QUAL PRODUTO IRÁ SER REMOVIDO:");
      foreach (var listaProduto in produtos)
      {
         Console.WriteLine($"- {listaProduto}");
      }
      Console.Write("Digite o nome do produto aqui: ");
      string removerProduto = Console.ReadLine()!;

      produtos.Remove(removerProduto);
      Console.WriteLine($"O produto {removerProduto} foi removido com sucesso!!");
   break;

   case 4:
      opcaoEscolhida = false;

      Console.Write("Digite o nome do produto que deseja procurar: ");
      string produtoProcurado = Console.ReadLine()!;

      string? produtoAchado =  produtos.Find(p => p.Equals(produtoProcurado, StringComparison.OrdinalIgnoreCase));

      if (produtoAchado == null)
      {
         Console.WriteLine($"O Produto {produtoProcurado} não se encontra na lista.");
         break;
      }

      Console.WriteLine($"O Produto {produtoProcurado} está presente na lista");
   break;

   case 5:
      Console.WriteLine("SAINDO...");
   break;

   default:
      Console.WriteLine("[ERRO] Opção inválida");
   break;
  }
   
} while (opcao != 5);









