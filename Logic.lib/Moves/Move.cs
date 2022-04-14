namespace Logic.lib;

public class Move 
{
    private string name = "Tackle";
    private int power = -1;
    private Type moveType = Type.Normal;

    public Move()
    {

    }

    public Move(string newName, int newPower, Type newMoveType)
    {
        Name = newName;
        Power = newPower;
        MoveType = newMoveType;
    }

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

    public void Attack(Type pokemonType, Pokemon attackedPokemon, int Effectivness)
    {
        attackedPokemon.Attacked((int)(Power * Effectivness)); // reember 23
    }    
}
