
namespace BlazorDemo.Services;
using System.Net.Http;
using System.Text.Json;

public class PokemonService : IPokemonService
{

  public async Task<PokemonResponseData?> GetAll(int offset)
  {
    using HttpClient client = new();
    var request = new HttpRequestMessage(HttpMethod.Get, $"https://pokeapi.co/api/v2/pokemon?offset={offset}&limit=20");

    var response = await client.SendAsync(request);
    if (response.IsSuccessStatusCode)
    {
      using var responseStream = await response.Content.ReadAsStreamAsync();
      return await JsonSerializer.DeserializeAsync<PokemonResponseData>(responseStream);
    }
    return null;
  }

  public async Task<PokemonData?> Get(int id)
  {
    using HttpClient client = new();
    var request = new HttpRequestMessage(HttpMethod.Get, $"https://pokeapi.co/api/v2/pokemon/{id}");

    var response = await client.SendAsync(request);
    if (response.IsSuccessStatusCode)
    {
      using var responseStream = await response.Content.ReadAsStreamAsync();
      return await JsonSerializer.DeserializeAsync<PokemonData>(responseStream);
    }
    return null;
  }

}