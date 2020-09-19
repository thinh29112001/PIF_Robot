using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZedGraph;

using System.Windows.Forms;
using System.IO.Ports;



namespace Balancing_robot_GUI
{
    public partial class Form1 : Form
    {
     
        string dataSerial = "";
        int tickstart;
        bool isFirst = true;
       

        public Form1()
        {
            InitializeComponent();
            getAvailabelPorts();
        }

        void getAvailabelPorts()
        {
            string[] ports = SerialPort.GetPortNames();
            port.Items.AddRange(ports);
        }

        private void con_button_Click(object sender, EventArgs e)
        {
           
            if ((port.Text == "") || (baudrate.Text == "")) return;

            serialPort1.PortName = port.Text;
            serialPort1.BaudRate = Convert.ToInt32(baudrate.Text);
            if (serialPort1.IsOpen) return;

            if (isFirst == false)
            {
                z1.GraphPane.CurveList.Clear();
                z1.Invalidate();
                graphInit();
            }

            serialPort1.Open();
            if (timer1.Enabled == false) timer1.Enabled = true;
            tickstart = Environment.TickCount;
            showData.Enabled = true;
            con_button.Enabled = false;
            dcon_button.Enabled = true;
            textBox1.Enabled = true;
            textBox2.Enabled = true;
            send1.Enabled = true;
            send2.Enabled = true;
            
        }

        
        
        private void dcon_button_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen == false) return;
            serialPort1.Close();
            isFirst = false;
            if (timer1.Enabled == true) timer1.Enabled = false;
            dcon_button.Enabled = false;
            con_button.Enabled = true;
            textBox1.Enabled = false;
            textBox2.Enabled = false;
            send1.Enabled = false;
            send2.Enabled = false;
        }

        private void serialPort1_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            while (serialPort1.BytesToRead > 0)
            {
                dataSerial = serialPort1.ReadLine();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            graphInit();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Draw(dataSerial);
            showData.Text = dataSerial;
           
        }
        public void graphInit()
        {
            GraphPane myPane = z1.GraphPane;
            z1.IsShowPointValues = true;
            myPane.Title.Text = "";
            myPane.XAxis.Title.Text = "";
            myPane.YAxis.Title.Text = "";


            RollingPointPairList list1 = new RollingPointPairList(60000);
            LineItem curve = myPane.AddCurve(null, list1, Color.Green, SymbolType.None);

            myPane.XAxis.Scale.Max = 30;
            myPane.XAxis.Scale.Min = 0;
            myPane.XAxis.Scale.MinorStep = 1;
            myPane.XAxis.Scale.MajorStep = 3;
            myPane.YAxis.Scale.Max = 100;
            myPane.YAxis.Scale.Min = -100;

        }
        public void Draw(string setpoint)
        {
            double intSetpoint;
            double.TryParse(setpoint, out intSetpoint);
            if (z1.GraphPane.CurveList.Count <= 0)
            {
                return;
            }
            LineItem curve1 = z1.GraphPane.CurveList[0] as LineItem;
            if (curve1 == null) return;
            IPointListEdit list = curve1.Points as IPointListEdit;
            if (list == null) return;

            double time = (Environment.TickCount - tickstart) / 100.0;

            list.Add(time, intSetpoint);
            Scale xScale = z1.GraphPane.XAxis.Scale;
            if (time > xScale.Max - xScale.MajorStep)
            {
                xScale.Max = time + xScale.MajorStep;
                xScale.Min = xScale.Max - 30;

            }

            z1.AxisChange();
            z1.Invalidate();
        }

        private void send1_Click(object sender, EventArgs e)
        {
            serialPort1.WriteLine(send1.Text);
            send1.Text = "";
        }

        private void send2_Click(object sender, EventArgs e)
        {
            serialPort1.WriteLine(send2.Text);
        }

        private void CopyItem_Click(object sender, EventArgs e)
        {
            if (showData.Text == "") return;
            Clipboard.SetText(showData.Text);
        }

        private void clearAllItem_Click(object sender, EventArgs e)
        {
            showData.Text = "";
        }
    }
}
