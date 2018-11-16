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
            this.comboBoxtxpower = new System.Windows.Forms.ComboBox();
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
            this.buttoncleanreceive = new System.Windows.Forms.Button();
            this.labeltxcnt = new System.Windows.Forms.Label();
            this.labelrxcnt = new System.Windows.Forms.Label();
            this.checkBoxuarttransfer = new System.Windows.Forms.CheckBox();
            this.groupBoxuarttransfer = new System.Windows.Forms.GroupBox();
            this.groupBoxconfigarea = new System.Windows.Forms.GroupBox();
            this.timerrxtimeout = new System.Windows.Forms.Timer(this.components);
            this.labeladdr = new System.Windows.Forms.Label();
            this.labelchannel = new System.Windows.Forms.Label();
            this.textBoxaddr = new System.Windows.Forms.TextBox();
            this.textBoxchannel = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
            this.groupBoxuarttransfer.SuspendLayout();
            this.groupBoxconfigarea.SuspendLayout();
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
            this.comlist.Location = new System.Drawing.Point(258, 8);
            this.comlist.Name = "comlist";
            this.comlist.Size = new System.Drawing.Size(88, 20);
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
            this.buttoncomopen.Location = new System.Drawing.Point(258, 34);
            this.buttoncomopen.Name = "buttoncomopen";
            this.buttoncomopen.Size = new System.Drawing.Size(88, 20);
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
            "1200bps",
            "2400bps",
            "4800bps",
            "9600bps",
            "19200bps",
            "38400bps",
            "57600bps",
            "115200bps"});
            this.comboBoxuartbaud.Location = new System.Drawing.Point(86, 127);
            this.comboBoxuartbaud.Name = "comboBoxuartbaud";
            this.comboBoxuartbaud.Size = new System.Drawing.Size(76, 20);
            this.comboBoxuartbaud.TabIndex = 3;
            this.comboBoxuartbaud.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // labeluartbaud
            // 
            this.labeluartbaud.AutoSize = true;
            this.labeluartbaud.Location = new System.Drawing.Point(6, 130);
            this.labeluartbaud.Name = "labeluartbaud";
            this.labeluartbaud.Size = new System.Drawing.Size(53, 12);
            this.labeluartbaud.TabIndex = 5;
            this.labeluartbaud.Text = "串口速率";
            // 
            // labeluartparity
            // 
            this.labeluartparity.AutoSize = true;
            this.labeluartparity.Location = new System.Drawing.Point(6, 158);
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
            this.comboBoxuartparity.Location = new System.Drawing.Point(86, 155);
            this.comboBoxuartparity.Name = "comboBoxuartparity";
            this.comboBoxuartparity.Size = new System.Drawing.Size(76, 20);
            this.comboBoxuartparity.TabIndex = 7;
            // 
            // labelairbaud
            // 
            this.labelairbaud.AutoSize = true;
            this.labelairbaud.Location = new System.Drawing.Point(6, 186);
            this.labelairbaud.Name = "labelairbaud";
            this.labelairbaud.Size = new System.Drawing.Size(53, 12);
            this.labelairbaud.TabIndex = 8;
            this.labelairbaud.Text = "无线速率";
            // 
            // comboBoxairbaud
            // 
            this.comboBoxairbaud.FormattingEnabled = true;
            this.comboBoxairbaud.Items.AddRange(new object[] {
            "0.3kbps",
            "1.2kbps",
            "2.4kbps",
            "4.8kbps",
            "9.6kbps",
            "19.2kbps",
            "19.2kbps",
            "19.2kbps"});
            this.comboBoxairbaud.Location = new System.Drawing.Point(86, 183);
            this.comboBoxairbaud.Name = "comboBoxairbaud";
            this.comboBoxairbaud.Size = new System.Drawing.Size(76, 20);
            this.comboBoxairbaud.TabIndex = 9;
            // 
            // labeltxpower
            // 
            this.labeltxpower.AutoSize = true;
            this.labeltxpower.Location = new System.Drawing.Point(6, 214);
            this.labeltxpower.Name = "labeltxpower";
            this.labeltxpower.Size = new System.Drawing.Size(53, 12);
            this.labeltxpower.TabIndex = 10;
            this.labeltxpower.Text = "发射功率";
            // 
            // comboBoxtxpower
            // 
            this.comboBoxtxpower.FormattingEnabled = true;
            this.comboBoxtxpower.Items.AddRange(new object[] {
            "20dBm",
            "17dBm",
            "14dBm",
            "10dBm"});
            this.comboBoxtxpower.Location = new System.Drawing.Point(86, 211);
            this.comboBoxtxpower.Name = "comboBoxtxpower";
            this.comboBoxtxpower.Size = new System.Drawing.Size(76, 20);
            this.comboBoxtxpower.TabIndex = 11;
            // 
            // labelfecon
            // 
            this.labelfecon.AutoSize = true;
            this.labelfecon.Location = new System.Drawing.Point(208, 130);
            this.labelfecon.Name = "labelfecon";
            this.labelfecon.Size = new System.Drawing.Size(53, 12);
            this.labelfecon.TabIndex = 12;
            this.labelfecon.Text = "前向纠错";
            // 
            // labeltransfertype
            // 
            this.labeltransfertype.AutoSize = true;
            this.labeltransfertype.Location = new System.Drawing.Point(208, 158);
            this.labeltransfertype.Name = "labeltransfertype";
            this.labeltransfertype.Size = new System.Drawing.Size(53, 12);
            this.labeltransfertype.TabIndex = 13;
            this.labeltransfertype.Text = "传输方式";
            // 
            // labelwakeuptime
            // 
            this.labelwakeuptime.AutoSize = true;
            this.labelwakeuptime.Location = new System.Drawing.Point(208, 186);
            this.labelwakeuptime.Name = "labelwakeuptime";
            this.labelwakeuptime.Size = new System.Drawing.Size(53, 12);
            this.labelwakeuptime.TabIndex = 14;
            this.labelwakeuptime.Text = "唤醒时间";
            // 
            // labelIOdrive
            // 
            this.labelIOdrive.AutoSize = true;
            this.labelIOdrive.Location = new System.Drawing.Point(208, 214);
            this.labelIOdrive.Name = "labelIOdrive";
            this.labelIOdrive.Size = new System.Drawing.Size(53, 12);
            this.labelIOdrive.TabIndex = 15;
            this.labelIOdrive.Text = "I O 驱动";
            // 
            // comboBoxfecon
            // 
            this.comboBoxfecon.FormattingEnabled = true;
            this.comboBoxfecon.Items.AddRange(new object[] {
            "关闭",
            "打开"});
            this.comboBoxfecon.Location = new System.Drawing.Point(267, 127);
            this.comboBoxfecon.Name = "comboBoxfecon";
            this.comboBoxfecon.Size = new System.Drawing.Size(79, 20);
            this.comboBoxfecon.TabIndex = 16;
            // 
            // comboBoxtransfertype
            // 
            this.comboBoxtransfertype.FormattingEnabled = true;
            this.comboBoxtransfertype.Items.AddRange(new object[] {
            "透传",
            "定点"});
            this.comboBoxtransfertype.Location = new System.Drawing.Point(267, 155);
            this.comboBoxtransfertype.Name = "comboBoxtransfertype";
            this.comboBoxtransfertype.Size = new System.Drawing.Size(79, 20);
            this.comboBoxtransfertype.TabIndex = 17;
            // 
            // comboBoxwakeuptime
            // 
            this.comboBoxwakeuptime.FormattingEnabled = true;
            this.comboBoxwakeuptime.Items.AddRange(new object[] {
            "250ms",
            "500ms",
            "750ms",
            "1000ms",
            "1250ms",
            "1500ms",
            "1750ms",
            "2000ms"});
            this.comboBoxwakeuptime.Location = new System.Drawing.Point(267, 183);
            this.comboBoxwakeuptime.Name = "comboBoxwakeuptime";
            this.comboBoxwakeuptime.Size = new System.Drawing.Size(79, 20);
            this.comboBoxwakeuptime.TabIndex = 18;
            // 
            // comboBoxiodrive
            // 
            this.comboBoxiodrive.FormattingEnabled = true;
            this.comboBoxiodrive.Items.AddRange(new object[] {
            "开漏",
            "推挽"});
            this.comboBoxiodrive.Location = new System.Drawing.Point(267, 211);
            this.comboBoxiodrive.Name = "comboBoxiodrive";
            this.comboBoxiodrive.Size = new System.Drawing.Size(79, 20);
            this.comboBoxiodrive.TabIndex = 19;
            // 
            // labelcopyright
            // 
            this.labelcopyright.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            this.labelcopyright.AutoSize = true;
            this.labelcopyright.Location = new System.Drawing.Point(4, 333);
            this.labelcopyright.Name = "labelcopyright";
            this.labelcopyright.Size = new System.Drawing.Size(257, 12);
            this.labelcopyright.TabIndex = 20;
            this.labelcopyright.Text = "本软件著作权归上海鸣驹智能科技有限公司所有";
            // 
            // richTextBoxmoduleinfo
            // 
            this.richTextBoxmoduleinfo.AutoWordSelection = true;
            this.richTextBoxmoduleinfo.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.richTextBoxmoduleinfo.Location = new System.Drawing.Point(0, 32);
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
            this.richTextBoxcomrecv.Location = new System.Drawing.Point(4, 100);
            this.richTextBoxcomrecv.MaxLength = 5000;
            this.richTextBoxcomrecv.Name = "richTextBoxcomrecv";
            this.richTextBoxcomrecv.ReadOnly = true;
            this.richTextBoxcomrecv.Size = new System.Drawing.Size(403, 312);
            this.richTextBoxcomrecv.TabIndex = 22;
            this.richTextBoxcomrecv.Text = "串口接收窗口";
            // 
            // richTextBoxcomtrasmit
            // 
            this.richTextBoxcomtrasmit.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.richTextBoxcomtrasmit.Location = new System.Drawing.Point(4, 14);
            this.richTextBoxcomtrasmit.Name = "richTextBoxcomtrasmit";
            this.richTextBoxcomtrasmit.Size = new System.Drawing.Size(403, 54);
            this.richTextBoxcomtrasmit.TabIndex = 23;
            this.richTextBoxcomtrasmit.Text = "hello\n";
            // 
            // buttonsend
            // 
            this.buttonsend.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonsend.Location = new System.Drawing.Point(326, 74);
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
            this.textBoxsendcycle.Location = new System.Drawing.Point(102, 76);
            this.textBoxsendcycle.Name = "textBoxsendcycle";
            this.textBoxsendcycle.Size = new System.Drawing.Size(59, 21);
            this.textBoxsendcycle.TabIndex = 25;
            this.textBoxsendcycle.Text = "1000";
            this.textBoxsendcycle.TextChanged += new System.EventHandler(this.textBoxsendcycle_TextChanged);
            // 
            // checkBoxsendcycle
            // 
            this.checkBoxsendcycle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBoxsendcycle.AutoSize = true;
            this.checkBoxsendcycle.Location = new System.Drawing.Point(167, 78);
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
            this.labelsendcycle.Location = new System.Drawing.Point(19, 79);
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
            this.labelwebaddr.Location = new System.Drawing.Point(4, 393);
            this.labelwebaddr.Name = "labelwebaddr";
            this.labelwebaddr.Size = new System.Drawing.Size(65, 12);
            this.labelwebaddr.TabIndex = 28;
            this.labelwebaddr.Text = "官方网站：";
            // 
            // linkLabelwebsite
            // 
            this.linkLabelwebsite.AutoSize = true;
            this.linkLabelwebsite.Location = new System.Drawing.Point(75, 393);
            this.linkLabelwebsite.Name = "linkLabelwebsite";
            this.linkLabelwebsite.Size = new System.Drawing.Size(107, 12);
            this.linkLabelwebsite.TabIndex = 29;
            this.linkLabelwebsite.TabStop = true;
            this.linkLabelwebsite.Text = "www.coltsmart.com";
            this.linkLabelwebsite.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelwebsite_LinkClicked);
            // 
            // buttonreadparam
            // 
            this.buttonreadparam.Location = new System.Drawing.Point(0, 2);
            this.buttonreadparam.Name = "buttonreadparam";
            this.buttonreadparam.Size = new System.Drawing.Size(75, 23);
            this.buttonreadparam.TabIndex = 30;
            this.buttonreadparam.Text = "读取参数";
            this.buttonreadparam.UseVisualStyleBackColor = true;
            this.buttonreadparam.Click += new System.EventHandler(this.buttonreadparam_Click);
            // 
            // buttonwriteparam
            // 
            this.buttonwriteparam.Location = new System.Drawing.Point(86, 3);
            this.buttonwriteparam.Name = "buttonwriteparam";
            this.buttonwriteparam.Size = new System.Drawing.Size(75, 23);
            this.buttonwriteparam.TabIndex = 31;
            this.buttonwriteparam.Text = "写入参数";
            this.buttonwriteparam.UseVisualStyleBackColor = true;
            this.buttonwriteparam.Click += new System.EventHandler(this.buttonwriteparam_Click);
            // 
            // buttonfactoryreset
            // 
            this.buttonfactoryreset.Location = new System.Drawing.Point(172, 3);
            this.buttonfactoryreset.Name = "buttonfactoryreset";
            this.buttonfactoryreset.Size = new System.Drawing.Size(75, 23);
            this.buttonfactoryreset.TabIndex = 32;
            this.buttonfactoryreset.Text = "恢复出厂设置";
            this.buttonfactoryreset.UseVisualStyleBackColor = true;
            this.buttonfactoryreset.Click += new System.EventHandler(this.buttonfactoryreset_Click);
            // 
            // buttonsurport
            // 
            this.buttonsurport.Location = new System.Drawing.Point(258, 2);
            this.buttonsurport.Name = "buttonsurport";
            this.buttonsurport.Size = new System.Drawing.Size(88, 23);
            this.buttonsurport.TabIndex = 33;
            this.buttonsurport.Text = "查看支持型号";
            this.buttonsurport.UseVisualStyleBackColor = true;
            this.buttonsurport.Click += new System.EventHandler(this.buttonsurport_Click);
            // 
            // buttoncleanreceive
            // 
            this.buttoncleanreceive.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttoncleanreceive.Location = new System.Drawing.Point(245, 74);
            this.buttoncleanreceive.Name = "buttoncleanreceive";
            this.buttoncleanreceive.Size = new System.Drawing.Size(75, 23);
            this.buttoncleanreceive.TabIndex = 34;
            this.buttoncleanreceive.Text = "清空接收区";
            this.buttoncleanreceive.UseVisualStyleBackColor = true;
            this.buttoncleanreceive.Click += new System.EventHandler(this.buttoncleanreceive_Click);
            // 
            // labeltxcnt
            // 
            this.labeltxcnt.AutoSize = true;
            this.labeltxcnt.Location = new System.Drawing.Point(208, 393);
            this.labeltxcnt.Name = "labeltxcnt";
            this.labeltxcnt.Size = new System.Drawing.Size(29, 12);
            this.labeltxcnt.TabIndex = 35;
            this.labeltxcnt.Text = "Tx:0";
            // 
            // labelrxcnt
            // 
            this.labelrxcnt.AutoSize = true;
            this.labelrxcnt.Location = new System.Drawing.Point(289, 393);
            this.labelrxcnt.Name = "labelrxcnt";
            this.labelrxcnt.Size = new System.Drawing.Size(29, 12);
            this.labelrxcnt.TabIndex = 36;
            this.labelrxcnt.Text = "Rx:0";
            // 
            // checkBoxuarttransfer
            // 
            this.checkBoxuarttransfer.AutoSize = true;
            this.checkBoxuarttransfer.Location = new System.Drawing.Point(267, 332);
            this.checkBoxuarttransfer.Name = "checkBoxuarttransfer";
            this.checkBoxuarttransfer.Size = new System.Drawing.Size(84, 16);
            this.checkBoxuarttransfer.TabIndex = 37;
            this.checkBoxuarttransfer.Text = "使能收发区";
            this.checkBoxuarttransfer.UseVisualStyleBackColor = true;
            this.checkBoxuarttransfer.CheckedChanged += new System.EventHandler(this.checkBoxuarttransfer_CheckedChanged);
            // 
            // groupBoxuarttransfer
            // 
            this.groupBoxuarttransfer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxuarttransfer.Controls.Add(this.richTextBoxcomtrasmit);
            this.groupBoxuarttransfer.Controls.Add(this.buttonsend);
            this.groupBoxuarttransfer.Controls.Add(this.buttoncleanreceive);
            this.groupBoxuarttransfer.Controls.Add(this.checkBoxsendcycle);
            this.groupBoxuarttransfer.Controls.Add(this.textBoxsendcycle);
            this.groupBoxuarttransfer.Controls.Add(this.labelsendcycle);
            this.groupBoxuarttransfer.Controls.Add(this.richTextBoxcomrecv);
            this.groupBoxuarttransfer.Enabled = false;
            this.groupBoxuarttransfer.Location = new System.Drawing.Point(375, 0);
            this.groupBoxuarttransfer.Name = "groupBoxuarttransfer";
            this.groupBoxuarttransfer.Size = new System.Drawing.Size(413, 414);
            this.groupBoxuarttransfer.TabIndex = 38;
            this.groupBoxuarttransfer.TabStop = false;
            this.groupBoxuarttransfer.Text = "收发测试区";
            // 
            // groupBoxconfigarea
            // 
            this.groupBoxconfigarea.Controls.Add(this.buttonreadparam);
            this.groupBoxconfigarea.Controls.Add(this.buttonwriteparam);
            this.groupBoxconfigarea.Controls.Add(this.buttonfactoryreset);
            this.groupBoxconfigarea.Controls.Add(this.buttonsurport);
            this.groupBoxconfigarea.Controls.Add(this.richTextBoxmoduleinfo);
            this.groupBoxconfigarea.Controls.Add(this.comboBoxuartbaud);
            this.groupBoxconfigarea.Controls.Add(this.labeluartbaud);
            this.groupBoxconfigarea.Controls.Add(this.comboBoxiodrive);
            this.groupBoxconfigarea.Controls.Add(this.labelfecon);
            this.groupBoxconfigarea.Controls.Add(this.labelIOdrive);
            this.groupBoxconfigarea.Controls.Add(this.comboBoxwakeuptime);
            this.groupBoxconfigarea.Controls.Add(this.comboBoxtxpower);
            this.groupBoxconfigarea.Controls.Add(this.comboBoxfecon);
            this.groupBoxconfigarea.Controls.Add(this.labeltxpower);
            this.groupBoxconfigarea.Controls.Add(this.comboBoxtransfertype);
            this.groupBoxconfigarea.Controls.Add(this.labelwakeuptime);
            this.groupBoxconfigarea.Controls.Add(this.labeluartparity);
            this.groupBoxconfigarea.Controls.Add(this.comboBoxuartparity);
            this.groupBoxconfigarea.Controls.Add(this.labeltransfertype);
            this.groupBoxconfigarea.Controls.Add(this.comboBoxairbaud);
            this.groupBoxconfigarea.Controls.Add(this.labelairbaud);
            this.groupBoxconfigarea.Location = new System.Drawing.Point(0, 57);
            this.groupBoxconfigarea.Name = "groupBoxconfigarea";
            this.groupBoxconfigarea.Size = new System.Drawing.Size(346, 239);
            this.groupBoxconfigarea.TabIndex = 35;
            this.groupBoxconfigarea.TabStop = false;
            // 
            // timerrxtimeout
            // 
            this.timerrxtimeout.Interval = 500;
            this.timerrxtimeout.Tick += new System.EventHandler(this.timerrxtimeout_Tick);
            // 
            // labeladdr
            // 
            this.labeladdr.AutoSize = true;
            this.labeladdr.Location = new System.Drawing.Point(6, 299);
            this.labeladdr.Name = "labeladdr";
            this.labeladdr.Size = new System.Drawing.Size(53, 12);
            this.labeladdr.TabIndex = 39;
            this.labeladdr.Text = "模块地址";
            // 
            // labelchannel
            // 
            this.labelchannel.AutoSize = true;
            this.labelchannel.Location = new System.Drawing.Point(208, 299);
            this.labelchannel.Name = "labelchannel";
            this.labelchannel.Size = new System.Drawing.Size(53, 12);
            this.labelchannel.TabIndex = 40;
            this.labelchannel.Text = "频率信道";
            // 
            // textBoxaddr
            // 
            this.textBoxaddr.Location = new System.Drawing.Point(86, 296);
            this.textBoxaddr.Name = "textBoxaddr";
            this.textBoxaddr.Size = new System.Drawing.Size(76, 21);
            this.textBoxaddr.TabIndex = 41;
            this.textBoxaddr.Text = "0";
            // 
            // textBoxchannel
            // 
            this.textBoxchannel.Location = new System.Drawing.Point(267, 296);
            this.textBoxchannel.Name = "textBoxchannel";
            this.textBoxchannel.Size = new System.Drawing.Size(79, 21);
            this.textBoxchannel.TabIndex = 35;
            this.textBoxchannel.Text = "23";
            // 
            // LoraUartTransferConfigTool
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(788, 414);
            this.Controls.Add(this.textBoxchannel);
            this.Controls.Add(this.textBoxaddr);
            this.Controls.Add(this.labelchannel);
            this.Controls.Add(this.labeladdr);
            this.Controls.Add(this.groupBoxconfigarea);
            this.Controls.Add(this.groupBoxuarttransfer);
            this.Controls.Add(this.checkBoxuarttransfer);
            this.Controls.Add(this.labelrxcnt);
            this.Controls.Add(this.labeltxcnt);
            this.Controls.Add(this.linkLabelwebsite);
            this.Controls.Add(this.labelwebaddr);
            this.Controls.Add(this.labelcopyright);
            this.Controls.Add(this.buttoncomopen);
            this.Controls.Add(this.logo);
            this.Controls.Add(this.comlist);
            this.Name = "LoraUartTransferConfigTool";
            this.Text = "LoraUartTransferConfigTool";
            ((System.ComponentModel.ISupportInitialize)(this.logo)).EndInit();
            this.groupBoxuarttransfer.ResumeLayout(false);
            this.groupBoxuarttransfer.PerformLayout();
            this.groupBoxconfigarea.ResumeLayout(false);
            this.groupBoxconfigarea.PerformLayout();
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
        private System.Windows.Forms.ComboBox comboBoxtxpower;
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
        private System.Windows.Forms.Button buttoncleanreceive;
        private System.Windows.Forms.Label labeltxcnt;
        private System.Windows.Forms.Label labelrxcnt;
        private System.Windows.Forms.CheckBox checkBoxuarttransfer;
        private System.Windows.Forms.GroupBox groupBoxuarttransfer;
        private System.Windows.Forms.GroupBox groupBoxconfigarea;
        private System.Windows.Forms.Timer timerrxtimeout;
        private System.Windows.Forms.Label labeladdr;
        private System.Windows.Forms.Label labelchannel;
        private System.Windows.Forms.TextBox textBoxaddr;
        private System.Windows.Forms.TextBox textBoxchannel;
    }
}

