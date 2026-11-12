using DadosComCSV.Models;
using DadosComCSV.Repositories;

namespace DadosComCSV.Services
{
    public class GameService
    {
        private readonly GameRepository? _repository;
        
        public GameService(GameRepository repository)
        {
            _repository = repository;
        }

        public List<Game> Listar()
        {
            return _repository!.Listar();
        }
    }
}