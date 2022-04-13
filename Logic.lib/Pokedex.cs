namespace Logic.lib;

public static class Pokedex
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

        foreach (var pokemon in Pokemons)
        {
            Console.WriteLine($"{pokemon.PokedexNum}: {pokemon.Name}, {pokemon.HP}Hp, Type = {pokemon.Typing}");
        }
        Console.ReadLine();
    }
}