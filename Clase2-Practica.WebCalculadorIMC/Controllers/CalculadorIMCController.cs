using Clase2_Practica.Entidades;
using Clase2_Practica.Servicios;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Clase2_Practica.WebCalculadorIMC.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CalculadorIMCController : ControllerBase
    {
        private readonly ILogger<CalculadorIMCController> _logger;
        private readonly ICalculadorIMCService _calculadorIMCService;

        public CalculadorIMCController(ILogger<CalculadorIMCController> logger, ICalculadorIMCService calculadorIMCService)
        {
            _logger = logger;
            _calculadorIMCService = calculadorIMCService;
        }

        [HttpGet]
        public IEnumerable<CalculadorIMC> Get()
        {
            return _calculadorIMCService.ObtenerTodos();
        }

        [HttpPost]
        public CalculadorIMC Post(CalculadorIMC calculadorIMC)
        {
            return _calculadorIMCService.Nuevo(calculadorIMC);
        }

        [HttpDelete]
        public IEnumerable<CalculadorIMC> Delete(DateTime calculadorIMCDate)
        {
            return _calculadorIMCService.Borrar(calculadorIMCDate);
        }
    }
}
