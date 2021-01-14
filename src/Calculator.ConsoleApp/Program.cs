using Microsoft.Extensions.DependencyInjection;
using Calculator.Services.Interfaces;

namespace Calculator.ConsoleApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var serviceProvider = Startup.ConfigureServices();
            var calculator = serviceProvider.GetService<ICalculator>();
            var input = serviceProvider.GetService<IInput>();

            var app = new App(calculator, input);

            app.Run();
        }
    }
}
