namespace CalculadoraIMC.Entidades
{
    public class CalculatorImc
    {
        public double peso { get; set; }
        public double altura { get; set; }
        public double imc { get; set; }

        public CalculatorImc(double peso, double altura) {
            this.peso = peso;
            this.altura = altura;
            this.imc = peso / (altura * altura);
        }

    }
}
