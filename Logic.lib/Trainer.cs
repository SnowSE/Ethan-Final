namespace Logic.lib;

public class Trainer
{
    public string Name { get; }

    private Pokemon setPokemon;
    public Pokemon SetPokemon
    {
        get
        {
            try
            {
                return setPokemon;
            }
            catch 
            {
                return new Pokemon(){Max_HP = 0};
            }
        }
        
        set
        {
            setPokemon = value;
        }
    }

    public List<Pokemon> Party = new List<Pokemon>();
    public List<BaseItem> Bag = new List<BaseItem>();

}