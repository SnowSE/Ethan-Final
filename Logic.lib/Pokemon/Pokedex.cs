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
        string? input;
        Console.Clear();
        var Pokemons = Commands.PokemonDeserialize();

        var SortedPokemon =
            from pokemon in Pokemons
            orderby pokemon.PokedexNum
            select new
            {
                ID = pokemon.PokedexNum,
                Name = pokemon.Name
            };

        while (true)
        {
            foreach (var pokemon in SortedPokemon)
            {
                Console.WriteLine($"{pokemon.ID}: {pokemon.Name}");
            }
            Console.WriteLine("Would you like to view a certain pokemon closer? [y/n]");
            input = Console.ReadLine()?.ToLower();
            if (input == "yes" || input == "y")
            {
                ChoosePokemon(Pokemons).ToString();
            }
            else
            {
                return;
            }
        }
    }

    public static Pokemon ChoosePokemon(List<Pokemon> Pokemen)
    {
        while (true)
        {
            int desiredPDN = GetValue.GetInt("Please enter the pokedex number associated with your pokemon. (number next to your pokemon)", 0, 906, Console.CursorTop);
            foreach (var pokemon in Pokemen)
            {
                if (pokemon.PokedexNum == desiredPDN)
                {
                    return pokemon;
                }
            }
            Console.WriteLine("Please enter a valid pokedex number");
        }


    }
}