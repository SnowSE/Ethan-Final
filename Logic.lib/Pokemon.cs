namespace Logic.lib;

public class Pokemon : IPokemon
{
    public Pokemon()
    {
        Typing = Type.Normal;
        Max_HP = 200;
        HP = Max_HP;
    }

    public Pokemon(string name)
    {
        Typing = Type.Normal;
        Max_HP = 200;
        HP = Max_HP;
        Name = name;
    }

    public Type Typing
    {
        get;
        set;
    }

    public string Name { get; set;} = "MissingNo";

    public int PokedexNum { get; } = -1;

    private int hp;

    public int HP
    {
        get => hp;
        set => hp = value;
    }

    public int Max_HP { get; set; } = 200;

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

    public virtual void Attack(Pokemon pokemon, int damage)
    {
        pokemon.Attacked(damage);
    }
   
}