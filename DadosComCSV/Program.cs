using DadosComCSV.Repositories;
using DadosComCSV.Services;

var repository = new GameRepository();
var service = new GameService(repository);

bool executing = true;

while (executing)
{
    Console.Write
    ("""
    ======= GAME MANAGEMENT =======
    [1] REGISTER GAME
    [2] GAMES LIST
    [0] EXIT

    Choose an option: 
    """);

    string option = Console.ReadLine()!;

    try
    {
       switch (option)
       {
        case "1":
            // Cadastrar();
        break;

        case "2":
            var gamesList = service.Listar();
            foreach (var item in gamesList)
            {
                Console.WriteLine($"Name: {item.Nome} - Price: {item.Preco:c2}");
            }
        break;

        case "0":
            executing = false;
        break;

        default:
            Console.WriteLine("Invalid Option, Choose Another Option!");
        break;
       } 
    }
    catch (ArgumentException ex)
    {
        Console.WriteLine($"Error: {ex.Message}");
    }
}