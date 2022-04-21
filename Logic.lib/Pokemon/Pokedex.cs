namespace Logic.lib;

public class Pokedex
{
    public static void AddPokemon()
    {
        var Pokemons = Commands.PokemonDeserialize();

        var pokemon = PokemonFactory.Create();

        Pokemons.Add(pokemon);

        Commands.PokemonSerialize(Pokemons);
    }

    public static void ViewPokedex()
    {
        var Pokemons = Commands.PokemonDeserialize();

        var SortPokemon = 
            from pokemon in Pokemons
            orderby pokemon.PokedexNum
            select new
            {
                ID = pokemon.PokedexNum, 
                Name = pokemon.Name
            };

        foreach (var pokemon in SortPokemon)
        {
            Console.WriteLine($"{pokemon.ID}: {pokemon.Name}");
        }
        Console.ReadLine();
    }
}