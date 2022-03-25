namespace Logic.lib;

public class Pokemon : BasePokemon
{
 
    private int hp;

    public int HP 
    {
        get => hp;
        set => hp = value;
    }
    public int Max_HP { get; set; }

    public void Attacked(int attack)
    {
        if(attack <= 0)
        {
            return;
        }

        hp -= attack;
    }

    public void Heal(int heal)
    {
        throw new NotImplementedException();
    }
}