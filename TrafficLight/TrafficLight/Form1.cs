using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;
using System.Security.AccessControl;
using SymbolFactoryDotNet;



namespace TrafficLight
{
    public partial class Form1 : Form
    {
        string data = "";
        string d1, d2;
        string dataToAVR = "";
        string data1, mode1ToAVR, mode2ToAVR, offSystem;
        int light , index = 0 ;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string[] port = SerialPort.GetPortNames();
            string[] baud = { "1200", "2400", "4800", "9600", "19200", "28800", "57600" };
            string[] dataSize = { "7", "8" };

            cbxStopBit.Items.Add(StopBits.One);
            cbxStopBit.Items.Add(StopBits.OnePointFive);
            cbxStopBit.Items.Add(StopBits.Two);

            cbxParity.Items.Add(Parity.None);
            cbxParity.Items.Add(Parity.Odd);
            cbxParity.Items.Add(Parity.Even);

            cbxSelectCOM.Items.AddRange(port);
            cbxBaudRate.Items.AddRange(baud);
            cbxDataSize.Items.AddRange(dataSize);
        }

        private void Config_SerialPort()
        {
            myPorts.PortName = cbxSelectCOM.Text;
            myPorts.BaudRate = int.Parse(cbxBaudRate.Text);
            myPorts.DataBits = int.Parse(cbxDataSize.Text);
            
            switch (cbxStopBit.SelectedIndex)
            {
                case 0:
                    myPorts.StopBits = StopBits.One;
                    break;
                case 1:
                    myPorts.StopBits = StopBits.OnePointFive;
                    break;
                case 2:
                    myPorts.StopBits = StopBits.Two;
                    break;
            }

            switch (cbxParity.SelectedIndex)
            {
                case 0:
                    myPorts.Parity = Parity.None;
                    break;
                case 1:
                    myPorts.Parity = Parity.Odd;
                    break;
                case 2:
                    myPorts.Parity = Parity.Even;
                    break;
            }
        }

        private void BtnConnect_Click(object sender, EventArgs e)
        {
            if (myPorts.IsOpen == false)
            {
                try
                {
                    Config_SerialPort();
                    myPorts.Open();
                    lblStatus.Text = "Connected";
                    lblStatus.ForeColor = Color.Blue;
                    BtnConnect.Text = "Disconnect";
                    BtnConnect.BackColor = Color.OrangeRed;

                    cbxSelectCOM.Enabled = false;
                    cbxBaudRate.Enabled = false;
                    cbxDataSize.Enabled = false;
                    cbxParity.Enabled = false;
                    cbxStopBit.Enabled = false;
                }
                catch 
                {
                    MessageBox.Show("Erros!","");
                }
            }
            else
            {
                myPorts.Close();
                lblStatus.Text = "Disconnect";
                lblStatus.ForeColor = Color.Red;
                BtnConnect.Text = "Connect";
                BtnConnect.BackColor = Color.WhiteSmoke;

                cbxSelectCOM.Enabled = true;
                cbxBaudRate.Enabled = true;
                cbxDataSize.Enabled = true;
                cbxParity.Enabled = true;
                cbxStopBit.Enabled = true;
            }
        }

