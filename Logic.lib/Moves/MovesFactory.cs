namespace Logic.lib;

public static class MovesFactory
{
    public static List<Move> Create()
    {
        List<Move> Moves = new();

        string name = "Not Used";
        int power = -1;
        Type moveType = Type.Normal;

        Console.Clear();
        bool Done = false;
        Console.WriteLine("Now you will Choose the moves for your pokemon. If you would like to stop making moves enter a negative power");
        for (int i = 0; i < 4; i++)
        {
            power = GetValue.GetInt("Please enter the power of the move (this is a number to calculate how much damage you do", int.MinValue, 100, Console.CursorTop);
            if (power < 0)
            {
                Done = true;
            }
            if (Done)
            {
                break;
            }
            name = GetValue.GetString("Please enter the name of the move.", 3, 25, Console.CursorTop);
            moveType = GetValue.GetType("Please enter the type of the move", Console.CursorTop);

            Console.WriteLine("Moving on to the next move");

            Moves.Add(new Move(name, power, moveType));

        }

        return Moves;
    }
}