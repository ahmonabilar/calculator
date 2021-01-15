using Calculator.Services;
using Calculator.Services.Interfaces;
using Microsoft.Extensions.DependencyInjection;

namespace Calculator.ConsoleApp
{
    public static class Startup
    {
        /// <summary>
        /// Used to initialize calculator and input services
        /// </summary>
        /// <returns>Service provider</returns>
        public static ServiceProvider ConfigureServices()
        {
            return new ServiceCollection()
                .AddSingleton<ICalculator, CalculatorService>()
                .AddSingleton<IInput, InputService>()
                .AddSingleton<IApp, App>()
                .BuildServiceProvider();
        }
    }
}
