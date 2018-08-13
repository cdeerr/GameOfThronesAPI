using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using GameOfThronesAPI.Models.GameOfThrones;

namespace GameOfThronesAPI.APICaller
{
    public class ApiCaller
    {
        const string BASE_PATH = "https://www.anapioficeandfire.com/api";
        const string BOOKS_PATH = "/books";
        const string CHARACTERS_PATH = "/characters";
        const string HOUSES_PATH = "/houses";

        static HttpClient client = new HttpClient();

        static async Task RunAsync() {
            // Set uri
            client.BaseAddress = new Uri(BASE_PATH);
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept
                .Add(new MediaTypeWithQualityHeaderValue("application/json"));
        }

        public static async Task<Books[]> GetBooksAsync() {
            Books[] books = null;
            HttpResponseMessage response = await client.GetAsync(BASE_PATH + BOOKS_PATH);
            if (response.IsSuccessStatusCode) {
                books = await response.Content.ReadAsAsync<Books[]>();
            }
            return books;
        }

        public static async Task<Characters[]> GetCharactersAsync()
        {
            Characters[] characters = null;
            HttpResponseMessage response = await client.GetAsync(BASE_PATH + CHARACTERS_PATH);
            if (response.IsSuccessStatusCode)
            {
                characters = await response.Content.ReadAsAsync<Characters[]>();
            }
            return characters;
        }

        public static async Task<Houses[]> GetHousesAsync()
        {
            Houses[] houses = null;
            HttpResponseMessage response = await client.GetAsync(BASE_PATH + HOUSES_PATH);
            if (response.IsSuccessStatusCode)
            {
                houses = await response.Content.ReadAsAsync<Houses[]>();
            }
            return houses;
        }
    }
}
