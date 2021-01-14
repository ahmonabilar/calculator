namespace Calculator.Services.Interfaces
{
    public interface ICalculator
    {
        int Add(int first, int second);
        int Subtract(int first, int second);
        int Multiply(int first, int second);
        double Divide(int dividend, int divisor);
    }
}
