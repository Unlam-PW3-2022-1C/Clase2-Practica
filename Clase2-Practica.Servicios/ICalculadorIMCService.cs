using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase2_Practica.Servicios.Implementaciones
{
    public interface ICalculadorIMCService
    {
        double CalcularIMC(float peso, float altura);
    }
}
