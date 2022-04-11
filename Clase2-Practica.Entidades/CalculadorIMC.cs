using System;

namespace Clase2_Practica.Entidades
{
    public class CalculadorIMC
    {
        public CalculadorIMC(DateTime date, double peso, double altura)
        {
            Date = date;
            Peso = peso;
            Altura = altura;
        }

        public DateTime Date { get; set; }

        public double Peso { get; set; }

        public double Altura { get; set; }

        public double IMC => Peso / Math.Pow(Altura, 2);

        public string ComposicionCorporal { get; set; }
    }
}
