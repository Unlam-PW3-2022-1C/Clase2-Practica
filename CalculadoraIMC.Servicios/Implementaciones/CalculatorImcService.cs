using CalculadoraIMC.Servicios.Implementaciones;
using CalculadoraIMC.Entidades;

namespace CalculadoraIMC.Servicios
{
    public class CalculatorImcService : ICalculatorImcService
    {
        public double CalcularIMC(double peso, double altura)
        {
            CalculatorImc calculatorImc = new CalculatorImc(peso, altura);

            return calculatorImc.imc;
        }
    }
}
