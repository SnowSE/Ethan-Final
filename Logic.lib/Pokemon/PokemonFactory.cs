namespace Logic.lib;

public static class PokemonFactory
{
    public static Pokemon Create()
    {
        Type type;
        string name;
        int pokedexNum;
        int secondPokedexNum;
        int hp;
        Pokemon foundPokemon = new Pokemon();
        List<Move> moves;

        type = GetValue.GetType("Please enter a typing for your pokemon", Console.CursorTop);

        name = GetValue.GetString("Please choose a name for your Pokemon", 4, 12, Console.CursorTop);

        pokedexNum = GetValue.GetInt("Enter the Pokemons pokedex number", 1, 906, Console.CursorTop);

        foundPokemon = Pokedex.FindPokemon(pokedexNum);

        if (foundPokemon != default(Pokemon))
        {
            Console.WriteLine($"Would you like to override {foundPokemon.Name} from the pokedex? [y/n]");
            string choice = Console.ReadLine().ToLower();
            if (choice == "y" || choice == "yes")
            {
                Console.WriteLine($"Say goodbye to `{foundPokemon.Name}! They will be missed");
                Pokedex.RemovePokemon(pokedexNum);
            }
            else
            {
                pokedexNum = GetValue.GetNewPokedexNum();
            }
        }

        hp = GetValue.GetInt("Enter the HP of the Pokemon", 1, 714, Console.CursorTop);

        Console.WriteLine("You will now make the moves of the pokemon! Each pokemon has 4 moves!\n(But if you dont want to use all four slots, when you choose the power, make it a negative 1.)");

        moves = MovesFactory.Create();

        return new Pokemon(type, name, pokedexNum, hp, moves);
    }
}