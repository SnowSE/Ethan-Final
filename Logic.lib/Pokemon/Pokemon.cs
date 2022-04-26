namespace Logic.lib;

public class Pokemon : IPokemon
{
    public Pokemon()
    {
        Typing = Type.Normal;
        Max_HP = 200;
        HP = Max_HP;
        Level = -1;
    }

    public Pokemon(string name)
    {
        Typing = Type.Normal;
        Max_HP = 200;
        HP = Max_HP;
        Name = name;
    }

    public Pokemon(Type typing)
    {
        Typing = typing;
        Max_HP = 200;
        HP = Max_HP;
        Level = -1;
    }
    public Pokemon(Type typing, string name, int PokedexNum, int _HP)
    {
        Typing = typing;
        Max_HP = _HP;
        HP = _HP;
        this.PokedexNum = PokedexNum;
        Name = name;
        Level = -1;
    }

     public Pokemon(Type typing, string name, int PokedexNum, int _HP, List<Move> newMoves)
    {
        Typing = typing;
        Max_HP = _HP;
        HP = _HP;
        this.PokedexNum = PokedexNum;
        Name = name;
        Level = -1;
        Moves = newMoves;
    }

    public Type Typing
    {
        get;
        set;
    }

    public string Name { get; set; } = "MissingNo";

    public int PokedexNum { get; set;} = -1;

    private int hp;

    public int HP
    {
        get => hp;
        set => hp = value;
    }

    public int Max_HP { get; set; } = 200;

    private int level;
    public int Level
    {
        get
        {
            return level;
        }
        private set
        {
            level = value;
        }
    }

    private List<Move> moves = new();
    public List<Move> Moves{
        get
        {
            if(moves.Count == 0)
            {
                return new List<Move>(){new Move()};
            }
            return moves;
        }
        set
        {
            moves = value;
        }
        }
    
    public void Attacked(int attack)
    {
        if (attack <= 0)
        {
            return;
        }

        HP -= attack;
    }

    public void Heal(int heal)
    {
        if (heal <= 0)
        {
            return;
        }

        HP += heal;

        if (HP > Max_HP)
        {
            HP = Max_HP;
        }
    }

    public virtual void Attack(Pokemon OpponetPokemon, Move move)
    {
        move.Attack(Typing, OpponetPokemon, 1);
    }

    public override string ToString()
    {
        string log = "";
        log += $"{Name} [lvl: {Level}]\nTyping: {Typing}\nMoves include:";
        foreach(var move in moves)
        {
            log += $"{move.ToString()}";
        }
        log += "\n";
        return log;
    }
}