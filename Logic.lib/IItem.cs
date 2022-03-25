namespace Logic.lib;

public interface IItem
{
    public ItemType Item{get;}

    enum ItemType
    {
        Potion,
        XAttack,
        XDefense,
        Full_Heal,
        Used
    }

}