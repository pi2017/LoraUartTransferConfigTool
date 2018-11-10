using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO.Ports;

namespace LoraUartTransferConfigTool
{
    public partial class LoraUartTransferConfigTool : Form
    {
        public LoraUartTransferConfigTool()
        {
            InitializeComponent();
        }
        
        private void comlist_MouseClick(object sender, MouseEventArgs e)
        {
            SerialPort com = new SerialPort("COM1");

            string[] portlist = SerialPort.GetPortNames();
            for (int i = 0; i < portlist.Length; i++)
            {
                if (-1 == comlist.FindString(portlist[i]))
                {
                    comlist.Items.Add(portlist[i]);
                }
                if (i == 0)
                {
                    comlist.Text = portlist[i];
                }
            }
            comlist.SelectedIndex = 0;
            //System.Windows.Forms.Control.CheckForIllegalCrossThreadCalls = false;
            comlist.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comlist.SelectedItem == null)
                    return;
            if (comlist.Text != "-请选择端口-")
            {
                if (buttoncomopen.Text == "打开串口")
                {
                    serialPort.PortName = comlist.SelectedItem.ToString();
                    serialPort.BaudRate = 9600;
                    serialPort.DataBits = 8;
                    serialPort.StopBits = StopBits.One;
                    serialPort.Parity = Parity.None;
                    //serialPort.NewLine = "\r\n";
                    try
                    {
                        serialPort.Open();
                        if (serialPort.IsOpen)
                        {
                            serialPort.DiscardInBuffer();
                            if (checkBoxsendcycle.Checked == true)
                            {
                                if (uarttxtimer.Enabled == false)
                                {
                                    int time;
                                    try
                                    {
                                        time = int.Parse(textBoxsendcycle.Text);
                                        uarttxtimer.Interval = time;  //单位ms
                                        uarttxtimer.Start();
                                    }
                                    catch
                                    {
                                        checkBoxsendcycle.Checked = false;
                                        MessageBox.Show("请输入正确的时间，单位：ms");
                                    }
                                }
                            }
                            buttoncomopen.Text = "关闭串口";
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                        serialPort.Close();
                        return;
                    }
                }
                else
                {
                    checkBoxsendcycle.Checked = false;
                    uarttxtimer.Stop();
                    serialPort.Close();
                    buttoncomopen.Text = "打开串口";
                }
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void buttonsend_MouseClick(object sender, MouseEventArgs e)
        {
            if (serialPort.IsOpen == true)
            {
                byte[] byteArray = System.Text.Encoding.Default.GetBytes(richTextBoxcomtrasmit.Text);
                serialPort.Write(byteArray, 0, byteArray.Length);
            }
        }

        private void uarttxtimer_Tick(object sender, EventArgs e)
        {
            if (serialPort.IsOpen == true)
            {
                byte[] byteArray = System.Text.Encoding.Default.GetBytes(richTextBoxcomtrasmit.Text);
                serialPort.Write(byteArray, 0, byteArray.Length);
            }
        }

        private void checkBoxsendcycle_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxsendcycle.Checked == true)
            {
                int time;
                try
                {
                    time = int.Parse(textBoxsendcycle.Text);
                    uarttxtimer.Interval = time;  //单位ms
                    if (serialPort.IsOpen == true)
                    {
                        uarttxtimer.Start();     //timer1.Enabled=true也可
                    }
                }
                catch
                {
                    checkBoxsendcycle.Checked = false;
                    MessageBox.Show("请输入正确的时间，单位：ms");
                }
            }
            else
            {
                uarttxtimer.Stop();
            }
        }

        private void textBoxsendcycle_TextChanged(object sender, EventArgs e)
        {
            int time;
            try
            {
                time = int.Parse(textBoxsendcycle.Text);
                uarttxtimer.Interval = time;  //单位ms
                if (serialPort.IsOpen == true)
                {
                    uarttxtimer.Start();     //timer1.Enabled=true也可
                }
            }
            catch
            {
                checkBoxsendcycle.Checked = false;
                MessageBox.Show("请输入正确的时间，单位：ms");
            }
            if (uarttxtimer.Enabled == true)
            {
                uarttxtimer.Stop();
                if (serialPort.IsOpen == true)
                {
                    uarttxtimer.Start();
                }
            }
        }

        private void serialPort_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            if (serialPort.BytesToRead <= 0)
            {
                return;
            }
            byte[] ReadBuf = new byte[serialPort.BytesToRead];

            serialPort.Read(ReadBuf, 0, ReadBuf.Length);
            this.BeginInvoke(new Action(() =>
            {
                richTextBoxcomrecv.Text += System.Text.Encoding.Default.GetString(ReadBuf);
                this.richTextBoxcomrecv.SelectionStart = this.richTextBoxcomrecv.TextLength;
                this.richTextBoxcomrecv.ScrollToCaret();
            }));
        }

        private void linkLabelwebsite_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("http://www.coltsmart.com");
        }
    }
}
