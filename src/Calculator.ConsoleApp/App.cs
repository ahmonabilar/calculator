using System;
using Calculator.Services.Interfaces;

namespace Calculator.ConsoleApp
{
    public class App
    {
        private readonly ICalculator _calculatorService;
        private readonly IInput _inputService;

        public App(ICalculator calculatorService, IInput inputService)
        {
            _calculatorService = calculatorService;
            _inputService = inputService;
        }
        public void Run()
        {
            char again;
            do
            {
                Console.Clear();
                Console.WriteLine("***Calculator Demo***");
                var first = _inputService.PromptForInteger("Input first number: ");
                var second = _inputService.PromptForInteger("Input second number: ");
                var opr = _inputService.PromptForOperator("Input operator(+, -, / or *): ");
                switch (opr)
                {
                    case '+':
                        Console.WriteLine($"Answer: {_calculatorService.Add(first, second)}");
                        break;
                    case '-':
                        Console.WriteLine($"Answer: {_calculatorService.Subtract(first, second)}");
                        break;
                    case '*':
                        Console.WriteLine($"Answer: {_calculatorService.Multiply(first, second)}");
                        break;
                    case '/':
                        var quotient = _calculatorService.Divide(first, second);

                        Console.WriteLine(double.IsInfinity(quotient) ? $"Answer is infinite." : $"Answer: {quotient}");
                        break;
                }

                Console.Write("Calculate again?");
                again = Console.ReadKey().KeyChar;
            } while (again == 'y' || again == 'Y');
        }
    }
}
