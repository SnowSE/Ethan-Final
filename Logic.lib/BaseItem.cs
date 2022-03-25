namespace Logic.lib;

public abstract class BaseItem : IItem
{
    public IItem.Strength strength {get; set;}

    public virtual void UseItem(Pokemon pokemon)
    {
        strength = IItem.Strength.Used;
    }
}