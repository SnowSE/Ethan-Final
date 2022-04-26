namespace Logic.lib;

public class Move
{
    private string name = "Not Used";
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

    public void Attack(Type pokemonType, Pokemon attackedPokemon, double Effectivness, out int Damage)
    {
        Damage = (int)(Power * Effectivness);
        attackedPokemon.Attacked(Damage); // remember 23
        if (Effectivness == 2)
        {
            Console.WriteLine("It's Super Effective!!");
        }
        else if (Effectivness == .5)
        {
            Console.WriteLine("It's Not Very Effective");
        }
        else if (Effectivness == 0)
        {
            Console.WriteLine("That move doesnt seem to work!");
        }
        else
        {
            Console.WriteLine("The attack hit!");
        }
        Console.ReadLine();
    }

    public void Attack(Type pokemonType, Pokemon attackedPokemon, double Effectivness)
    {
        attackedPokemon.Attacked((int)(Power * Effectivness)); // remember 23
        if (Effectivness == 2)
        {
            Console.WriteLine("It's Super Effective!!");
        }
        else if (Effectivness == .5)
        {
            Console.WriteLine("It's Not Very Effective");
        }
        else if (Effectivness == 0)
        {
            Console.WriteLine("That move doesnt seem to work!");
        }
        else
        {
            Console.WriteLine("The attack hit!");
        }
        Console.ReadLine();
    }

    public override string ToString()
    {
        if(Name == "Not Used" && Power == -1 && MoveType == Type.Normal)
        {
            return "";
        }
        return $"\n{Name}: {MoveType} - Power[{Power}]";
    }
}
