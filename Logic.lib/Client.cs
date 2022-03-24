namespace Logic.lib;

public class Client : Person, IDisplay
{
    private int AccountID { get; set; }

    private string[] SQAnswers;

    public decimal IntrestRate;

    public decimal Debt {get; set;}

    public decimal Balance {get; set;}

    public void Display()
    {
        //Need to understand Blazor more. Come back to this
    }

    public void IncrementIntrest()
    {
        if(IntrestRate <= 0)
        {
            return;
        }

        Debt = Debt + Debt * IntrestRate;
        
    }
}