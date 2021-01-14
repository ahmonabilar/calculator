using Microsoft.AspNetCore.Mvc;
using Calculator.Services.Interfaces;
using Calculator.WebApp.Models;

namespace Calculator.WebApp.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CalculatorController : ControllerBase
    {
        private readonly ICalculator _calculatorService;

        public CalculatorController(ICalculator calculatorService)
        {
            _calculatorService = calculatorService;
        }

        [HttpPost]
        public string Post(InputModel input)
        {
            var result = string.Empty;
            switch (input.Operator)
            {
                case '+':
                    result = _calculatorService.Add(input.First, input.Second).ToString();
                    break;
                case '-':
                    result = _calculatorService.Subtract(input.First, input.Second).ToString();
                    break;
                case '*':
                    result = _calculatorService.Multiply(input.First, input.Second).ToString();
                    break;
                case '/':
                    var quotient = _calculatorService.Divide(input.First, input.Second);

                    result = double.IsInfinity(quotient) ? $"Infinite" : quotient.ToString("0.##");
                    break;
            }

            return result;
        }
    }
}
