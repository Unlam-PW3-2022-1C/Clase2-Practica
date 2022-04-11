using Clase2_Practica.Entidades;
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
        private static List<CalculadorIMC> IMCList = new List<CalculadorIMC>();

        private static string[] ComposicionCorporal = new string[]
        {
            "Peso inferior al normal",
            "Normal",
            "Peso superior al normal",
            "Obesidad"
        };

        private readonly ILogger<CalculadorIMCController> _logger;

        public CalculadorIMCController(ILogger<CalculadorIMCController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IEnumerable<CalculadorIMC> Get()
        {
            return IMCList;
        }

        #region option populate IMCList
        /*[HttpGet]
        public IEnumerable<CalculadorIMC> Get(int IMCsToAdd)
        {
            var rng = new Random();
            var arrayIMCs = Enumerable.Range(1, IMCsToAdd).Select(index => new CalculadorIMC
            {
                Date = DateTime.Now.AddDays(index),
                Peso = rng.Next(50, 150),
                Altura = (double)rng.Next(150, 210) / 100,
                ComposicionCorporal = ComposicionCorporal[rng.Next(ComposicionCorporal.Length)]
            })
            .ToArray();
            foreach (CalculadorIMC item in arrayIMCs)
            {
                IMCList.Add(item);
            }
            return IMCList;
        }*/
        #endregion

        [HttpPost]
        public IEnumerable<CalculadorIMC> Post(CalculadorIMC calculadorIMC)
        {
            IMCList.Add(calculadorIMC);
            return IMCList;
        }

        [HttpDelete]
        public IEnumerable<CalculadorIMC> Delete(DateTime calculadorIMCDate)
        {
            IMCList.RemoveAll(item => item.Date == calculadorIMCDate);
            #region delete oldSchool
            /*CalculadorIMC itemABorrar = null;
            foreach (var item in IMCList)
            {
                if (item.Date == calculadorIMCDate)
                {
                    itemABorrar = item;
                }
            }
            if (itemABorrar != null)
            {
                IMCList.Remove(itemABorrar);
            }*/
            #endregion
            return IMCList;
        }
    }
}
