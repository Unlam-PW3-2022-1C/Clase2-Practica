using Clase2_Practica.Servicios.Implementaciones;
using Microsoft.AspNetCore.Mvc;

namespace Clase2_Practica.Web.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CalculadorIMCController : ControllerBase
    {
        readonly ICalculadorIMCService _calculadorIMCService;

        public CalculadorIMCController(ICalculadorIMCService calculadorIMCService)
        {
            _calculadorIMCService = calculadorIMCService;
        }

        [HttpGet]
        [Route("")]
        public double GetIMC(float peso, float altura)
        {
            return _calculadorIMCService.CalcularIMC(peso, altura);
        }
    }
}
