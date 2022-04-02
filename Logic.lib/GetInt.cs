namespace Logic.lib;

public static class GetInt
{
    public static int Getint(string Prompt, int min, int max)
    {
        while (true)
        {
            Console.WriteLine(Prompt);
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

}