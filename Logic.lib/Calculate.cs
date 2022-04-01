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
                    return 2;
                case Type.Fire:
                case Type.Rock:
                case Type.Water:
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
                    return 2;
                case Type.Water:
                case Type.Grass:
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
        return random.Next(0,5);
    }
}