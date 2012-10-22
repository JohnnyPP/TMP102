namespace TEMP102
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.button1Connect = new System.Windows.Forms.Button();
            this.button2Disconnect = new System.Windows.Forms.Button();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4Std = new System.Windows.Forms.Label();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label4 = new System.Windows.Forms.Label();
            this.label5Mittel = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6Zentral = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label73xStd = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9Min = new System.Windows.Forms.Label();
            this.label9Max = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11Schiefe = new System.Windows.Forms.Label();
            this.label11Wolbung = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1Connect
            // 
            this.button1Connect.Location = new System.Drawing.Point(12, 12);
            this.button1Connect.Name = "button1Connect";
            this.button1Connect.Size = new System.Drawing.Size(127, 23);
            this.button1Connect.TabIndex = 0;
            this.button1Connect.Text = "Connect to sensor";
            this.button1Connect.UseVisualStyleBackColor = true;
            this.button1Connect.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2Disconnect
            // 
            this.button2Disconnect.Location = new System.Drawing.Point(12, 41);
            this.button2Disconnect.Name = "button2Disconnect";
            this.button2Disconnect.Size = new System.Drawing.Size(127, 23);
            this.button2Disconnect.TabIndex = 1;
            this.button2Disconnect.Text = "Disconnect from sensor";
            this.button2Disconnect.UseVisualStyleBackColor = true;
            this.button2Disconnect.Click += new System.EventHandler(this.button2Disconnect_Click);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(104, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Temperature";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Temperatur [°C]:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 202);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(134, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Standard abweichung [°C]:";
            // 
            // label4Std
            // 
            this.label4Std.AutoSize = true;
            this.label4Std.Location = new System.Drawing.Point(160, 202);
            this.label4Std.Name = "label4Std";
            this.label4Std.Size = new System.Drawing.Size(23, 13);
            this.label4Std.TabIndex = 4;
            this.label4Std.Text = "Std";
            // 
            // chart1
            // 
            chartArea1.AxisX.Title = "Zeit [s]";
            chartArea1.AxisX.TitleFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            chartArea1.AxisY.Title = "Temperatur [°C]";
            chartArea1.AxisY.TitleFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            this.chart1.Location = new System.Drawing.Point(249, 12);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Name = "Series1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(697, 374);
            this.chart1.TabIndex = 5;
            this.chart1.Text = "chart1";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 124);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Mittelwert [°C]:";
            // 
            // label5Mittel
            // 
            this.label5Mittel.AutoSize = true;
            this.label5Mittel.Location = new System.Drawing.Point(107, 124);
            this.label5Mittel.Name = "label5Mittel";
            this.label5Mittel.Size = new System.Drawing.Size(32, 13);
            this.label5Mittel.TabIndex = 7;
            this.label5Mittel.Text = "Mittel";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 163);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Zentralwert [°C]:";
            // 
            // label6Zentral
            // 
            this.label6Zentral.AutoSize = true;
            this.label6Zentral.Location = new System.Drawing.Point(110, 163);
            this.label6Zentral.Name = "label6Zentral";
            this.label6Zentral.Size = new System.Drawing.Size(40, 13);
            this.label6Zentral.TabIndex = 9;
            this.label6Zentral.Text = "Zentral";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 236);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(145, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "3xStandard abweichung [°C]:";
            // 
            // label73xStd
            // 
            this.label73xStd.AutoSize = true;
            this.label73xStd.Location = new System.Drawing.Point(160, 236);
            this.label73xStd.Name = "label73xStd";
            this.label73xStd.Size = new System.Drawing.Size(34, 13);
            this.label73xStd.TabIndex = 11;
            this.label73xStd.Text = "3xStd";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(9, 265);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Min [°C]:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(9, 295);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(50, 13);
            this.label8.TabIndex = 13;
            this.label8.Text = "Max [°C]:";
            // 
            // label9Min
            // 
            this.label9Min.AutoSize = true;
            this.label9Min.Location = new System.Drawing.Point(81, 265);
            this.label9Min.Name = "label9Min";
            this.label9Min.Size = new System.Drawing.Size(24, 13);
            this.label9Min.TabIndex = 14;
            this.label9Min.Text = "Min";
            // 
            // label9Max
            // 
            this.label9Max.AutoSize = true;
            this.label9Max.Location = new System.Drawing.Point(81, 295);
            this.label9Max.Name = "label9Max";
            this.label9Max.Size = new System.Drawing.Size(27, 13);
            this.label9Max.TabIndex = 15;
            this.label9Max.Text = "Max";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(9, 328);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(46, 13);
            this.label9.TabIndex = 16;
            this.label9.Text = "Schiefe ";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(9, 354);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(53, 13);
            this.label10.TabIndex = 17;
            this.label10.Text = "Wölbung ";
            // 
            // label11Schiefe
            // 
            this.label11Schiefe.AutoSize = true;
            this.label11Schiefe.Location = new System.Drawing.Point(81, 328);
            this.label11Schiefe.Name = "label11Schiefe";
            this.label11Schiefe.Size = new System.Drawing.Size(43, 13);
            this.label11Schiefe.TabIndex = 18;
            this.label11Schiefe.Text = "Schiefe";
            // 
            // label11Wolbung
            // 
            this.label11Wolbung.AutoSize = true;
            this.label11Wolbung.Location = new System.Drawing.Point(81, 354);
            this.label11Wolbung.Name = "label11Wolbung";
            this.label11Wolbung.Size = new System.Drawing.Size(53, 13);
            this.label11Wolbung.TabIndex = 19;
            this.label11Wolbung.Text = "Wölbung ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(963, 387);
            this.Controls.Add(this.label11Wolbung);
            this.Controls.Add(this.label11Schiefe);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label9Max);
            this.Controls.Add(this.label9Min);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label73xStd);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label6Zentral);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label5Mittel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.label4Std);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2Disconnect);
            this.Controls.Add(this.button1Connect);
            this.Name = "Form1";
            this.Text = "TMP102 Temperatur Sensor";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1Connect;
        private System.Windows.Forms.Button button2Disconnect;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4Std;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5Mittel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6Zentral;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label73xStd;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9Min;
        private System.Windows.Forms.Label label9Max;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11Schiefe;
        private System.Windows.Forms.Label label11Wolbung;
    }
}

