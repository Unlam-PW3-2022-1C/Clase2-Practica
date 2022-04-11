using CalculadoraIMC.Servicios.Implementaciones;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace WebCalculadoraIMC.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CalculatorImcController : ControllerBase
    {
        private readonly ILogger<CalculatorImcController> _logger;
        private readonly ICalculatorImcService _calculatorImcService;

        public CalculatorImcController(ILogger<CalculatorImcController> logger, ICalculatorImcService calculatorImcService)
        {
            _logger = logger;
            _calculatorImcService = calculatorImcService;
        }

        [HttpGet]
        public double Get(double peso, double altura)
        {
            return _calculatorImcService.CalcularIMC(peso, altura);
        }
    }
}
