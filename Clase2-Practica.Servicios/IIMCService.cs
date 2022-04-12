using Clase2_Practica.Entidades;
using System;
using System.Collections.Generic;

namespace Clase2_Practica.Servicios
{
    public interface IIMCService
    {
        public IEnumerable<IMC> ObtenerTodos();
        public IEnumerable<IMC> Insertar(IMC datos);
        public IEnumerable<IMC> Borrar(string nombre);//se borra la informacion con poner el nombre
    }
}