using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using GameOfThronesAPI.APICaller;
using GameOfThronesAPI.Models.GameOfThrones;

namespace GameOfThronesAPI.Controllers
{
    [Route("api/[controller]")]
    public class GameOfThronesController : Controller
    {
        // GET api/gameofthrones
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "Base", "Get" };
        }

        // GET api/gameofthrones/books
        [Route("books")]
        public async Task<Books[]> GetBooksAsync()
        {
            Books[] books = await ApiCaller.GetBooksAsync();
            return books;
        }

        // GET api/gameofthrones/characters
        [Route("characters")]
        public async Task<Characters[]> GetCharacters()
        {
            Characters[] characters = await ApiCaller.GetCharactersAsync();
            return characters;
        }

        // GET api/gameofthrones/houses
        [Route("houses")]
        public async Task<Houses[]> GetHouses()
        {
            Houses[] houses = await ApiCaller.GetHousesAsync();
            return houses;
        }
    }
}
