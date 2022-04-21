namespace Logic.lib;

public static class MovesFactory
{
    public static List<Move> Create()
    {
        List<Move> Moves = new();

        string name = "Not Used";
        int power = -1;
        Type moveType = Type.Normal;

        bool Done = false;
        for (int i = 0; i < 4; i++)
        {
            Console.Clear();
            power = GetValue.GetInt("Please enter the power of the move", -3000, 200, Console.CursorTop);
            if(power <= -1)
            {
                Done = true;
            }
            if(Done)
            {
                break;
            }
            name = GetValue.GetString("Please enter the name of the move.", 3, 25, Console.CursorTop);
            moveType = GetValue.GetType("Please enter the type of the move", Console.CursorTop);

            Moves.Add(new Move(name, power, moveType));
            
        }

        return Moves;
    }
}