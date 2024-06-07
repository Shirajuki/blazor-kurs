namespace BlazorDemo.Services;

public interface IPokemonService
{
  Task<PokemonResponseData?> GetAll(int offset);

  Task<PokemonData?> Get(int id);
}