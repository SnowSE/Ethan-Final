namespace Logic.lib;

public class Potion : BaseItem
{
    public override void UseItem(Pokemon pokemon)
    {
        switch(strength)
        {
            case Strength.Used:
            break;

        }
        base.UseItem(pokemon);
    }
}