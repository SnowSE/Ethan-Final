namespace Logic.lib;

public interface IItem
{
    public Strength strength{get;}

    enum Strength
    {
        Max,
        Hyper,
        Super,
        Basic,
        Used
    }

}