namespace Logic.lib;

public abstract class BaseItem : IItem
{
    public IItem.ItemType Item {get; set;}

    public void UseItem()
    {
        Item = IItem.ItemType.Used;
    }
}