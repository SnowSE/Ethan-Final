namespace Logic.lib;

public static class PokemonFactory
{
    public static Pokemon Create()
    {
        Type type;
        string name;
        int pokedexNum;
        int hp;
        List<Move> moves;

        type = GetValue.GetType("Please enter a type for you pokemon", Console.CursorTop);

        name = GetValue.GetString("Please choose a name for your Pokemon", 4, 12, Console.CursorTop);

        pokedexNum = GetValue.GetInt("Enter the Pokemons pokedex number", 1, 906, Console.CursorTop);

        hp = GetValue.GetInt("Enter the HP of the Pokemon", 1, 714, Console.CursorTop);

        moves = MovesFactory.Create();

        return new Pokemon(type, name, pokedexNum, hp){Moves = moves};
    }
}