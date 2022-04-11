using Clase2_Practica.Entidades;
using Clase2_Practica.Servicios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clase2_Practica.Winforms
{
    public partial class CalculadorIMCForm : Form
    {
        private readonly ICalculadorIMCService _calculadorIMCService;

        public CalculadorIMCForm(ICalculadorIMCService calculadorIMCService)
        {
            _calculadorIMCService = calculadorIMCService;
            InitializeComponent();
        }

        private void buttonCalcularIMC_Click(object sender, EventArgs e)
        {
            double peso = Double.Parse(textBoxPeso.Text);
            double altura = Double.Parse(textBoxAltura.Text) / 100;
            CalculadorIMC calculadorIMC = new CalculadorIMC(DateTime.Now, peso, altura);
            CalculadorIMC lastCalculadorIMC = _calculadorIMCService.Nuevo(calculadorIMC);
            labelIMCValue.Text = lastCalculadorIMC.IMC.ToString();
            labelCompCorpValue.Text = lastCalculadorIMC.ComposicionCorporal;
        }

        private void CalculadorIMCForm_Load(object sender, EventArgs e)
        {

        }
    }
}
