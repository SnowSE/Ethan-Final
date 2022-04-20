namespace Logic.lib;
public interface IPokemon
{
    public Type Typing {get;}

    public int Level {get;}

    public void Attacked(int Damage);
    
}

