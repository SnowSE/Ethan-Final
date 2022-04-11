namespace Logic.lib;

public class PhysicalAttack : Move
{
    public StatusEffect effect {get; set;}

    public int probability {get; set;}

    public override void Attack(Type pokemonType, Pokemon attackedPokemon, int Effectivness)
    {
        int modifier = 1;
        if(pokemonType == MoveType)
        {
            modifier = 2;
        }
        attackedPokemon.Attacked((int)(Power * Effectivness * modifier));
    }
}