        private void myPorts_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            if (Check_Connect())
            {
                data += myPorts.ReadExisting();
                if (rdBMode1.Checked == true)
                {
                    if (data.Length > 4)
                    {
                        {
                            Invoke(new MethodInvoker(() => DataMode1()));
                            data = "";
                        }
                    }
                }
                if (rdBMode2.Checked == true)
                {
                    if (data.Length >= 1)
                    {
                        {
                            Invoke(new MethodInvoker(() => DataMode2()));
                            data = "";
                        }
                    }
                }
                if (rdBOffSystem.Checked == true)
                {
                    data = "";
                }
            }
        }

        private void ONLamp(StandardControl standard , StandardControl standard1)
        {
            standard.DiscreteValue1 = true;
            standard1.DiscreteValue1 = true;
        }
        private void OFFLamp(StandardControl standard, StandardControl standard1)
        {
            standard.DiscreteValue1 = false;
            standard1.DiscreteValue1 = false;
        }

        private void cbxSelectCOM_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private bool Check_Connect()
        {
            if (myPorts.IsOpen == true)
            {
                return true;
            }
            else
            {
                MessageBox.Show("No connected","Infor", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        private void rdBMode1_CheckedChanged(object sender, EventArgs e)
        {
            if (rdBMode1.Checked == true)
            {
                if (Check_Connect())
                {
                    mode1ToAVR = "1" + data1;
                    try
                    {
                        
                        for (int i = 0; i < 9; i++)
                        {
                            myPorts.Write(mode1ToAVR[i].ToString());
                        }
                    }
                    catch 
                    {
                        MessageBox.Show("Chuỗi không hợp lệ!");
                    }
                }
            }
        }

        private void rdBMode2_CheckedChanged(object sender, EventArgs e)
        {
            if (rdBMode2.Checked == true)
            {
                if (Check_Connect())
                {
                    try
                    {
                        mode2ToAVR = "200000000" ;
                        for (int i = 0; i < 9; i++)
                        {
                            myPorts.Write(mode2ToAVR[i].ToString());
                        }
                    }
                    catch
                    {
                        MessageBox.Show("Chuỗi không hợp lệ!");
                    }

                    OFFLamp(sdGreenB1, sdGreenB2);
                    OFFLamp(sdRedB1, sdRedB2);
                    OFFLamp(sdGreenA1, sdGreenA2);
                    OFFLamp(sdRedA1, sdRedA2);

                    lblTimeB1.Text = "0";
                    lblTimeB2.Text = "0";
                    lblTimeA1.Text = "0";
                    lblTimeA2.Text = "0";

                    data = "";
                }
            }
        }

        private void rdBOffSystem_CheckedChanged(object sender, EventArgs e)
        {
            if (rdBOffSystem.Checked == true)
            {
                if (Check_Connect())
                {
                    try
                    {
                        offSystem = "000000000";
                        for (int i = 0; i < 9; i++)
                        {
                            myPorts.Write(offSystem[i].ToString());
                        }
                    }
                    catch
                    {
                        MessageBox.Show("Chuỗi không hợp lệ!");
                    }

                    OFFLamp(sdGreenB1, sdGreenB2);
                    OFFLamp(sdYellowB1, sdYellowB2);
                    OFFLamp(sdRedB1, sdRedB2);
                    OFFLamp(sdGreenA1, sdGreenA2);
                    OFFLamp(sdYellowA1, sdYellowA2);
                    OFFLamp(sdRedA1, sdRedA2);

                    lblTimeB1.Text = "0";
                    lblTimeB2.Text = "0";
                    lblTimeA1.Text = "0";
                    lblTimeA2.Text = "0";
                }
            }
        }

        private void Check_Text(TextBox text)
        {
            if (int.Parse(text.Text) < 10 )
            {
                text.Text = "0" + text.Text;
            }
        }

        private void BtnSendtoAVR_Click(object sender, EventArgs e)
        {
            if (Check_Connect())
            {
                Check_Text(txtGreenA);
                Check_Text(txtGreenB);
                Check_Text(txtYellowA);
                Check_Text(txtYellowB);
                timerPorts.Start();
                timerPorts.Interval = 50;
                
                data1 = txtGreenA.Text + txtYellowA.Text + txtGreenB.Text + txtYellowB.Text;
                dataToAVR = "0" + data1;
            }
        }

        private void DataMode1()
        {
            light = int.Parse(data[0].ToString());
            d1 = data[1].ToString() + data[2].ToString();
            d2 = data[3].ToString() + data[4].ToString();

            lblTimeA1.Text = d1.ToString();
            lblTimeA2.Text = d1.ToString();
            lblTimeB1.Text = d2.ToString();
            lblTimeB2.Text = d2.ToString();

            if (light < 3)
            {
                ONLamp(sdRedB1, sdRedB2);
                OFFLamp(sdYellowB1, sdYellowB2);
                OFFLamp(sdGreenB1, sdGreenB2);
                OFFLamp(sdRedA1, sdRedA2);

                lblTimeB1.ForeColor = Color.Red;
                lblTimeB2.ForeColor = Color.Red;
                if (light == 2)
                {
                    ONLamp(sdYellowA1, sdYellowA2);
                    OFFLamp(sdGreenA1, sdGreenA2);
                    lblTimeA1.ForeColor = Color.Yellow;
                    lblTimeA2.ForeColor = Color.Yellow;
                }
                else
                {
                    ONLamp(sdGreenA1, sdGreenA2);
                    OFFLamp(sdYellowA1, sdYellowA2);
                    lblTimeA1.ForeColor = Color.Green;
                    lblTimeA2.ForeColor = Color.Green;
                }
            }
            else
            {
                ONLamp(sdRedA1, sdRedA2);
                OFFLamp(sdRedB1, sdRedB2);
                OFFLamp(sdGreenA1, sdGreenA2);
                OFFLamp(sdYellowA1, sdYellowA2);

                lblTimeA1.ForeColor = Color.Red;
                lblTimeA2.ForeColor = Color.Red;
                if (light == 4)
                {
                    ONLamp(sdYellowB1, sdYellowB2);
                    OFFLamp(sdGreenB1, sdGreenB2);
                    lblTimeB1.ForeColor = Color.Yellow;
                    lblTimeB2.ForeColor = Color.Yellow;
                }
                else
                {
                    ONLamp(sdGreenB1, sdGreenB2);
                    OFFLamp(sdYellowB1, sdYellowB2);
                    lblTimeB1.ForeColor = Color.Green;
                    lblTimeB2.ForeColor = Color.Green;
                }
            }
        }

        private void txtGreenA_TextChanged(object sender, EventArgs e)
        {
            if (txtGreenA.Text == "" | txtYellowA.Text == "" | txtGreenB.Text == "" | txtYellowB.Text == "")
            {
                BtnSendtoAVR.Enabled = false;
            }
            else
                BtnSendtoAVR.Enabled = true;
        }

        private void timerPorts_Tick(object sender, EventArgs e)
        {
            myPorts.Write(dataToAVR[index].ToString());
            index++;
            if (index > 8)
            {
                txtGreenA.Text = "";
                txtGreenB.Text = "";
                txtYellowA.Text = "";
                txtYellowB.Text = "";
                timerPorts.Stop();
                index = 0;
            }
        }

        private void DataMode2()
        {
            light = int.Parse(data.ToString());
            if (light == 5)
            {
                ONLamp(sdYellowB1, sdYellowB2);
                ONLamp(sdYellowA1, sdYellowA2);
            }
            else
            {
                OFFLamp(sdYellowB1, sdYellowB2);
                OFFLamp(sdYellowA1, sdYellowA2);
            }
        }
    }
}
