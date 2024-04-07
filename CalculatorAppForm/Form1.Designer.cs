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
            this.s = new System.Windows.Forms.TabControl();
            this.TabPage = new System.Windows.Forms.TabPage();
            this.label3 = new System.Windows.Forms.Label();
            this.CalcFahrenheit = new System.Windows.Forms.Button();
            this.FahrenheitBox = new System.Windows.Forms.TextBox();
            this.CelsiusBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.CalcCelsius = new System.Windows.Forms.Button();
            this.WeightCalculatorPage = new System.Windows.Forms.TabPage();
            this.LbLabel = new System.Windows.Forms.Label();
            this.KgLabel = new System.Windows.Forms.Label();
            this.CalcLb = new System.Windows.Forms.Button();
            this.CalcKg = new System.Windows.Forms.Button();
            this.LbBox = new System.Windows.Forms.TextBox();
            this.KgBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.LevaBox = new System.Windows.Forms.TextBox();
            this.EuroBox = new System.Windows.Forms.TextBox();
            this.LevaButton = new System.Windows.Forms.Button();
            this.EuroButton = new System.Windows.Forms.Button();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.Density = new System.Windows.Forms.TextBox();
            this.Volume = new System.Windows.Forms.TextBox();
            this.Output = new System.Windows.Forms.TextBox();
            this.Calculatemass = new System.Windows.Forms.Button();
            this.s.SuspendLayout();
            this.TabPage.SuspendLayout();
            this.WeightCalculatorPage.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.SuspendLayout();
            // 
            // s
            // 
            this.s.AccessibleName = "h";
            this.s.Controls.Add(this.TabPage);
            this.s.Controls.Add(this.WeightCalculatorPage);
            this.s.Controls.Add(this.tabPage3);
            this.s.Controls.Add(this.tabPage4);
            this.s.Location = new System.Drawing.Point(9, 10);
            this.s.Margin = new System.Windows.Forms.Padding(2);
            this.s.Name = "s";
            this.s.SelectedIndex = 0;
            this.s.Size = new System.Drawing.Size(590, 354);
            this.s.TabIndex = 0;
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
            this.TabPage.Location = new System.Drawing.Point(4, 22);
            this.TabPage.Margin = new System.Windows.Forms.Padding(2);
            this.TabPage.Name = "TabPage";
            this.TabPage.Padding = new System.Windows.Forms.Padding(2);
            this.TabPage.Size = new System.Drawing.Size(582, 328);
            this.TabPage.TabIndex = 0;
            this.TabPage.Text = "Temperature";
            this.TabPage.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(132, 45);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(305, 24);
            this.label3.TabIndex = 6;
            this.label3.Text = "TEMPERATURE CALCULATOR";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // CalcFahrenheit
            // 
            this.CalcFahrenheit.Location = new System.Drawing.Point(265, 185);
            this.CalcFahrenheit.Margin = new System.Windows.Forms.Padding(2);
            this.CalcFahrenheit.Name = "CalcFahrenheit";
            this.CalcFahrenheit.Size = new System.Drawing.Size(154, 21);
            this.CalcFahrenheit.TabIndex = 5;
            this.CalcFahrenheit.Text = "Calculate Fahrenheit";
            this.CalcFahrenheit.UseVisualStyleBackColor = true;
            this.CalcFahrenheit.Click += new System.EventHandler(this.CalcFahrenheit_Click);
            // 
            // FahrenheitBox
            // 
            this.FahrenheitBox.Location = new System.Drawing.Point(280, 146);
            this.FahrenheitBox.Margin = new System.Windows.Forms.Padding(2);
            this.FahrenheitBox.Name = "FahrenheitBox";
            this.FahrenheitBox.Size = new System.Drawing.Size(76, 20);
            this.FahrenheitBox.TabIndex = 4;
            this.FahrenheitBox.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // CelsiusBox
            // 
            this.CelsiusBox.Location = new System.Drawing.Point(165, 146);
            this.CelsiusBox.Margin = new System.Windows.Forms.Padding(2);
            this.CelsiusBox.Name = "CelsiusBox";
            this.CelsiusBox.Size = new System.Drawing.Size(76, 20);
            this.CelsiusBox.TabIndex = 3;
            this.CelsiusBox.Text = "0";
            this.CelsiusBox.TextChanged += new System.EventHandler(this.CelsiusBox_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(278, 114);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 21);
            this.label2.TabIndex = 2;
            this.label2.Text = "Fahrenheit";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(177, 114);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "Celsius";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // CalcCelsius
            // 
            this.CalcCelsius.Location = new System.Drawing.Point(108, 185);
            this.CalcCelsius.Margin = new System.Windows.Forms.Padding(2);
            this.CalcCelsius.Name = "CalcCelsius";
            this.CalcCelsius.Size = new System.Drawing.Size(142, 21);
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
            this.WeightCalculatorPage.Controls.Add(this.LbBox);
            this.WeightCalculatorPage.Controls.Add(this.KgBox);
            this.WeightCalculatorPage.Controls.Add(this.label4);
            this.WeightCalculatorPage.Location = new System.Drawing.Point(4, 22);
            this.WeightCalculatorPage.Margin = new System.Windows.Forms.Padding(2);
            this.WeightCalculatorPage.Name = "WeightCalculatorPage";
            this.WeightCalculatorPage.Padding = new System.Windows.Forms.Padding(2);
            this.WeightCalculatorPage.Size = new System.Drawing.Size(582, 328);
            this.WeightCalculatorPage.TabIndex = 1;
            this.WeightCalculatorPage.Text = "Weight";
            // 
            // LbLabel
            // 
            this.LbLabel.AutoSize = true;
            this.LbLabel.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbLabel.Location = new System.Drawing.Point(207, 202);
            this.LbLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LbLabel.Name = "LbLabel";
            this.LbLabel.Size = new System.Drawing.Size(67, 21);
            this.LbLabel.TabIndex = 6;
            this.LbLabel.Text = "Pounds";
            this.LbLabel.Click += new System.EventHandler(this.LbLabel_Click);
            // 
            // KgLabel
            // 
            this.KgLabel.AutoSize = true;
            this.KgLabel.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KgLabel.Location = new System.Drawing.Point(197, 127);
            this.KgLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.KgLabel.Name = "KgLabel";
            this.KgLabel.Size = new System.Drawing.Size(87, 21);
            this.KgLabel.TabIndex = 5;
            this.KgLabel.Text = "Kilograms";
            this.KgLabel.Click += new System.EventHandler(this.KgLabel_Click);
            // 
            // CalcLb
            // 
            this.CalcLb.Location = new System.Drawing.Point(398, 202);
            this.CalcLb.Margin = new System.Windows.Forms.Padding(2);
            this.CalcLb.Name = "CalcLb";
            this.CalcLb.Size = new System.Drawing.Size(79, 26);
            this.CalcLb.TabIndex = 4;
            this.CalcLb.Text = "Calculate Lb";
            this.CalcLb.UseVisualStyleBackColor = true;
            this.CalcLb.Click += new System.EventHandler(this.CalcLb_Click);
            // 
            // CalcKg
            // 
            this.CalcKg.Location = new System.Drawing.Point(398, 124);
            this.CalcKg.Margin = new System.Windows.Forms.Padding(2);
            this.CalcKg.Name = "CalcKg";
            this.CalcKg.Size = new System.Drawing.Size(79, 26);
            this.CalcKg.TabIndex = 3;
            this.CalcKg.Text = "Calculate Kg";
            this.CalcKg.UseVisualStyleBackColor = true;
            this.CalcKg.Click += new System.EventHandler(this.CalcKg_Click);
            // 
            // LbBox
            // 
            this.LbBox.Location = new System.Drawing.Point(294, 206);
            this.LbBox.Margin = new System.Windows.Forms.Padding(2);
            this.LbBox.Name = "LbBox";
            this.LbBox.Size = new System.Drawing.Size(76, 20);
            this.LbBox.TabIndex = 2;
            // 
            // KgBox
            // 
            this.KgBox.Location = new System.Drawing.Point(294, 128);
            this.KgBox.Margin = new System.Windows.Forms.Padding(2);
            this.KgBox.Name = "KgBox";
            this.KgBox.Size = new System.Drawing.Size(76, 20);
            this.KgBox.TabIndex = 1;
            this.KgBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(140, 34);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(331, 31);
            this.label4.TabIndex = 0;
            this.label4.Text = "WEIGHT CALCULATOR";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.LightSalmon;
            this.tabPage3.Controls.Add(this.label7);
            this.tabPage3.Controls.Add(this.label6);
            this.tabPage3.Controls.Add(this.label5);
            this.tabPage3.Controls.Add(this.LevaBox);
            this.tabPage3.Controls.Add(this.EuroBox);
            this.tabPage3.Controls.Add(this.LevaButton);
            this.tabPage3.Controls.Add(this.EuroButton);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage3.Size = new System.Drawing.Size(582, 328);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Euro to Leva Calc";
            this.tabPage3.Click += new System.EventHandler(this.tabPage3_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(199, 37);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(128, 24);
            this.label7.TabIndex = 8;
            this.label7.Text = "Euro to Leva";
            this.label7.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(326, 119);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 21);
            this.label6.TabIndex = 7;
            this.label6.Text = "Leva";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(131, 119);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 21);
            this.label5.TabIndex = 6;
            this.label5.Text = "Euro";
            // 
            // LevaBox
            // 
            this.LevaBox.Location = new System.Drawing.Point(313, 155);
            this.LevaBox.Margin = new System.Windows.Forms.Padding(2);
            this.LevaBox.Name = "LevaBox";
            this.LevaBox.Size = new System.Drawing.Size(76, 20);
            this.LevaBox.TabIndex = 5;
            this.LevaBox.TextChanged += new System.EventHandler(this.LevaBox_TextChanged);
            // 
            // EuroBox
            // 
            this.EuroBox.Location = new System.Drawing.Point(118, 155);
            this.EuroBox.Margin = new System.Windows.Forms.Padding(2);
            this.EuroBox.Name = "EuroBox";
            this.EuroBox.Size = new System.Drawing.Size(76, 20);
            this.EuroBox.TabIndex = 4;
            this.EuroBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // LevaButton
            // 
            this.LevaButton.Location = new System.Drawing.Point(313, 193);
            this.LevaButton.Name = "LevaButton";
            this.LevaButton.Size = new System.Drawing.Size(76, 23);
            this.LevaButton.TabIndex = 1;
            this.LevaButton.Text = "Calc Leva";
            this.LevaButton.UseVisualStyleBackColor = true;
            this.LevaButton.Click += new System.EventHandler(this.button2_Click);
            // 
            // EuroButton
            // 
            this.EuroButton.Location = new System.Drawing.Point(118, 193);
            this.EuroButton.Name = "EuroButton";
            this.EuroButton.Size = new System.Drawing.Size(76, 23);
            this.EuroButton.TabIndex = 0;
            this.EuroButton.Text = "Calc Euro";
            this.EuroButton.UseVisualStyleBackColor = true;
            this.EuroButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // tabPage4
            // 
            this.tabPage4.BackColor = System.Drawing.Color.AntiqueWhite;
            this.tabPage4.Controls.Add(this.Calculatemass);
            this.tabPage4.Controls.Add(this.Output);
            this.tabPage4.Controls.Add(this.Volume);
            this.tabPage4.Controls.Add(this.Density);
            this.tabPage4.Controls.Add(this.label10);
            this.tabPage4.Controls.Add(this.label9);
            this.tabPage4.Controls.Add(this.label8);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage4.Size = new System.Drawing.Size(582, 328);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Mass calc";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(184, 42);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(157, 24);
            this.label8.TabIndex = 9;
            this.label8.Text = "Mass Calculator";
            this.label8.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(136, 121);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(68, 21);
            this.label9.TabIndex = 10;
            this.label9.Text = "Density";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(134, 168);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(70, 21);
            this.label10.TabIndex = 11;
            this.label10.Text = "Volume";
            // 
            // Density
            // 
            this.Density.Location = new System.Drawing.Point(252, 122);
            this.Density.Margin = new System.Windows.Forms.Padding(2);
            this.Density.Name = "Density";
            this.Density.Size = new System.Drawing.Size(76, 20);
            this.Density.TabIndex = 12;
            // 
            // Volume
            // 
            this.Volume.Location = new System.Drawing.Point(252, 169);
            this.Volume.Margin = new System.Windows.Forms.Padding(2);
            this.Volume.Name = "Volume";
            this.Volume.Size = new System.Drawing.Size(76, 20);
            this.Volume.TabIndex = 13;
            // 
            // Output
            // 
            this.Output.Location = new System.Drawing.Point(210, 262);
            this.Output.Margin = new System.Windows.Forms.Padding(2);
            this.Output.Name = "Output";
            this.Output.Size = new System.Drawing.Size(76, 20);
            this.Output.TabIndex = 14;
            this.Output.TextChanged += new System.EventHandler(this.Output_TextChanged);
            // 
            // Calculatemass
            // 
            this.Calculatemass.Location = new System.Drawing.Point(198, 225);
            this.Calculatemass.Name = "Calculatemass";
            this.Calculatemass.Size = new System.Drawing.Size(107, 23);
            this.Calculatemass.TabIndex = 15;
            this.Calculatemass.Text = "Calculate";
            this.Calculatemass.UseVisualStyleBackColor = true;
            this.Calculatemass.Click += new System.EventHandler(this.Calculate_Click);
            // 
            // Calculators
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.s);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Calculators";
            this.Text = "Calculators";
            this.Load += new System.EventHandler(this.Calculators_Load);
            this.s.ResumeLayout(false);
            this.TabPage.ResumeLayout(false);
            this.TabPage.PerformLayout();
            this.WeightCalculatorPage.ResumeLayout(false);
            this.WeightCalculatorPage.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.TabControl s;
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
		private System.Windows.Forms.TextBox LbBox;
		private System.Windows.Forms.TextBox KgBox;
        private System.Windows.Forms.Button LevaButton;
        private System.Windows.Forms.Button EuroButton;
        private System.Windows.Forms.TextBox LevaBox;
        private System.Windows.Forms.TextBox EuroBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button Calculatemass;
        private System.Windows.Forms.TextBox Output;
        private System.Windows.Forms.TextBox Volume;
        private System.Windows.Forms.TextBox Density;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
    }
}

