using System;

namespace Logic.lib;

public static class GetValue
{
    public static int GetInt(string Prompt, int min, int max, int cursorTop = 0)
    {
        while (true)
        {
            Console.CursorTop = cursorTop;
            Console.WriteLine(Prompt);
            Console.WriteLine("                                                        \n\n\n");
            Console.CursorTop -= 4;
            try
            {
                var num = int.Parse(Console.ReadLine());
                
                if (num >= min && num <= max)
                {
                    return num;
                }
                else
                {
                    Console.WriteLine($"Please Enter a number between {min} and {max}");
                }
            }
            catch
            {
                Console.WriteLine("Please Enter a number");
            }
        }
    }

    public static Type GetType(string Prompt, int cursorTop = 0)
    {
        while (true)
        {
            Console.CursorTop = cursorTop;
            Console.WriteLine(Prompt);
            Console.WriteLine("                                                        \n\n\n");
            Console.CursorTop -= 4;

            var type = Console.ReadLine().ToLower();
            if (type == "normal")
            {
                return Type.Normal;
            }
            else if (type == "fire")
            {
                return Type.Fire;
            }
            else if (type == "water")
            {
                return Type.Water;
            }
            else if (type == "grass")
            {
                return Type.Grass;
            }
            else if (type == "ground")
            {
                return Type.Ground;
            }
            else if (type == "ghost")
            {
                return Type.Ghost;
            }
            else if (type == "bug")
            {
                return Type.Bug;
            }
            else if (type == "steel")
            {
                return Type.Steel;
            }
            else if (type == "dark")
            {
                return Type.Dark;
            }
            else if (type == "dragon")
            {
                return Type.Dragon;
            }
            else if (type == "fairy")
            {
                return Type.Fairy;
            }
            else if (type == "fighting")
            {
                return Type.Fighting;
            }
            else if (type == "flying")
            {
                return Type.Flying;
            }
            else if (type == "ice")
            {
                return Type.Ice;
            }
            else if (type == "poison")
            {
                return Type.Poison;
            }
            else if (type == "psychic")
            {
                return Type.Psychic;
            }
            else if (type == "electric")
            {
                return Type.Electric;
            }
            else if (type == "rock")
            {
                return Type.Rock;
            }
            else
            {
                Console.WriteLine($"Please enter a real typing");
            }
        }
    }

    public static string GetString(string Prompt, int minLength, int maxLength, int cursorTop = 0)
    {
        while (true)
        {
            Console.CursorTop = cursorTop;
            Console.WriteLine(Prompt);
            Console.WriteLine("                                                        \n\n\n");
            Console.CursorTop -= 4;
            try
            {
                var strang = Console.ReadLine();
                if (strang.Length >= minLength && strang.Length <= maxLength)
                {
                    return strang;
                }
                else
                {
                    Console.WriteLine($"Don't enter nothing and dont enter too much");
                }
            }
            catch
            {
                Console.WriteLine("How did you do that");
            }
        }
    }
}