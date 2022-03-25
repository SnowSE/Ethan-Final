namespace Logic.lib;

public class WaterPokemon : Pokemon
{
    public WaterPokemon(string name)
    {
        Typing = Type.Water;
        Name = name;
    }
    public override void Attack(Pokemon pokemon, int damage)
    {
        switch (pokemon.Typing)
        {
            case Type.Fire:
            case Type.Rock:
                pokemon.Attacked(damage * 2);
                break;
            case Type.Water:
            case Type.Grass:
                pokemon.Attacked(damage / 2);
                break;
            default:
                base.Attack(pokemon, damage);
                break;
        }
    }
}