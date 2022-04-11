namespace Logic.lib;

public static class Calculator
{
    public static double CalculateTypeEffectiveness(Type attackingType, Type defendingType)
    {
        if (attackingType == Type.Fire)
        {
            switch (defendingType)
            {
                case Type.Grass:
                case Type.Bug:
                case Type.Ice:
                case Type.Steel:
                    return 2;
                case Type.Fire:
                case Type.Rock:
                case Type.Water:
                case Type.Dragon:
                    return .5;
                default:
                    return 1;
            }
        }
        else if (attackingType == Type.Water)
        {
            switch (defendingType)
            {
                case Type.Fire:
                case Type.Rock:
                case Type.Ground:
                    return 2;
                case Type.Water:
                case Type.Grass:
                case Type.Dragon:
                    return .5;
                default:
                    return 1;
            }
        }
        else if (attackingType == Type.Normal)
        {
            switch (defendingType)
            {
                case Type.Rock:
                case Type.Steel:
                    return .5;
                case Type.Ghost:
                    return 0;
                default:
                    return 1;
            }
        }
        else if (attackingType == Type.Steel)
        {
            switch (defendingType)
            {
                case Type.Fairy:
                case Type.Ice:
                case Type.Rock:
                    return 1;
                case Type.Electric:
                case Type.Fire:
                case Type.Steel:
                case Type.Water:
                    return .5;
                default:
                    return 1;
            }
        }
        else if (attackingType == Type.Grass)
        {
            switch (defendingType)
            {
                case Type.Rock:
                case Type.Ground:
                case Type.Water:
                    return 2;
                case Type.Bug:
                case Type.Dragon:
                case Type.Fire:
                case Type.Flying:
                case Type.Grass:
                case Type.Poison:
                case Type.Steel:
                    return .5;
                default:
                    return 1;
            }
        }
        else if (attackingType == Type.Bug)
        {
            switch (defendingType)
            {
                case Type.Grass:
                case Type.Dark:
                case Type.Psychic:
                    return 2;
                case Type.Fairy:
                case Type.Fighting:
                case Type.Fire:
                case Type.Flying:
                case Type.Ghost:
                case Type.Poison:
                case Type.Steel:
                    return .5;
                default:
                    return 1;
            }
        }
        return 1;
    }

    public static int RandomPokemon()
    {
        Random random = new Random();
        return random.Next(0, 5);
    }
}