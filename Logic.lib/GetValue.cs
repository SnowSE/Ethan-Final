using System;

namespace Logic.lib;

public static class GetValue
{
    public static int GetInt(string Prompt, int min, int max, int cursorTop = 0)
    {
        while (true)
        {
            if (Console.WindowHeight < 30)
            {
                Console.Clear();
                Console.WriteLine("Please Expand the window");
                while (Console.WindowHeight < 30)
                {
                }
                Console.Clear();
            }
            Console.CursorTop = cursorTop;
            Console.WriteLine(Prompt);
            Console.WriteLine("                                                        \n\n\n");
            Console.CursorTop -= 4;
            try
            {
                var num = int.Parse(Console.ReadLine());

                if (num >= min && num <= max)
                {
                    Console.WriteLine("                                                  ");
                    Console.CursorTop--;
                    return num;
                }
                else
                {
                    Console.WriteLine($"Please Enter a number between {min} and {max}");
                }
            }
            catch
            {
                Console.WriteLine("Please Enter a number                       ");
            }
            Console.WriteLine("                                                  ");
            Console.CursorTop--;
        }
    }

    public static Type GetType(string Prompt, int cursorTop = 0)
    {
        Type returnType = default(Type);
        while (returnType == default(Type))
        {
            if (Console.WindowHeight < 30)
            {
                Console.Clear();
                Console.WriteLine("Please Expand the window");
                while (Console.WindowHeight < 30)
                {
                }
                Console.Clear();
            }
            Console.CursorTop = cursorTop;
            Console.WriteLine(Prompt);
            Console.WriteLine("                                                        \n\n\n");
            Console.CursorTop -= 4;

            var type = Console.ReadLine().ToLower();
            if (type == "normal")
            {
                returnType = Type.Normal;
            }
            else if (type == "fire")
            {
                returnType = Type.Fire;
            }
            else if (type == "water")
            {
                return Type.Water;
            }
            else if (type == "grass")
            {
                returnType = Type.Grass;
            }
            else if (type == "ground")
            {
                returnType = Type.Ground;
            }
            else if (type == "ghost")
            {
                returnType = Type.Ghost;
            }
            else if (type == "bug")
            {
                returnType = Type.Bug;
            }
            else if (type == "steel")
            {
                returnType = Type.Steel;
            }
            else if (type == "dark")
            {
                returnType = Type.Dark;
            }
            else if (type == "dragon")
            {
                returnType = Type.Dragon;
            }
            else if (type == "fairy")
            {
                returnType = Type.Fairy;
            }
            else if (type == "fighting")
            {
                returnType = Type.Fighting;
            }
            else if (type == "flying")
            {
                returnType = Type.Flying;
            }
            else if (type == "ice")
            {
                returnType = Type.Ice;
            }
            else if (type == "poison")
            {
                returnType = Type.Poison;
            }
            else if (type == "psychic")
            {
                returnType = Type.Psychic;
            }
            else if (type == "electric")
            {
                returnType = Type.Electric;
            }
            else if (type == "rock")
            {
                returnType = Type.Rock;
            }
            else
            {
                Console.WriteLine($"Please enter a typing, an example would be grass, water, or fire");
            }
        }
        Console.WriteLine("                                                                                 ");
        Console.CursorTop--;
        return returnType;
    }

    public static string GetString(string Prompt, int minLength, int maxLength, int cursorTop = 0)
    {
        while (true)
        {
            if (Console.WindowHeight < 30)
            {
                Console.Clear();
                Console.WriteLine("Please Expand the window");
                while (Console.WindowHeight < 30)
                {
                }
                Console.Clear();
            }
            Console.CursorTop = cursorTop;
            Console.WriteLine(Prompt);
            Console.WriteLine("                                                        \n\n\n");
            Console.CursorTop -= 4;
            try
            {

                var strang = Console.ReadLine();
                if (strang.Length >= minLength && strang.Length <= maxLength)
                {
                    Console.WriteLine("                                                  ");
                    Console.CursorTop--;
                    return strang;
                }
                else
                {
                    Console.WriteLine($"Don't enter too little and dont enter too much");
                }
            }
            catch
            {
                Console.WriteLine("How did you do that");
            }
        }
    }
}