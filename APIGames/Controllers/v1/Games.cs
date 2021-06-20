using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using APIGames.Entities;
using APIGames.DTO;
using APIGames.Services;
using System.ComponentModel.DataAnnotations;

namespace APIGames.Controllers.v1
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class GamesController : ControllerBase
    {

        private readonly IGameService _gameService;

        public GamesController(IGameService gameService)
        {
            _gameService = gameService;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<GameDTO>>> getGame([FromQuery, Range(1, int.MaxValue)] int page = 1, [FromQuery, Range(1, 50)] int quantity = 5)
        {
            var games = await _gameService.GetGame(page, quantity);

            if (games.Count() != 0)
                return Ok(games);

            return NoContent();

        }

        [HttpGet("{idGame:guid}")]
        public async Task<ActionResult<List<GameDTO>>> getGame(Guid idGame)
        {
            return Ok();
        }

        [HttpPost]
        public async Task<ActionResult<GameDTO>> insertGame(Game game)
        {
            return Ok();
        }

        [HttpPut("{idGame:guid}")]
        public async Task<ActionResult> updateGame(Guid idGame, Game game)
        {
            return Ok();
        }

        [HttpPatch("{idGame:guid}/price/{price:double}")]
        public async Task<ActionResult> updateGame(Guid idGame, double price)
        {
            return Ok();
        }

        [HttpDelete("{idGame:guid}")]
        public async Task<ActionResult> deleteGame(Guid idGame)
        {
            return Ok();
        }
    }
}
