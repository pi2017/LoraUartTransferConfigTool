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
        public static void Delay(int milliSecond)
        {
            int start = Environment.TickCount;
            while (Math.Abs(Environment.TickCount - start) < milliSecond)//毫秒
            {
                Application.DoEvents();//可执行某无聊的操作
            }
        }
        public void Wait(int ms)
        {
            var timeout = DateTime.Now.AddMilliseconds(ms);
            while (true)
            {
                //业务处理
                if (DateTime.Now < timeout)
                {
                    //超时
                    return;
                }
            }
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
                    //serialPort.ReadTimeout = 200;
                    serialPort.ReceivedBytesThreshold = 1;
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
        static Int64 comrecvtxcnt = 0;
        private void buttonsend_MouseClick(object sender, MouseEventArgs e)
        {
            if (serialPort.IsOpen == true)
            {
                byte[] byteArray = System.Text.Encoding.Default.GetBytes(richTextBoxcomtrasmit.Text);
                serialPort.Write(byteArray, 0, byteArray.Length);
                comrecvtxcnt += byteArray.Length;
                this.BeginInvoke(new Action(() =>
                {
                    labeltxcnt.Text = "Tx:" + Convert.ToString(comrecvtxcnt);
                }));
            }
        }
        
        private void uarttxtimer_Tick(object sender, EventArgs e)
        {
            if (serialPort.IsOpen == true)
            {
                byte[] byteArray = System.Text.Encoding.Default.GetBytes(richTextBoxcomtrasmit.Text);
                serialPort.Write(byteArray, 0, byteArray.Length);
                comrecvtxcnt += byteArray.Length;
                this.BeginInvoke(new Action(() =>
                {
                    labeltxcnt.Text = "Tx:" + Convert.ToString(comrecvtxcnt);
                }));
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
                if ((serialPort.IsOpen == true) && (checkBoxsendcycle.Checked == true))
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
                if ((serialPort.IsOpen == true) && (checkBoxsendcycle.Checked == true))
                {
                    uarttxtimer.Start();
                }
            }
        }
        public static string byteToHexStr(byte[] bytes)
        {
            string returnStr = "";
            if (bytes != null)
            {
                for (int i = 0; i < bytes.Length; i++)
                {
                    returnStr += bytes[i].ToString("X2");
                }
            }
            return returnStr;
        }
        static Int64 comrecvrxcnt = 0;
        volatile byte[] ReadBuf = new byte[10];
        volatile int ReadBufIndex = 0;
        private void serialPort_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            if (serialPort.BytesToRead <= 0)
            {
                return;
            }
            
            if (checkBoxuarttransfer.Checked == false)
            {
                while (serialPort.BytesToRead > 0)
                {
                    byte[] bytea = new byte[1];
                    serialPort.Read(bytea, 0, 1);
                    comrecvrxcnt += 1;
                    this.BeginInvoke(new Action(() =>
                    {
                        labelrxcnt.Text = "Rx:" + Convert.ToString(comrecvrxcnt);
                        richTextBoxcomrecv.Text += byteToHexStr(bytea);
                        richTextBoxcomrecv.Text += " ";
                        this.richTextBoxcomrecv.SelectionStart = this.richTextBoxcomrecv.TextLength;
                        this.richTextBoxcomrecv.ScrollToCaret();
                    }));
                    if (ReadBufIndex < 10)
                    {
                        ReadBuf[ReadBufIndex++] = bytea[0]; //return;
                    }
                    //ReadBuf[ReadBufIndex++] = bytea[0];
                }
                
                if ((ReadBuf[0] == 0xC3) && (ReadBufIndex >= 10))
                {
                    timerrxtimeout.Stop();
                    int addrint, channel;
                    byte[] addrarray2 = new byte[4];
                    byte[] channelarray2 = new byte[4];
                    addrarray2[0] = ReadBuf[1];
                    addrarray2[1] = ReadBuf[2];
                    addrint = System.BitConverter.ToInt32(addrarray2, 0);
                    channelarray2[0] = ReadBuf[4];
                    channel = System.BitConverter.ToInt32(channelarray2, 0);

                    this.BeginInvoke(new Action(() =>
                    {
                        textBoxaddr.Text = addrint.ToString();
                        comboBoxuartparity.SelectedIndex = (ReadBuf[3] & 0xc0) >> 6;
                        comboBoxuartbaud.SelectedIndex = (ReadBuf[3] & 0x38) >> 3;
                        comboBoxairbaud.SelectedIndex = (ReadBuf[3] & 0x07) >> 0;
                        textBoxchannel.Text = channel.ToString();
                        comboBoxtransfertype.SelectedIndex = (ReadBuf[5] & 0x80) >> 7;
                        comboBoxiodrive.SelectedIndex = (ReadBuf[5] & 0x40) >> 6;
                        comboBoxwakeuptime.SelectedIndex = (ReadBuf[5] & 0x38) >> 3;
                        comboBoxfecon.SelectedIndex = (ReadBuf[5] & 0x04) >> 2;
                        comboBoxtxpower.SelectedIndex = (ReadBuf[5] & 0x03) >> 0;
                    }));
                    MessageBox.Show("读取参数成功");
                    ReadBufIndex = 0;
                }
                else if (((ReadBuf[0] == 0xC0) || (ReadBuf[0] == 0xC2)) && (ReadBufIndex >= 6))
                {
                    timerrxtimeout.Stop();
                    byte[] addrarray = new byte[4];
                    addrarray[0] = ReadBuf[1];
                    addrarray[1] = ReadBuf[2];
                    Int32 addrint;
                    addrint = System.BitConverter.ToInt32(addrarray, 0);
                    Int32 channel;
                    byte[] channelarray = new byte[4];
                    channelarray[0] = ReadBuf[4];
                    channel = System.BitConverter.ToInt32(channelarray, 0);

                    this.BeginInvoke(new Action(() =>
                    {
                        textBoxaddr.Text = "0x" + addrint.ToString();
                        comboBoxuartparity.SelectedIndex = ReadBuf[3] & 0xc0 >> 6;
                        comboBoxuartbaud.SelectedIndex = ReadBuf[3] & 0x38 >> 3;
                        comboBoxairbaud.SelectedIndex = ReadBuf[3] & 0x07 >> 0;
                        textBoxchannel.Text = "0x" + channel.ToString();
                        comboBoxtransfertype.SelectedIndex = (ReadBuf[5] & 0x80) >> 7;
                        comboBoxiodrive.SelectedIndex = (ReadBuf[5] & 0x40) >> 6;
                        comboBoxwakeuptime.SelectedIndex = (ReadBuf[5] & 0x38) >> 3;
                        comboBoxfecon.SelectedIndex = (ReadBuf[5] & 0x04) >> 2;
                        comboBoxtxpower.SelectedIndex = (ReadBuf[5] & 0x03) >> 0;
                    }));
                    MessageBox.Show("写入参数成功");
                    ReadBufIndex = 0;
                }
                else
                {
                    return;
                }
            }
            else
            {
                byte[] ReadBuf = new byte[serialPort.BytesToRead];
                serialPort.Read(ReadBuf, 0, ReadBuf.Length);
                comrecvrxcnt += ReadBuf.Length;
                this.BeginInvoke(new Action(() =>
                {
                    labelrxcnt.Text = "Rx:" + Convert.ToString(comrecvrxcnt);
                    richTextBoxcomrecv.Text += System.Text.Encoding.Default.GetString(ReadBuf);
                    this.richTextBoxcomrecv.SelectionStart = this.richTextBoxcomrecv.TextLength;
                    this.richTextBoxcomrecv.ScrollToCaret();
                }));
            }
        }

        private void linkLabelwebsite_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("http://www.coltsmart.com");
        }

        private void buttonsurport_Click(object sender, EventArgs e)
        {
            MessageBox.Show("M32");
        }

        private void buttoncleanreceive_Click(object sender, EventArgs e)
        {
            richTextBoxcomrecv.Clear();
            comrecvrxcnt = 0;
            comrecvtxcnt = 0;
            labelrxcnt.Text = "Rx:0";
            labeltxcnt.Text = "Tx:0";
        }

        private void checkBoxuarttransfer_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxuarttransfer.Checked == true)
            {
                groupBoxconfigarea.Enabled = false;
                groupBoxuarttransfer.Enabled = true;
            }
            else
            {
                groupBoxconfigarea.Enabled = true;
                groupBoxuarttransfer.Enabled = false;
            }

        }

        private void buttonwriteparam_Click(object sender, EventArgs e)
        {
            if (serialPort.IsOpen == true)
            {
                ReadBufIndex = 0;
                serialPort.DiscardInBuffer();
                byte[] byteArray = { 0xc3, 0xc3, 0xc3, 0xc1, 0xc1, 0xc1 };
                serialPort.Write(byteArray, 0, byteArray.Length);
                comrecvtxcnt += byteArray.Length;
                labeltxcnt.Text = "Tx:" + Convert.ToString(comrecvtxcnt);
                timerrxtimeout.Interval = 1000;  //单位ms
                timerrxtimeout.Start();     //timer1.Enabled=true也可
            }
        }

        private void buttonreadparam_Click(object sender, EventArgs e)
        {
            if (serialPort.IsOpen == true)
            {
                ReadBufIndex = 0;
                serialPort.DiscardInBuffer();
                byte[] byteArray = { 0xc3, 0xc3, 0xc3, 0xc1, 0xc1, 0xc1 };
                serialPort.Write(byteArray, 0, byteArray.Length);
                comrecvtxcnt += byteArray.Length;
                labeltxcnt.Text = "Tx:" + Convert.ToString(comrecvtxcnt);
                
                timerrxtimeout.Interval = 1000;  //单位ms
                timerrxtimeout.Start();     //timer1.Enabled=true也可
            }
        }

        private void buttonfactoryreset_Click(object sender, EventArgs e)
        {
            if (serialPort.IsOpen == true)
            {
                ReadBufIndex = 0;
                serialPort.DiscardInBuffer();
                byte[] byteArray = { 0xC0, 0x00, 0x00, 0x1A, 0x17, 0x44 };
                serialPort.Write(byteArray, 0, byteArray.Length);
                comrecvtxcnt += byteArray.Length;
                labeltxcnt.Text = "Tx:" + Convert.ToString(comrecvtxcnt);
                timerrxtimeout.Interval = 1000;  //单位ms
                timerrxtimeout.Start();     //timer1.Enabled=true也可
            }
        }

        private void timerrxtimeout_Tick(object sender, EventArgs e)
        {
            timerrxtimeout.Stop();
            ReadBufIndex = serialPort.Read(ReadBuf, 0, 10);
            
            if ((ReadBuf[0] == 0xC3) && (ReadBufIndex >= 10))
            {
                timerrxtimeout.Stop();
                int addrint, channel;
                byte[] addrarray2 = new byte[4];
                byte[] channelarray2 = new byte[4];
                addrarray2[0] = ReadBuf[1];
                addrarray2[1] = ReadBuf[2];
                addrint = System.BitConverter.ToInt32(addrarray2, 0);
                channelarray2[0] = ReadBuf[4];
                channel = System.BitConverter.ToInt32(channelarray2, 0);

                this.BeginInvoke(new Action(() =>
                {
                    textBoxaddr.Text = addrint.ToString();
                    comboBoxuartparity.SelectedIndex = (ReadBuf[3] & 0xc0) >> 6;
                    comboBoxuartbaud.SelectedIndex = (ReadBuf[3] & 0x38) >> 3;
                    comboBoxairbaud.SelectedIndex = (ReadBuf[3] & 0x07) >> 0;
                    textBoxchannel.Text = channel.ToString();
                    comboBoxtransfertype.SelectedIndex = (ReadBuf[5] & 0x80) >> 7;
                    comboBoxiodrive.SelectedIndex = (ReadBuf[5] & 0x40) >> 6;
                    comboBoxwakeuptime.SelectedIndex = (ReadBuf[5] & 0x38) >> 3;
                    comboBoxfecon.SelectedIndex = (ReadBuf[5] & 0x04) >> 2;
                    comboBoxtxpower.SelectedIndex = (ReadBuf[5] & 0x03) >> 0;
                }));
                MessageBox.Show("读取参数成功");
                ReadBufIndex = 0;
                return;
            }
            else if (((ReadBuf[0] == 0xC0) || (ReadBuf[0] == 0xC2)) && (ReadBufIndex >= 6))
            {
                timerrxtimeout.Stop();
                byte[] addrarray = new byte[4];
                addrarray[0] = ReadBuf[1];
                addrarray[1] = ReadBuf[2];
                Int32 addrint;
                addrint = System.BitConverter.ToInt32(addrarray, 0);
                Int32 channel;
                byte[] channelarray = new byte[4];
                channelarray[0] = ReadBuf[4];
                channel = System.BitConverter.ToInt32(channelarray, 0);

                this.BeginInvoke(new Action(() =>
                {
                    textBoxaddr.Text = "0x" + addrint.ToString();
                    comboBoxuartparity.SelectedIndex = ReadBuf[3] & 0xc0 >> 6;
                    comboBoxuartbaud.SelectedIndex = ReadBuf[3] & 0x38 >> 3;
                    comboBoxairbaud.SelectedIndex = ReadBuf[3] & 0x07 >> 0;
                    textBoxchannel.Text = "0x" + channel.ToString();
                    comboBoxtransfertype.SelectedIndex = (ReadBuf[5] & 0x80) >> 7;
                    comboBoxiodrive.SelectedIndex = (ReadBuf[5] & 0x40) >> 6;
                    comboBoxwakeuptime.SelectedIndex = (ReadBuf[5] & 0x38) >> 3;
                    comboBoxfecon.SelectedIndex = (ReadBuf[5] & 0x04) >> 2;
                    comboBoxtxpower.SelectedIndex = (ReadBuf[5] & 0x03) >> 0;
                }));
                MessageBox.Show("写入参数成功");
                ReadBufIndex = 0;
                return;
            }
            else
            {
                //return;
            }
            
            ReadBufIndex = 0;
            timerrxtimeout.Stop();
            MessageBox.Show("模块无响应");
        }
    }
}
