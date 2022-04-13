namespace Logic.lib;

public class Potion : BaseItem
{
    public Potion(int Uses)
    {
        this.Uses = Uses;
    }
    public override void UseItem(Pokemon pokemon)
    {
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
            pokemon.Heal(200);
            break;
            case Strength.Super:
            pokemon.Heal(50);
            break;
            case Strength.Basic:
            pokemon.Heal(20);
            break;
            default:
            break;
        }
        Uses--;
    }

    public override string ToString()
    {
        return $"{strength} Potion";
    }
}