using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using MathNet.Numerics.Statistics;      //for Math 
using System.Globalization;             //for CultureInfo.InvariantCulture


namespace TEMP102
{
    public partial class Form1 : Form
    {
        private List<double> listdTemperature = new List<double>();

        public Form1()
        {
            InitializeComponent();
           
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            serialPort1.PortName = "COM3";
            serialPort1.BaudRate = 9600;
            serialPort1.DtrEnable = true;
            serialPort1.Open();
            serialPort1.DataReceived += serialPort1_DataReceived;

        }

        private void button2Disconnect_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                serialPort1.Close();
            }
        }

        private void serialPort1_DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {
            string line = serialPort1.ReadLine();
            this.BeginInvoke(new LineReceivedEvent(LineReceived), line);
        }

        private delegate void LineReceivedEvent(string line);
        private void LineReceived(string line)
        {
            double dTemperature;
            //What to do with the received line here

            try
            {

                label1.Text = line;                 //receives line with point 21.45 to make it to double one needs to use
                                                    //CultureInfo.InvariantCulture
                dTemperature = double.Parse(line, CultureInfo.InvariantCulture);           
                listdTemperature.Add(dTemperature);
                label4Std.Text = Convert.ToString(listdTemperature.StandardDeviation());
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

           
        }
    }
}
