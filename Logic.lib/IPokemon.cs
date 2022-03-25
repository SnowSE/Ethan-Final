namespace Logic.lib;
public interface IPokemon
{
    public Type Typing {get;}

    enum Type
    {
        Fire,
        Water,
        Grass,
        Fighting,
        Rock,
        Flying
    }
    
}

