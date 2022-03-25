namespace Logic.lib;

public class Pokemon : BasePokemon
{
 
    private int hp;

    public int HP 
    {
        get => hp;
        set => hp = value;
    }
    public int Max_HP { get; set; } = 200;

    public void Attacked(int attack)
    {
        if(attack <= 0)
        {
            return;
        }

        HP -= attack;
    }

    public void Heal(int heal)
    {
        if(heal <= 0)
        {
            return;
        }

        HP += heal;

        if(HP > Max_HP)
        {
            HP = Max_HP;
        }
        
    }
}