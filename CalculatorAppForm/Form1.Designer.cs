namespace CalculatorAppForm
{
	partial class Calculators
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.tabControl1 = new System.Windows.Forms.TabControl();
			this.TabPage = new System.Windows.Forms.TabPage();
			this.CalcFahrenheit = new System.Windows.Forms.Button();
			this.FahrenheitBox = new System.Windows.Forms.TextBox();
			this.CelsiusBox = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.CalcCelsius = new System.Windows.Forms.Button();
			this.WeightCalculatorPage = new System.Windows.Forms.TabPage();
			this.tabPage3 = new System.Windows.Forms.TabPage();
			this.tabPage4 = new System.Windows.Forms.TabPage();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.CalcKg = new System.Windows.Forms.Button();
			this.CalcLb = new System.Windows.Forms.Button();
			this.KgLabel = new System.Windows.Forms.Label();
			this.LbLabel = new System.Windows.Forms.Label();
			this.tabControl1.SuspendLayout();
			this.TabPage.SuspendLayout();
			this.WeightCalculatorPage.SuspendLayout();
			this.SuspendLayout();
			// 
			// tabControl1
			// 
			this.tabControl1.Controls.Add(this.TabPage);
			this.tabControl1.Controls.Add(this.WeightCalculatorPage);
			this.tabControl1.Controls.Add(this.tabPage3);
			this.tabControl1.Controls.Add(this.tabPage4);
			this.tabControl1.Location = new System.Drawing.Point(12, 12);
			this.tabControl1.Name = "tabControl1";
			this.tabControl1.SelectedIndex = 0;
			this.tabControl1.Size = new System.Drawing.Size(786, 436);
			this.tabControl1.TabIndex = 0;
			// 
			// TabPage
			// 
			this.TabPage.BackColor = System.Drawing.Color.Cyan;
			this.TabPage.Controls.Add(this.label3);
			this.TabPage.Controls.Add(this.CalcFahrenheit);
			this.TabPage.Controls.Add(this.FahrenheitBox);
			this.TabPage.Controls.Add(this.CelsiusBox);
			this.TabPage.Controls.Add(this.label2);
			this.TabPage.Controls.Add(this.label1);
			this.TabPage.Controls.Add(this.CalcCelsius);
			this.TabPage.Location = new System.Drawing.Point(4, 25);
			this.TabPage.Name = "TabPage";
			this.TabPage.Padding = new System.Windows.Forms.Padding(3);
			this.TabPage.Size = new System.Drawing.Size(778, 407);
			this.TabPage.TabIndex = 0;
			this.TabPage.Text = "Temperature";
			this.TabPage.Click += new System.EventHandler(this.tabPage1_Click);
			// 
			// CalcFahrenheit
			// 
			this.CalcFahrenheit.Location = new System.Drawing.Point(353, 228);
			this.CalcFahrenheit.Name = "CalcFahrenheit";
			this.CalcFahrenheit.Size = new System.Drawing.Size(205, 26);
			this.CalcFahrenheit.TabIndex = 5;
			this.CalcFahrenheit.Text = "Calculate Fahrenheit";
			this.CalcFahrenheit.UseVisualStyleBackColor = true;
			this.CalcFahrenheit.Click += new System.EventHandler(this.CalcFahrenheit_Click);
			// 
			// FahrenheitBox
			// 
			this.FahrenheitBox.Location = new System.Drawing.Point(374, 180);
			this.FahrenheitBox.Name = "FahrenheitBox";
			this.FahrenheitBox.Size = new System.Drawing.Size(100, 22);
			this.FahrenheitBox.TabIndex = 4;
			this.FahrenheitBox.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
			// 
			// CelsiusBox
			// 
			this.CelsiusBox.Location = new System.Drawing.Point(220, 180);
			this.CelsiusBox.Name = "CelsiusBox";
			this.CelsiusBox.Size = new System.Drawing.Size(100, 22);
			this.CelsiusBox.TabIndex = 3;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(371, 140);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(113, 26);
			this.label2.TabIndex = 2;
			this.label2.Text = "Fahrenheit";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(236, 140);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(77, 26);
			this.label1.TabIndex = 1;
			this.label1.Text = "Celsius";
			this.label1.Click += new System.EventHandler(this.label1_Click);
			// 
			// CalcCelsius
			// 
			this.CalcCelsius.Location = new System.Drawing.Point(144, 228);
			this.CalcCelsius.Name = "CalcCelsius";
			this.CalcCelsius.Size = new System.Drawing.Size(190, 26);
			this.CalcCelsius.TabIndex = 0;
			this.CalcCelsius.Text = "Calculate Celsius";
			this.CalcCelsius.UseVisualStyleBackColor = true;
			this.CalcCelsius.Click += new System.EventHandler(this.CalcCelsius_Click);
			// 
			// WeightCalculatorPage
			// 
			this.WeightCalculatorPage.BackColor = System.Drawing.Color.Tomato;
			this.WeightCalculatorPage.Controls.Add(this.LbLabel);
			this.WeightCalculatorPage.Controls.Add(this.KgLabel);
			this.WeightCalculatorPage.Controls.Add(this.CalcLb);
			this.WeightCalculatorPage.Controls.Add(this.CalcKg);
			this.WeightCalculatorPage.Controls.Add(this.textBox2);
			this.WeightCalculatorPage.Controls.Add(this.textBox1);
			this.WeightCalculatorPage.Controls.Add(this.label4);
			this.WeightCalculatorPage.Location = new System.Drawing.Point(4, 25);
			this.WeightCalculatorPage.Name = "WeightCalculatorPage";
			this.WeightCalculatorPage.Padding = new System.Windows.Forms.Padding(3);
			this.WeightCalculatorPage.Size = new System.Drawing.Size(778, 407);
			this.WeightCalculatorPage.TabIndex = 1;
			this.WeightCalculatorPage.Text = "Weight";
			// 
			// tabPage3
			// 
			this.tabPage3.Location = new System.Drawing.Point(4, 25);
			this.tabPage3.Name = "tabPage3";
			this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage3.Size = new System.Drawing.Size(778, 407);
			this.tabPage3.TabIndex = 2;
			this.tabPage3.Text = "tabPage3";
			this.tabPage3.UseVisualStyleBackColor = true;
			// 
			// tabPage4
			// 
			this.tabPage4.Location = new System.Drawing.Point(4, 25);
			this.tabPage4.Name = "tabPage4";
			this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage4.Size = new System.Drawing.Size(778, 407);
			this.tabPage4.TabIndex = 3;
			this.tabPage4.Text = "tabPage4";
			this.tabPage4.UseVisualStyleBackColor = true;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(176, 55);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(382, 29);
			this.label3.TabIndex = 6;
			this.label3.Text = "TEMPERATURE CALCULATOR";
			this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(186, 42);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(411, 39);
			this.label4.TabIndex = 0;
			this.label4.Text = "WEIGHT CALCULATOR";
			this.label4.Click += new System.EventHandler(this.label4_Click);
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(392, 157);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(100, 22);
			this.textBox1.TabIndex = 1;
			this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
			// 
			// textBox2
			// 
			this.textBox2.Location = new System.Drawing.Point(392, 254);
			this.textBox2.Name = "textBox2";
			this.textBox2.Size = new System.Drawing.Size(100, 22);
			this.textBox2.TabIndex = 2;
			// 
			// CalcKg
			// 
			this.CalcKg.Location = new System.Drawing.Point(530, 152);
			this.CalcKg.Name = "CalcKg";
			this.CalcKg.Size = new System.Drawing.Size(105, 32);
			this.CalcKg.TabIndex = 3;
			this.CalcKg.Text = "Calculate Kg";
			this.CalcKg.UseVisualStyleBackColor = true;
			// 
			// CalcLb
			// 
			this.CalcLb.Location = new System.Drawing.Point(530, 249);
			this.CalcLb.Name = "CalcLb";
			this.CalcLb.Size = new System.Drawing.Size(105, 32);
			this.CalcLb.TabIndex = 4;
			this.CalcLb.Text = "Calculate Lb";
			this.CalcLb.UseVisualStyleBackColor = true;
			// 
			// KgLabel
			// 
			this.KgLabel.AutoSize = true;
			this.KgLabel.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.KgLabel.Location = new System.Drawing.Point(263, 156);
			this.KgLabel.Name = "KgLabel";
			this.KgLabel.Size = new System.Drawing.Size(107, 26);
			this.KgLabel.TabIndex = 5;
			this.KgLabel.Text = "Kilograms";
			this.KgLabel.Click += new System.EventHandler(this.KgLabel_Click);
			// 
			// LbLabel
			// 
			this.LbLabel.AutoSize = true;
			this.LbLabel.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.LbLabel.Location = new System.Drawing.Point(276, 249);
			this.LbLabel.Name = "LbLabel";
			this.LbLabel.Size = new System.Drawing.Size(81, 26);
			this.LbLabel.TabIndex = 6;
			this.LbLabel.Text = "Pounds";
			this.LbLabel.Click += new System.EventHandler(this.LbLabel_Click);
			// 
			// Calculators
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.tabControl1);
			this.Name = "Calculators";
			this.Text = "Calculators";
			this.tabControl1.ResumeLayout(false);
			this.TabPage.ResumeLayout(false);
			this.TabPage.PerformLayout();
			this.WeightCalculatorPage.ResumeLayout(false);
			this.WeightCalculatorPage.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.TabControl tabControl1;
		private System.Windows.Forms.TabPage TabPage;
		private System.Windows.Forms.TabPage WeightCalculatorPage;
		private System.Windows.Forms.TabPage tabPage3;
		private System.Windows.Forms.TabPage tabPage4;
		private System.Windows.Forms.TextBox FahrenheitBox;
		private System.Windows.Forms.TextBox CelsiusBox;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button CalcCelsius;
		private System.Windows.Forms.Button CalcFahrenheit;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label LbLabel;
		private System.Windows.Forms.Label KgLabel;
		private System.Windows.Forms.Button CalcLb;
		private System.Windows.Forms.Button CalcKg;
		private System.Windows.Forms.TextBox textBox2;
		private System.Windows.Forms.TextBox textBox1;
	}
}

