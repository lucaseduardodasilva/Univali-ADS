using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConversorDeMoedasLucas
{
    public partial class Form1 : Form
    {
        double real = 0;
        double formulaDolar = 0.18;
        double formulaEuro = 0.16;
        double formulaRublo = 13.5;
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnConverter_Click(object sender, EventArgs e)
        {
            real = double.Parse(txtbReal.Text, CultureInfo.InvariantCulture);       
            double dolar = real * formulaDolar;
            txtbDolar.Text = dolar.ToString(CultureInfo.InvariantCulture);

            double euro = real * formulaEuro;
            txtbEuro.Text = euro.ToString(CultureInfo.InvariantCulture);

            double rublo = real * formulaRublo;
            txtbRublo.Text = rublo.ToString(CultureInfo.InvariantCulture);


        }
    }
}
