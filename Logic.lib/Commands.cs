using System.Text.Json;

namespace Logic.lib;

public static class Commands
{
    public static List<Pokemon> PokemonDeserialize()
    {
        string FileName = "Pokemon.json";
        if (!File.Exists(FileName))
        {
            File.Create(FileName);
            return new List<Pokemon>();
        }
        var json = File.ReadAllText(FileName);
        if (json.Length == 0)
        {
            return new List<Pokemon>();
        }
        return JsonSerializer.Deserialize<List<Pokemon>>(json);
    }

    public static void PokemonSerialize(List<Pokemon> pokemons)
    {
        string FileName = "Pokemon.json";
        if (!File.Exists(FileName))
        {
            File.Create(FileName);
            return;
        }
        var json = JsonSerializer.Serialize(pokemons);
        File.WriteAllText(FileName, json);
    }
}
