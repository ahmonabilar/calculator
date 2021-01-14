using Calculator.Services;

namespace Calculator.Test
{
    public class InputRetriever: InputService
    {
        public override int PromptForInteger(string prompt)
        {
            return 3;
        }
        public override char PromptForOperator(string prompt)
        {
            return '+';
        }
    }
}
