using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APIGames.DTO
{
    public class GameDTO
    {

        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Producer { get; set; }
        public double Price { get; set; }
    }
}
