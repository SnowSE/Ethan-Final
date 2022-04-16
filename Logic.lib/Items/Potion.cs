namespace Logic.lib;

public class Potion : BaseItem
{
    public Potion(int Uses)
    {
        this.Uses = Uses;
    }
    public override void UseItem(Pokemon pokemon)
    {
        int healAmmount = 0;
        if(Uses <= 0)
        {
            base.UseItem(pokemon);
        }
        switch(strength)
        {
            case Strength.Max:
            pokemon.Heal(pokemon.Max_HP);
            break;
            case Strength.Hyper:
            healAmmount = 200;
            break;
            case Strength.Super:
            healAmmount = 50;
            break;
            case Strength.Basic:
            healAmmount = 20;
            break;
            default:
            break;
        }
        Uses--;
        if(healAmmount == 0)
        {
            Console.WriteLine("Your Pokemon is fully healed!");
        }
        else
        {
            Console.WriteLine($"Your Pokemon healed {healAmmount}HP");
        }
    }

    public override string ToString()
    {
        return $"{strength} Potion";
    }
}