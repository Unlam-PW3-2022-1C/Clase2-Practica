using Clase2_Practica.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase2_Practica.Servicios.Implementaciones
{
    public class CalculadorIMCService : ICalculadorIMCService
    {
        private static List<CalculadorIMC> _listIMC = new List<CalculadorIMC>();

        private static string[] _composicionCorporal = new string[]
        {
            "Delgadez severa",
            "Delgadez moderada",
            "Delgadez leve",
            "Normal",
            "Preobesidad",
            "Obesidad leve",
            "Obesidad media",
            "Obesidad mórbida"
        };

        public IEnumerable<CalculadorIMC> ObtenerTodos()
        {
            return _listIMC;
        }
        #region 
        /*public IEnumerable<CalculadorIMC> Get(int IMCsToAdd)
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
        public IEnumerable<CalculadorIMC> Nuevo(CalculadorIMC calculadorIMC)
        {
            if (calculadorIMC.IMC < 16)
                calculadorIMC.ComposicionCorporal = _composicionCorporal[0];
            if (calculadorIMC.IMC >= 16 && calculadorIMC.IMC < 17)
                calculadorIMC.ComposicionCorporal = _composicionCorporal[1];
            if (calculadorIMC.IMC >= 17 && calculadorIMC.IMC < 18.5)
                calculadorIMC.ComposicionCorporal = _composicionCorporal[2];
            if (calculadorIMC.IMC >= 18.5 && calculadorIMC.IMC < 25)
                calculadorIMC.ComposicionCorporal = _composicionCorporal[3];
            if (calculadorIMC.IMC >= 25 && calculadorIMC.IMC < 30)
                calculadorIMC.ComposicionCorporal = _composicionCorporal[4];
            if (calculadorIMC.IMC >= 30 && calculadorIMC.IMC < 35)
                calculadorIMC.ComposicionCorporal = _composicionCorporal[5];
            if (calculadorIMC.IMC >= 35 && calculadorIMC.IMC < 40)
                calculadorIMC.ComposicionCorporal = _composicionCorporal[6];
            if (calculadorIMC.IMC >= 40)
                calculadorIMC.ComposicionCorporal = _composicionCorporal[7];
            _listIMC.Add(calculadorIMC);
            return _listIMC;
        }

        public IEnumerable<CalculadorIMC> Borrar(DateTime calculadorIMCDate)
        {
            _listIMC.RemoveAll(item => item.Date == calculadorIMCDate);
            #region
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
            return _listIMC;
        }
    }
}
