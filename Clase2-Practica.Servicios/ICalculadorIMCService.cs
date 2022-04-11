using Clase2_Practica.Entidades;
using System;
using System.Collections.Generic;

namespace Clase2_Practica.Servicios
{
    public interface ICalculadorIMCService
    {
        public IEnumerable<CalculadorIMC> ObtenerTodos();
        public CalculadorIMC Nuevo(CalculadorIMC calculadorIMC);
        public IEnumerable<CalculadorIMC> Borrar(DateTime calculadorIMCDate);
    }
}