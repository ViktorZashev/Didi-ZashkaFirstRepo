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
	}
}
