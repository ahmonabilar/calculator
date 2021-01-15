using Microsoft.Extensions.DependencyInjection;

namespace Calculator.ConsoleApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var serviceProvider = Startup.ConfigureServices();

            var app = serviceProvider.GetService<IApp>();

            app.Run();
        }
    }
}
