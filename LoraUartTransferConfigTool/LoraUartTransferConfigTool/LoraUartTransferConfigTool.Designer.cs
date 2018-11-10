namespace LoraUartTransferConfigTool
{
    partial class LoraUartTransferConfigTool
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.uarttxtimer = new System.Windows.Forms.Timer(this.components);
            this.serialPort = new System.IO.Ports.SerialPort(this.components);
            this.comlist = new System.Windows.Forms.ComboBox();
            this.logo = new System.Windows.Forms.PictureBox();
            this.buttoncomopen = new System.Windows.Forms.Button();
            this.comboBoxuartbaud = new System.Windows.Forms.ComboBox();
            this.labeluartbaud = new System.Windows.Forms.Label();
            this.labeluartparity = new System.Windows.Forms.Label();
            this.comboBoxuartparity = new System.Windows.Forms.ComboBox();
            this.labelairbaud = new System.Windows.Forms.Label();
            this.comboBoxairbaud = new System.Windows.Forms.ComboBox();
            this.labeltxpower = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.labelfecon = new System.Windows.Forms.Label();
            this.labeltransfertype = new System.Windows.Forms.Label();
            this.labelwakeuptime = new System.Windows.Forms.Label();
            this.labelIOdrive = new System.Windows.Forms.Label();
            this.comboBoxfecon = new System.Windows.Forms.ComboBox();
            this.comboBoxtransfertype = new System.Windows.Forms.ComboBox();
            this.comboBoxwakeuptime = new System.Windows.Forms.ComboBox();
            this.comboBoxiodrive = new System.Windows.Forms.ComboBox();
            this.labelcopyright = new System.Windows.Forms.Label();
            this.richTextBoxmoduleinfo = new System.Windows.Forms.RichTextBox();
            this.richTextBoxcomrecv = new System.Windows.Forms.RichTextBox();
            this.richTextBoxcomtrasmit = new System.Windows.Forms.RichTextBox();
            this.buttonsend = new System.Windows.Forms.Button();
            this.textBoxsendcycle = new System.Windows.Forms.TextBox();
            this.checkBoxsendcycle = new System.Windows.Forms.CheckBox();
            this.labelsendcycle = new System.Windows.Forms.Label();
            this.labelwebaddr = new System.Windows.Forms.Label();
            this.linkLabelwebsite = new System.Windows.Forms.LinkLabel();
            this.buttonreadparam = new System.Windows.Forms.Button();
            this.buttonwriteparam = new System.Windows.Forms.Button();
            this.buttonfactoryreset = new System.Windows.Forms.Button();
            this.buttonsurport = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
            this.SuspendLayout();
            // 
            // uarttxtimer
            // 
            this.uarttxtimer.Tick += new System.EventHandler(this.uarttxtimer_Tick);
            // 
            // serialPort
            // 
            this.serialPort.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort_DataReceived);
            // 
            // comlist
            // 
            this.comlist.FormattingEnabled = true;
            this.comlist.Location = new System.Drawing.Point(269, 8);
            this.comlist.Name = "comlist";
            this.comlist.Size = new System.Drawing.Size(77, 20);
            this.comlist.TabIndex = 0;
            this.comlist.Text = "选择端口";
            this.comlist.MouseClick += new System.Windows.Forms.MouseEventHandler(this.comlist_MouseClick);
            // 
            // logo
            // 
            this.logo.Image = global::LoraUartTransferConfigTool.Properties.Resources.logo;
            this.logo.Location = new System.Drawing.Point(0, 0);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(258, 51);
            this.logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.logo.TabIndex = 1;
            this.logo.TabStop = false;
            // 
            // buttoncomopen
            // 
            this.buttoncomopen.Location = new System.Drawing.Point(269, 34);
            this.buttoncomopen.Name = "buttoncomopen";
            this.buttoncomopen.Size = new System.Drawing.Size(77, 20);
            this.buttoncomopen.TabIndex = 2;
            this.buttoncomopen.Text = "打开串口";
            this.buttoncomopen.UseVisualStyleBackColor = true;
            this.buttoncomopen.Click += new System.EventHandler(this.button1_Click);
            // 
            // comboBoxuartbaud
            // 
            this.comboBoxuartbaud.AutoCompleteCustomSource.AddRange(new string[] {
            "1200",
            "2400",
            "4800",
            "9600",
            "19200",
            "38400",
            "57600",
            "115200"});
            this.comboBoxuartbaud.FormattingEnabled = true;
            this.comboBoxuartbaud.Items.AddRange(new object[] {
            "1200",
            "2400",
            "4800",
            "9600",
            "19200",
            "38400",
            "57600",
            "115200",
            ""});
            this.comboBoxuartbaud.Location = new System.Drawing.Point(75, 206);
            this.comboBoxuartbaud.Name = "comboBoxuartbaud";
            this.comboBoxuartbaud.Size = new System.Drawing.Size(76, 20);
            this.comboBoxuartbaud.TabIndex = 3;
            this.comboBoxuartbaud.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // labeluartbaud
            // 
            this.labeluartbaud.AutoSize = true;
            this.labeluartbaud.Location = new System.Drawing.Point(4, 209);
            this.labeluartbaud.Name = "labeluartbaud";
            this.labeluartbaud.Size = new System.Drawing.Size(53, 12);
            this.labeluartbaud.TabIndex = 5;
            this.labeluartbaud.Text = "串口速率";
            // 
            // labeluartparity
            // 
            this.labeluartparity.AutoSize = true;
            this.labeluartparity.Location = new System.Drawing.Point(4, 229);
            this.labeluartparity.Name = "labeluartparity";
            this.labeluartparity.Size = new System.Drawing.Size(53, 12);
            this.labeluartparity.TabIndex = 6;
            this.labeluartparity.Text = "串口校验";
            // 
            // comboBoxuartparity
            // 
            this.comboBoxuartparity.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.comboBoxuartparity.Items.AddRange(new object[] {
            "8N1",
            "8O1",
            "8E1",
            "8N1"});
            this.comboBoxuartparity.Location = new System.Drawing.Point(75, 226);
            this.comboBoxuartparity.Name = "comboBoxuartparity";
            this.comboBoxuartparity.Size = new System.Drawing.Size(76, 20);
            this.comboBoxuartparity.TabIndex = 7;
            // 
            // labelairbaud
            // 
            this.labelairbaud.AutoSize = true;
            this.labelairbaud.Location = new System.Drawing.Point(4, 249);
            this.labelairbaud.Name = "labelairbaud";
            this.labelairbaud.Size = new System.Drawing.Size(53, 12);
            this.labelairbaud.TabIndex = 8;
            this.labelairbaud.Text = "无线速率";
            // 
            // comboBoxairbaud
            // 
            this.comboBoxairbaud.FormattingEnabled = true;
            this.comboBoxairbaud.Items.AddRange(new object[] {
            "0.3k",
            "1.2k",
            "2.4k",
            "4.8k",
            "9.6k",
            "19.2k",
            "19.2k",
            "19.2k"});
            this.comboBoxairbaud.Location = new System.Drawing.Point(75, 246);
            this.comboBoxairbaud.Name = "comboBoxairbaud";
            this.comboBoxairbaud.Size = new System.Drawing.Size(76, 20);
            this.comboBoxairbaud.TabIndex = 9;
            // 
            // labeltxpower
            // 
            this.labeltxpower.AutoSize = true;
            this.labeltxpower.Location = new System.Drawing.Point(4, 270);
            this.labeltxpower.Name = "labeltxpower";
            this.labeltxpower.Size = new System.Drawing.Size(53, 12);
            this.labeltxpower.TabIndex = 10;
            this.labeltxpower.Text = "发射功率";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(75, 267);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(76, 20);
            this.comboBox1.TabIndex = 11;
            // 
            // labelfecon
            // 
            this.labelfecon.AutoSize = true;
            this.labelfecon.Location = new System.Drawing.Point(194, 209);
            this.labelfecon.Name = "labelfecon";
            this.labelfecon.Size = new System.Drawing.Size(53, 12);
            this.labelfecon.TabIndex = 12;
            this.labelfecon.Text = "前向纠错";
            // 
            // labeltransfertype
            // 
            this.labeltransfertype.AutoSize = true;
            this.labeltransfertype.Location = new System.Drawing.Point(194, 229);
            this.labeltransfertype.Name = "labeltransfertype";
            this.labeltransfertype.Size = new System.Drawing.Size(53, 12);
            this.labeltransfertype.TabIndex = 13;
            this.labeltransfertype.Text = "传输方式";
            // 
            // labelwakeuptime
            // 
            this.labelwakeuptime.AutoSize = true;
            this.labelwakeuptime.Location = new System.Drawing.Point(194, 249);
            this.labelwakeuptime.Name = "labelwakeuptime";
            this.labelwakeuptime.Size = new System.Drawing.Size(53, 12);
            this.labelwakeuptime.TabIndex = 14;
            this.labelwakeuptime.Text = "唤醒时间";
            // 
            // labelIOdrive
            // 
            this.labelIOdrive.AutoSize = true;
            this.labelIOdrive.Location = new System.Drawing.Point(194, 270);
            this.labelIOdrive.Name = "labelIOdrive";
            this.labelIOdrive.Size = new System.Drawing.Size(53, 12);
            this.labelIOdrive.TabIndex = 15;
            this.labelIOdrive.Text = "I O 驱动";
            // 
            // comboBoxfecon
            // 
            this.comboBoxfecon.FormattingEnabled = true;
            this.comboBoxfecon.Location = new System.Drawing.Point(267, 206);
            this.comboBoxfecon.Name = "comboBoxfecon";
            this.comboBoxfecon.Size = new System.Drawing.Size(79, 20);
            this.comboBoxfecon.TabIndex = 16;
            // 
            // comboBoxtransfertype
            // 
            this.comboBoxtransfertype.FormattingEnabled = true;
            this.comboBoxtransfertype.Location = new System.Drawing.Point(267, 226);
            this.comboBoxtransfertype.Name = "comboBoxtransfertype";
            this.comboBoxtransfertype.Size = new System.Drawing.Size(79, 20);
            this.comboBoxtransfertype.TabIndex = 17;
            // 
            // comboBoxwakeuptime
            // 
            this.comboBoxwakeuptime.FormattingEnabled = true;
            this.comboBoxwakeuptime.Location = new System.Drawing.Point(267, 246);
            this.comboBoxwakeuptime.Name = "comboBoxwakeuptime";
            this.comboBoxwakeuptime.Size = new System.Drawing.Size(79, 20);
            this.comboBoxwakeuptime.TabIndex = 18;
            // 
            // comboBoxiodrive
            // 
            this.comboBoxiodrive.FormattingEnabled = true;
            this.comboBoxiodrive.Location = new System.Drawing.Point(267, 267);
            this.comboBoxiodrive.Name = "comboBoxiodrive";
            this.comboBoxiodrive.Size = new System.Drawing.Size(79, 20);
            this.comboBoxiodrive.TabIndex = 19;
            // 
            // labelcopyright
            // 
            this.labelcopyright.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            this.labelcopyright.AutoSize = true;
            this.labelcopyright.Location = new System.Drawing.Point(4, 299);
            this.labelcopyright.Name = "labelcopyright";
            this.labelcopyright.Size = new System.Drawing.Size(257, 12);
            this.labelcopyright.TabIndex = 20;
            this.labelcopyright.Text = "本软件著作权归上海鸣驹智能科技有限公司所有";
            // 
            // richTextBoxmoduleinfo
            // 
            this.richTextBoxmoduleinfo.AutoWordSelection = true;
            this.richTextBoxmoduleinfo.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.richTextBoxmoduleinfo.Location = new System.Drawing.Point(0, 102);
            this.richTextBoxmoduleinfo.Name = "richTextBoxmoduleinfo";
            this.richTextBoxmoduleinfo.ReadOnly = true;
            this.richTextBoxmoduleinfo.Size = new System.Drawing.Size(346, 89);
            this.richTextBoxmoduleinfo.TabIndex = 21;
            this.richTextBoxmoduleinfo.Text = "模块出厂测试性能参数如下：";
            // 
            // richTextBoxcomrecv
            // 
            this.richTextBoxcomrecv.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.richTextBoxcomrecv.BackColor = System.Drawing.SystemColors.Control;
            this.richTextBoxcomrecv.Location = new System.Drawing.Point(385, 102);
            this.richTextBoxcomrecv.Name = "richTextBoxcomrecv";
            this.richTextBoxcomrecv.ReadOnly = true;
            this.richTextBoxcomrecv.Size = new System.Drawing.Size(403, 230);
            this.richTextBoxcomrecv.TabIndex = 22;
            this.richTextBoxcomrecv.Text = "串口接收窗口";
            // 
            // richTextBoxcomtrasmit
            // 
            this.richTextBoxcomtrasmit.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.richTextBoxcomtrasmit.Location = new System.Drawing.Point(385, 0);
            this.richTextBoxcomtrasmit.Name = "richTextBoxcomtrasmit";
            this.richTextBoxcomtrasmit.Size = new System.Drawing.Size(403, 54);
            this.richTextBoxcomtrasmit.TabIndex = 23;
            this.richTextBoxcomtrasmit.Text = "hello\n";
            // 
            // buttonsend
            // 
            this.buttonsend.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonsend.Location = new System.Drawing.Point(701, 73);
            this.buttonsend.Name = "buttonsend";
            this.buttonsend.Size = new System.Drawing.Size(75, 23);
            this.buttonsend.TabIndex = 24;
            this.buttonsend.Text = "发送";
            this.buttonsend.UseVisualStyleBackColor = true;
            this.buttonsend.MouseClick += new System.Windows.Forms.MouseEventHandler(this.buttonsend_MouseClick);
            // 
            // textBoxsendcycle
            // 
            this.textBoxsendcycle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxsendcycle.Location = new System.Drawing.Point(508, 75);
            this.textBoxsendcycle.Name = "textBoxsendcycle";
            this.textBoxsendcycle.Size = new System.Drawing.Size(100, 21);
            this.textBoxsendcycle.TabIndex = 25;
            this.textBoxsendcycle.Text = "1000";
            this.textBoxsendcycle.TextChanged += new System.EventHandler(this.textBoxsendcycle_TextChanged);
            // 
            // checkBoxsendcycle
            // 
            this.checkBoxsendcycle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBoxsendcycle.AutoSize = true;
            this.checkBoxsendcycle.Location = new System.Drawing.Point(623, 77);
            this.checkBoxsendcycle.Name = "checkBoxsendcycle";
            this.checkBoxsendcycle.Size = new System.Drawing.Size(72, 16);
            this.checkBoxsendcycle.TabIndex = 26;
            this.checkBoxsendcycle.Text = "周期发送";
            this.checkBoxsendcycle.UseVisualStyleBackColor = true;
            this.checkBoxsendcycle.CheckedChanged += new System.EventHandler(this.checkBoxsendcycle_CheckedChanged);
            // 
            // labelsendcycle
            // 
            this.labelsendcycle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelsendcycle.AutoSize = true;
            this.labelsendcycle.Location = new System.Drawing.Point(415, 78);
            this.labelsendcycle.Name = "labelsendcycle";
            this.labelsendcycle.Size = new System.Drawing.Size(77, 12);
            this.labelsendcycle.TabIndex = 27;
            this.labelsendcycle.Text = "发送周期(ms)";
            // 
            // labelwebaddr
            // 
            this.labelwebaddr.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            this.labelwebaddr.AutoSize = true;
            this.labelwebaddr.Location = new System.Drawing.Point(4, 320);
            this.labelwebaddr.Name = "labelwebaddr";
            this.labelwebaddr.Size = new System.Drawing.Size(65, 12);
            this.labelwebaddr.TabIndex = 28;
            this.labelwebaddr.Text = "官方网站：";
            // 
            // linkLabelwebsite
            // 
            this.linkLabelwebsite.AutoSize = true;
            this.linkLabelwebsite.Location = new System.Drawing.Point(73, 320);
            this.linkLabelwebsite.Name = "linkLabelwebsite";
            this.linkLabelwebsite.Size = new System.Drawing.Size(107, 12);
            this.linkLabelwebsite.TabIndex = 29;
            this.linkLabelwebsite.TabStop = true;
            this.linkLabelwebsite.Text = "www.coltsmart.com";
            this.linkLabelwebsite.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelwebsite_LinkClicked);
            // 
            // buttonreadparam
            // 
            this.buttonreadparam.Location = new System.Drawing.Point(0, 73);
            this.buttonreadparam.Name = "buttonreadparam";
            this.buttonreadparam.Size = new System.Drawing.Size(75, 23);
            this.buttonreadparam.TabIndex = 30;
            this.buttonreadparam.Text = "读取参数";
            this.buttonreadparam.UseVisualStyleBackColor = true;
            // 
            // buttonwriteparam
            // 
            this.buttonwriteparam.Location = new System.Drawing.Point(86, 73);
            this.buttonwriteparam.Name = "buttonwriteparam";
            this.buttonwriteparam.Size = new System.Drawing.Size(75, 23);
            this.buttonwriteparam.TabIndex = 31;
            this.buttonwriteparam.Text = "写入参数";
            this.buttonwriteparam.UseVisualStyleBackColor = true;
            // 
            // buttonfactoryreset
            // 
            this.buttonfactoryreset.Location = new System.Drawing.Point(172, 73);
            this.buttonfactoryreset.Name = "buttonfactoryreset";
            this.buttonfactoryreset.Size = new System.Drawing.Size(75, 23);
            this.buttonfactoryreset.TabIndex = 32;
            this.buttonfactoryreset.Text = "恢复出厂设置";
            this.buttonfactoryreset.UseVisualStyleBackColor = true;
            // 
            // buttonsurport
            // 
            this.buttonsurport.Location = new System.Drawing.Point(258, 73);
            this.buttonsurport.Name = "buttonsurport";
            this.buttonsurport.Size = new System.Drawing.Size(88, 23);
            this.buttonsurport.TabIndex = 33;
            this.buttonsurport.Text = "查看支持型号";
            this.buttonsurport.UseVisualStyleBackColor = true;
            // 
            // LoraUartTransferConfigTool
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(788, 332);
            this.Controls.Add(this.buttonsurport);
            this.Controls.Add(this.buttonfactoryreset);
            this.Controls.Add(this.buttonwriteparam);
            this.Controls.Add(this.buttonreadparam);
            this.Controls.Add(this.linkLabelwebsite);
            this.Controls.Add(this.labelwebaddr);
            this.Controls.Add(this.labelsendcycle);
            this.Controls.Add(this.checkBoxsendcycle);
            this.Controls.Add(this.textBoxsendcycle);
            this.Controls.Add(this.buttonsend);
            this.Controls.Add(this.richTextBoxcomtrasmit);
            this.Controls.Add(this.richTextBoxcomrecv);
            this.Controls.Add(this.richTextBoxmoduleinfo);
            this.Controls.Add(this.labelcopyright);
            this.Controls.Add(this.comboBoxiodrive);
            this.Controls.Add(this.comboBoxwakeuptime);
            this.Controls.Add(this.comboBoxtransfertype);
            this.Controls.Add(this.comboBoxfecon);
            this.Controls.Add(this.labelIOdrive);
            this.Controls.Add(this.labelwakeuptime);
            this.Controls.Add(this.labeltransfertype);
            this.Controls.Add(this.labelfecon);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.labeltxpower);
            this.Controls.Add(this.comboBoxairbaud);
            this.Controls.Add(this.labelairbaud);
            this.Controls.Add(this.comboBoxuartparity);
            this.Controls.Add(this.labeluartparity);
            this.Controls.Add(this.labeluartbaud);
            this.Controls.Add(this.comboBoxuartbaud);
            this.Controls.Add(this.buttoncomopen);
            this.Controls.Add(this.logo);
            this.Controls.Add(this.comlist);
            this.Name = "LoraUartTransferConfigTool";
            this.Text = "LoraUartTransferConfigTool";
            ((System.ComponentModel.ISupportInitialize)(this.logo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer uarttxtimer;
        private System.IO.Ports.SerialPort serialPort;
        private System.Windows.Forms.ComboBox comlist;
        private System.Windows.Forms.PictureBox logo;
        private System.Windows.Forms.Button buttoncomopen;
        private System.Windows.Forms.ComboBox comboBoxuartbaud;
        private System.Windows.Forms.Label labeluartbaud;
        private System.Windows.Forms.Label labeluartparity;
        private System.Windows.Forms.ComboBox comboBoxuartparity;
        private System.Windows.Forms.Label labelairbaud;
        private System.Windows.Forms.ComboBox comboBoxairbaud;
        private System.Windows.Forms.Label labeltxpower;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label labelfecon;
        private System.Windows.Forms.Label labeltransfertype;
        private System.Windows.Forms.Label labelwakeuptime;
        private System.Windows.Forms.Label labelIOdrive;
        private System.Windows.Forms.ComboBox comboBoxfecon;
        private System.Windows.Forms.ComboBox comboBoxtransfertype;
        private System.Windows.Forms.ComboBox comboBoxwakeuptime;
        private System.Windows.Forms.ComboBox comboBoxiodrive;
        private System.Windows.Forms.Label labelcopyright;
        private System.Windows.Forms.RichTextBox richTextBoxmoduleinfo;
        private System.Windows.Forms.RichTextBox richTextBoxcomrecv;
        private System.Windows.Forms.RichTextBox richTextBoxcomtrasmit;
        private System.Windows.Forms.Button buttonsend;
        private System.Windows.Forms.TextBox textBoxsendcycle;
        private System.Windows.Forms.CheckBox checkBoxsendcycle;
        private System.Windows.Forms.Label labelsendcycle;
        private System.Windows.Forms.Label labelwebaddr;
        private System.Windows.Forms.LinkLabel linkLabelwebsite;
        private System.Windows.Forms.Button buttonreadparam;
        private System.Windows.Forms.Button buttonwriteparam;
        private System.Windows.Forms.Button buttonfactoryreset;
        private System.Windows.Forms.Button buttonsurport;
    }
}

