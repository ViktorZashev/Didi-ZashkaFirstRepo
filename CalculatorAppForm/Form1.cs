using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculatorAppForm
{
	public partial class Calculators : Form
	{
		public Calculators()
		{
			InitializeComponent();
		}
		private void tabPage1_Click(object sender, EventArgs e)
		{

		}
		private void textBox2_TextChanged(object sender, EventArgs e)
		{

		}
		private void CalcCelsius_Click(object sender, EventArgs e)
		{
			
			var Fahrenheit = double.Parse(FahrenheitBox.Text);
			double Celsius = Math.Round((double) 5 / 9 * (Fahrenheit - 32),2);
			CelsiusBox.Text = Celsius.ToString();
		}

		private void CalcFahrenheit_Click(object sender, EventArgs e)
		{
			var Celsius = double.Parse(CelsiusBox.Text);
			double Fahrenheit = Math.Round(((double)5 / 9 * Celsius) + 32, 2);
			FahrenheitBox.Text = Fahrenheit.ToString();
		}

		private void label1_Click(object sender, EventArgs e)
		{

		}

		private void label4_Click(object sender, EventArgs e)
		{

		}

		private void textBox1_TextChanged(object sender, EventArgs e)
		{

		}

		private void KgLabel_Click(object sender, EventArgs e)
		{

		}

		private void LbLabel_Click(object sender, EventArgs e)
		{

		}

		private void CalcKg_Click(object sender, EventArgs e)
		{
			var pounds = double.Parse(LbBox.Text);
			var kg = Math.Round(pounds * 0.453, 2);
			KgBox.Text = kg.ToString();
		}

		private void CalcLb_Click(object sender, EventArgs e)
		{
			var kg = double.Parse(KgBox.Text);
			var lbs = Math.Round(kg * 2.20, 2);
			LbBox.Text = lbs.ToString();
		}

        private void CelsiusBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void Calculators_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var leva = double.Parse(LevaBox.Text);
            var euro = Math.Round(leva * 0.51, 2);
            EuroBox.Text = euro.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var euro = double.Parse(EuroBox.Text);
            var leva = Math.Round(euro * 1.51, 2);
            LevaBox.Text = leva.ToString();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void LevaBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void tabPage3_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void Calculate_Click(object sender, EventArgs e)
        {
			var density = double.Parse(Density.Text);
			var volume = double.Parse(Volume.Text);
			Output.Text = (density/volume).ToString();
        }

        private void Output_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
