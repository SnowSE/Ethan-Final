namespace Logic.lib;

public class Pokedex
{
    public static List<Pokemon> Pokemen = Commands.PokemonDeserialize();
    public static void AddPokemon()
    {
        var pokemon = PokemonFactory.Create();

        Pokemen.Add(pokemon);

        Commands.PokemonSerialize(Pokemen);
    }

    public static void ViewPokedex()
    {
        string? input;
        Console.Clear();

        var SortedPokemon =
            from pokemon in Pokemen
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
                Console.WriteLine(ChoosePokemon(Pokemen).ToString());
            }
            else
            {
                return;
            }
        }
    }

    public static Pokemon ChoosePokemon(List<Pokemon> Pokemen)
    {
        Pokemon? desiredPokemon = default(Pokemon);
        while (true)
        {
            int desiredPDN = GetValue.GetInt("Please enter the pokedex number associated with your pokemon. (number next to your pokemon)", 0, 906, Console.CursorTop);
            desiredPokemon = FindPokemon(desiredPDN);
            if(desiredPokemon != default(Pokemon))
            {
                return desiredPokemon;
            }
            Console.WriteLine("Please enter a valid pokedex number next");
        }
    }

    public static Pokemon FindPokemon(int PDN)
    {
        foreach (var pokemon in Pokemen)
        {
            if (pokemon.PokedexNum == PDN)
            {
                return pokemon;
            }
        }
        return default(Pokemon);
    }
}