using System.Net.Http;

namespace WebRequests.Webservice
{
    public class FavPokeService
    {
        public string GetFavPokemonJson()
        {
            string url = "https://pokeapi.co/api/v2/pokemon/ditto";
            HttpClient httpClient = new HttpClient();

            string result = httpClient.GetStringAsync(url).Result;
            return result;
        }
    }
}
