using System.Text;
using DadosComCSV.Models;

namespace DadosComCSV.Repositories
{
    public class GameRepository
    {
        private readonly string? _filePath;

        public GameRepository()
        {
            // Cria a pasta e o arquivo com o cabeçalho se ainda não existirem
            // Combina e monta caminhos usando o separador correto do sistema
            string dataFolder = Path.Combine(Environment.CurrentDirectory, "Data"); 
            Directory.CreateDirectory(dataFolder);

            _filePath = Path.Combine(dataFolder, "games.csv");

            if (!File.Exists(_filePath))
            {
                File.WriteAllText
                (_filePath, "Id;Nome;Desenvolvedora;Genero;AnoLancamento;Preco" + Environment.NewLine, Encoding.UTF8);
            }
        }

        public List<Game> Listar()
        {
            var games = new List<Game>();

            var lines = File.ReadAllLines(_filePath!, Encoding.UTF8);

            foreach (var line in lines.Skip(1))
            {
                if (string.IsNullOrWhiteSpace(line))
                {
                    continue;
                }

                // range = cédula de uma tabela
                var range = line.Split(";");

                if (range.Length != 6)
                {
                    continue;
                }

                games.Add(new Game
                {
                    Id = int.Parse(range[0]),
                    Nome = range[1],
                    Desenvolvedora = range[2],
                    Genero = range[3],
                    AnoLancamento = int.Parse(range[4]),
                    Preco = decimal.Parse(range[5])
                });
            }
            return games;
        }
    }   
}