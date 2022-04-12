using Clase2_Practica.Entidades;
using Clase2_Practica.Servicios;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Clase2_Practica.Web.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class IMCController : ControllerBase
    {
      
        private readonly IIMCService _IMCService;

        public IMCController(IIMCService IMCService)//inyeccion de dependencia.
        {
            _IMCService = IMCService;
        }

        [HttpGet]
        public IEnumerable<IMC> Get()
        {
            return _IMCService.ObtenerTodos();
        }

        [HttpPost]
        public IEnumerable<IMC> Post(IMC datos)
        {
            return _IMCService.Insertar(datos);
        }

        [HttpDelete]
        public IEnumerable<IMC> Delete(string nombre)
        {
            return _IMCService.Borrar(nombre);
        }
    }
}
