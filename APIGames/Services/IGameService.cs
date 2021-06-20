using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using APIGames.DTO;
using APIGames.Entities;

namespace APIGames.Services
{
    public interface IGameService
    {

        Task<List<GameDTO>> GetGame(int page, int quantity);

        Task<GameDTO> GetGame(Guid id);
        Task<GameDTO> InsertGame(Game game);
        Task UpdateGame(Guid id, Game game);
        Task UpdateGame(Guid id, double price);
        Task DeleteGame(Guid id);
    }
}
