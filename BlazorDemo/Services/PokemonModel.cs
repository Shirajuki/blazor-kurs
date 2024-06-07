using System.Text.Json.Serialization;

namespace BlazorDemo.Services
{
  public class PokemonResponseData
  {
    [JsonPropertyName("count")]
    public int? Count { get; set; }

    [JsonPropertyName("next")]
    public object? Next { get; set; }

    [JsonPropertyName("previous")]
    public object? Previous { get; set; }

    [JsonPropertyName("results")]
    public IEnumerable<PokemonResult> Results { get; set; } = [];
  }

  public class PokemonResult
  {
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    [JsonPropertyName("url")]
    public required string Url { get; set; }
  }

  public class PokemonData
  {
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    [JsonPropertyName("sprites")]
    public required PokemonSprites Sprites { get; set; }

  }

  public class PokemonSprites
  {
    [JsonPropertyName("back_default")]
    public required string Back { get; set; }

    [JsonPropertyName("front_default")]
    public required string Front { get; set; }
  }

}
