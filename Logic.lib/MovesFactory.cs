namespace Logic.lib;

public static class MovesFactory
{
    public static List<Move> Create()
    {
        List<Move> Moves = new();

        string name = "Not Used";
        int power = -1;
        Type moveType = Type.Normal;


        for (int i = 0; i < 4; i++)
        {
            name = GetValue.GetString("Please enter the name of the move.", 3, 25, Console.CursorTop);
            power = GetValue.GetInt("Please enter the power of the move", 0, 200, Console.CursorTop);
            moveType = GetValue.GetType("Please enter the type of the move", Console.CursorTop);

            
        }

        return Moves;
    }
}