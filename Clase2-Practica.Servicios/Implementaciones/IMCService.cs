using Clase2_Practica.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Clase2_Practica.Servicios.Implementacines
{
    public class IMCService : IIMCService
    {
        private static List<IMC> IMCList = new List<IMC>();//traigo la listas de la clase IMC
         
        public IEnumerable<IMC> ObtenerTodos()
        {
            return IMCList;//muestro la lista.
        }

        public IEnumerable<IMC> Insertar(IMC imc) //recibo la info que cargue por pantalla
        {   
            imc.Date = DateTime.Now;    //le agrego la fecha actual al nuevo insert
            
            imc.Imc = imc.Peso / (imc.Altura * imc.Altura);//le calculo el IMC
            IMCList.Add(imc); //lo guardo en la lista
            return IMCList; // devuelvo la lista para ver los nuevos cambios
        }

        public IEnumerable<IMC> Borrar(string nombre)// ingreso el nombre para
                                                     // borrar el elemento de la lista
        {
            IMCList.RemoveAll(x => x.Nombre == nombre);//remuevo el objeto cuyo nombre sea =
                                                       //al que le pase por parametro.
                                                       //Seria mejor un DNI o ID
            
            return IMCList;
        }

    }
}
