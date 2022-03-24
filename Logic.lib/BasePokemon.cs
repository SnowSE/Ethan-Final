namespace Logic.lib;

public abstract class BasePokemon : IPokemon
{
    public IPokemon.Type Typing => throw new NotImplementedException();

    public string Name {get;} = "MissingNo";

    public int PokedexNum {get;} = -1;

}