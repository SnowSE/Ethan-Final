namespace Logic.lib;

public abstract class BasePokemon : IPokemon
{
    public Type Typing => throw new NotImplementedException();

    public string Name { get; } = "MissingNo";

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

}