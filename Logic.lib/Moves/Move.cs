namespace Logic.lib;

public abstract class Move 
{
    private string name = "Tackle";
    private int power = -1;
    private int accuracy = -1;
    private Type moveType = Type.Normal;

    public string Name
    {
        get
        {
            return name;
        }
        set
        {
            name = value;
        }
    }

    public int Power
    {
        get
        {
            return power;
        }
        set
        {
            power = value;
        }
    }

    public int Accuracy
    {   
        get
        {
            return accuracy;
        }
        set
        {
            accuracy = value;
        }
    }


    public Type MoveType
    {
        get
        {
            return moveType;
        }
        set
        {
            moveType = value;
        }
    }

    public abstract void Attack(Type pokemonType, Pokemon attackedPokemon);

    
}
