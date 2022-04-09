namespace Logic.lib;

public interface IItem
{
    public Strength strength{get; set;}

    public int Uses {get; set;}
    public virtual void UseItem(Pokemon pokemon)
    {
        throw new NotImplementedException();
    }

}