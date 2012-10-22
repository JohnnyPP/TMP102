using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;  //for charting
using MathNet.Numerics.Statistics;      //for Math 
using System.Globalization;             //for CultureInfo.InvariantCulture




namespace TEMP102
{
    public partial class Form1 : Form
    {
        private int i = 0;
        private DateTime dtStarttime;

        private TimeSpan tsTimespent;

        private List<double> listdTimespent = new List<double>();
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
            dtStarttime = DateTime.Now;

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
            double dTemperature, dTemperatureRound, dTemperatureStd;
            
            
            //What to do with the received line here
            
            try
            {
                DateTime dtStart = DateTime.Now;

                //label1.Text = line;                 //receives line with point 21.45 to make it to double one needs to use
                                                    //CultureInfo.InvariantCulture
                dTemperature = double.Parse(line, CultureInfo.InvariantCulture);
                dTemperatureRound = Math.Round(dTemperature, 4);

                label1.Text = Convert.ToString(dTemperatureRound);
               

                chart1.Series[0].BorderWidth = 2;
                chart1.Series[0].ChartType = SeriesChartType.Line;

                tsTimespent = DateTime.Now - dtStarttime;
                listdTimespent.Add(i);
                listdTemperature.Add(dTemperatureRound);
                dTemperatureStd = Math.Round(listdTemperature.StandardDeviation(),4);
                label4Std.Text = Convert.ToString(dTemperatureStd);
                label5Mittel.Text = Convert.ToString(Math.Round(listdTemperature.Mean(),4));
                label6Zentral.Text = Convert.ToString(Math.Round(listdTemperature.Median(),4));
                label73xStd.Text = Convert.ToString(3*dTemperatureStd);
                label9Min.Text = Convert.ToString(Math.Round(listdTemperature.Min(),4));
                label9Max.Text = Convert.ToString(Math.Round(listdTemperature.Max(),4));
                //label11Schiefe.Text = Convert.ToString(Math.Round(listdTemperature.(), 4));

            

                chart1.Series[0].Points.AddXY(tsTimespent.TotalSeconds, dTemperatureRound);
                //chart1.Series[0].Points.AddXY(i, dTemperatureRound);

                chart1.ChartAreas["ChartArea1"].AxisX.Minimum = listdTimespent[0];
                chart1.ChartAreas["ChartArea1"].AxisY.Minimum = (listdTemperature.Min() - 0.5);
                chart1.ChartAreas["ChartArea1"].AxisY.Maximum = (listdTemperature.Max() + 0.5);
                //chart1.ChartAreas["ChartArea1"].AxisX = new Axis { LabelStyle = new LabelStyle() { Font = new Font("Verdana", 7.5f) } };
                //chart1.ChartAreas["ChartArea1"].AxisX.TitleFont = "Verdana";

                //chart1.ChartAreas["ChartArea1"].AxisX.Title = "Zeit [s]";
                //chart1.ChartAreas["ChartArea1"].AxisY.Title = "Temparature [C]";

                DateTime time = DateTime.Now;
                //string format = "MMM ddd d HH:mm yyyy";
                string format = "yyyyMMddHHmmssffff";

                //label2.Text = time.ToString(format);

                i++;

                //comment
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

           
        }
    }
}
