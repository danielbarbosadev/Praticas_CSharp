List<string> livrosDisponiveis = new();
List<string> livrosEmprestado = new();
int opcaoMenu = 0;



do
{
    Console.Write
    ($"""
==== MENU =====
[1] Cadastrar Livro
[2] Emprestar Livro
[3] Devolver Livro
[4] Remover Livro
[5] Sair

Digite sua opção aqui: 
""");
    if (!int.TryParse(Console.ReadLine()!, out opcaoMenu) || (opcaoMenu < 1 || opcaoMenu > 5))
    {
        Console.Write("Opção Inválida. Tente Novamente!! \n");
        Console.WriteLine();
    }
    else
    {
        switch (opcaoMenu)
        {
            case 1:
                CadastrarLivro();
                break;

            case 2:
                // EmprestarLivro();
                break;

            case 3:
                // DevolverLivro();
                break;

            case 4:
                // RemoverLivro();
                break;

            case 5:
                Console.WriteLine("Saindo...");
                break;

            default:

                break;
        }

    }
} while (opcaoMenu != 5);


void CadastrarLivro()
{

    int opcaoCadastrar = 0;
    do
    {
        Console.Write("Digite aqui o nome do livro que deseja cadastrar: ");
        string livroCadastrado = Console.ReadLine()!;

        if (LivroJaExistente(livrosDisponiveis, livroCadastrado))
        {
            Console.WriteLine("Livro já cadastrado!!");
        }
        else
        {
            livrosDisponiveis.Add(livroCadastrado);
        }
        opcaoCadastrar = 0;

        if (opcaoCadastrar == 0)
        {
            Console.Write
        ("""
        === LIVRO CADASTRADO COM SUCESSO =====
        O QUE DESEJA FAZER?
        [1] Cadastrar Outro
        [2] Voltar Menu

        Digite aqui sua escolha: 
        """);

            if (!int.TryParse(Console.ReadLine()!, out opcaoCadastrar) || opcaoCadastrar < 1 || opcaoCadastrar > 2)
            {
                Console.WriteLine("Opção Inválida. Tente Novamente!!");
                opcaoCadastrar = 0;
            }
        }
    } while (opcaoCadastrar == 1 || opcaoCadastrar != 2);
    
    Console.WriteLine();
}

bool LivroJaExistente(List<String> listaLivro, string livroProcurado)
{
    string? livroAchado = listaLivro.Find(l => l.Equals(livroProcurado, StringComparison.CurrentCultureIgnoreCase));

    if (livroAchado == null)
    {
        return false;
    }

    return true;
}