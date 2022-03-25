namespace Logic.lib;

public class NormalPokemon : Pokemon
{
    public NormalPokemon(string name)
    {
        Name = name;
    }
    public override void Attack(Pokemon pokemon, int damage)
    {
        switch (pokemon.Typing)
        {
            case Type.Rock:
                pokemon.Attacked(damage / 2);
                break;
            default:
                base.Attack(pokemon, damage);
                break;
        }
    }
}