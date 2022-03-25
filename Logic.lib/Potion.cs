namespace Logic.lib;

public class Potion : BaseItem
{
    public override void UseItem(Pokemon pokemon)
    {
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
        base.UseItem(pokemon);
    }
}