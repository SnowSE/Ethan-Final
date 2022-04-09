namespace Logic.lib;

public abstract class BaseItem : IItem
{
    public Strength strength {get; set;}

    public int Uses {get; set;}

    public virtual void UseItem(Pokemon pokemon)
    {
        strength = Strength.Used;
    }
}