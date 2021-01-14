using Calculator.Services;
using Calculator.Services.Interfaces;
using Microsoft.Extensions.DependencyInjection;

namespace Calculator.ConsoleApp
{
    public static class Startup
    {
        public static ServiceProvider ConfigureServices()
        {
            return new ServiceCollection()
                .AddSingleton<ICalculator, CalculatorService>()
                .AddSingleton<IInput, InputService>()
                .BuildServiceProvider();
        }
    }
}
