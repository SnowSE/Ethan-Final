namespace Logic.lib;

public static class PokemonFactory
{
    public static Pokemon Create()
    {
        Type type;
        string name;
        int pokedexNum;
        int hp;

        type = GetValue.GetType("Please enter a type for you pokemon");

        name = GetValue.GetString("Please choose a name for your Pokemon", 4, 12);

        pokedexNum = GetValue.GetInt("Enter the Pokemons pokedex number", 1, 906);

        hp = GetValue.GetInt("Enter the HP of the Pokemon", 1, 714);

        return new Pokemon(type, name, pokedexNum, hp);
    }
}