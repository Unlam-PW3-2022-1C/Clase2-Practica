using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase2_Practica.Servicios.Implementaciones
{
    public class CalculadorIMCService : ICalculadorIMCService
    {

        public double CalcularIMC(float peso, float altura)
        {
            var imc = peso / (Math.Pow(altura, 2));

            return imc; 
        }
    }
}
