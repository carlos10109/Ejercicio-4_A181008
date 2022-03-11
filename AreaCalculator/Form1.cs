using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AreaCalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void AreaCuadra_Click(object sender, EventArgs e)
        {
            AreaCalcuServiceReference1.AreaCalculatorWebServiceSoapClient ws = new AreaCalcuServiceReference1.AreaCalculatorWebServiceSoapClient();
            ResulCuadra.Text = ws.AreaCuadrado(int.Parse(lados.Text)).ToString();         
        }

        private void AreaTria_Click(object sender, EventArgs e)
        {
            AreaCalcuServiceReference1.AreaCalculatorWebServiceSoapClient ws = new AreaCalcuServiceReference1.AreaCalculatorWebServiceSoapClient();
            ResulTrian.Text = ws.AreaTriangulo(int.Parse(bases.Text), int.Parse(altura.Text));
        }

        private void AreaCir_Click(object sender, EventArgs e)
        {
            AreaCalcuServiceReference1.AreaCalculatorWebServiceSoapClient ws = new AreaCalcuServiceReference1.AreaCalculatorWebServiceSoapClient();
            ResulCir.Text = ws.AreaCirculo(int.Parse(Radio.Text));
        }
    }
}
