using System;

namespace Clase2_Practica.Entidades
{
    public class IMC
    {
        public DateTime Date { get; set; }

        public string Nombre { get; set; } //por que aparece "string" en el json?

        public double Peso { get; set; }

        public double Altura { get; set; } //que es esto?

        public double Imc { get; set; } // como evitar modificarlo en la pantalla?

    }
}
