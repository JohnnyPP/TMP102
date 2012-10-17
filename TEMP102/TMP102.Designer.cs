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
            this.button1Connect = new System.Windows.Forms.Button();
            this.button2Disconnect = new System.Windows.Forms.Button();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4Std = new System.Windows.Forms.Label();
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
            this.label2.Location = new System.Drawing.Point(12, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Temperatur [C]";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 128);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(130, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Standard abweichung [C]:";
            // 
            // label4Std
            // 
            this.label4Std.AutoSize = true;
            this.label4Std.Location = new System.Drawing.Point(161, 128);
            this.label4Std.Name = "label4Std";
            this.label4Std.Size = new System.Drawing.Size(23, 13);
            this.label4Std.TabIndex = 4;
            this.label4Std.Text = "Std";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(819, 398);
            this.Controls.Add(this.label4Std);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2Disconnect);
            this.Controls.Add(this.button1Connect);
            this.Name = "Form1";
            this.Text = "TMP102 Temperatur Sensor";
            this.Load += new System.EventHandler(this.Form1_Load);
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
    }
}

