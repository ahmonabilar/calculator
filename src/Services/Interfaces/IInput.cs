namespace Calculator.Services.Interfaces
{
    public interface IInput
    {
        int PromptForInteger(string prompt);
        char PromptForOperator(string prompt);
    }
}
