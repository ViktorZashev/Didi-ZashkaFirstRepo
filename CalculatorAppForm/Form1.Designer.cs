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
			this.tabPage2 = new System.Windows.Forms.TabPage();
			this.tabPage3 = new System.Windows.Forms.TabPage();
			this.tabPage4 = new System.Windows.Forms.TabPage();
			this.tabControl1.SuspendLayout();
			this.TabPage.SuspendLayout();
			this.SuspendLayout();
			// 
			// tabControl1
			// 
			this.tabControl1.Controls.Add(this.TabPage);
			this.tabControl1.Controls.Add(this.tabPage2);
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
			this.CalcFahrenheit.Location = new System.Drawing.Point(374, 245);
			this.CalcFahrenheit.Name = "CalcFahrenheit";
			this.CalcFahrenheit.Size = new System.Drawing.Size(158, 23);
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
			this.label2.Location = new System.Drawing.Point(371, 140);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(70, 16);
			this.label2.TabIndex = 2;
			this.label2.Text = "Fahrenheit";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(236, 140);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(51, 16);
			this.label1.TabIndex = 1;
			this.label1.Text = "Celsius";
			// 
			// CalcCelsius
			// 
			this.CalcCelsius.Location = new System.Drawing.Point(220, 245);
			this.CalcCelsius.Name = "CalcCelsius";
			this.CalcCelsius.Size = new System.Drawing.Size(109, 26);
			this.CalcCelsius.TabIndex = 0;
			this.CalcCelsius.Text = "Calculate C";
			this.CalcCelsius.UseVisualStyleBackColor = true;
			this.CalcCelsius.Click += new System.EventHandler(this.CalcCelsius_Click);
			// 
			// tabPage2
			// 
			this.tabPage2.Location = new System.Drawing.Point(4, 25);
			this.tabPage2.Name = "tabPage2";
			this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage2.Size = new System.Drawing.Size(778, 407);
			this.tabPage2.TabIndex = 1;
			this.tabPage2.Text = "tabPage2";
			this.tabPage2.UseVisualStyleBackColor = true;
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
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.TabControl tabControl1;
		private System.Windows.Forms.TabPage TabPage;
		private System.Windows.Forms.TabPage tabPage2;
		private System.Windows.Forms.TabPage tabPage3;
		private System.Windows.Forms.TabPage tabPage4;
		private System.Windows.Forms.TextBox FahrenheitBox;
		private System.Windows.Forms.TextBox CelsiusBox;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button CalcCelsius;
		private System.Windows.Forms.Button CalcFahrenheit;
	}
}

