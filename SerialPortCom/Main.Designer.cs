namespace SerialPortCom
{
    partial class Main
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
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.serialPort = new System.IO.Ports.SerialPort(this.components);
            this.groupBoxSerial = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanelSet = new System.Windows.Forms.TableLayoutPanel();
            this.comboBoxStop = new System.Windows.Forms.ComboBox();
            this.comboBoxPick = new System.Windows.Forms.ComboBox();
            this.comboBoxDate = new System.Windows.Forms.ComboBox();
            this.buttonSerial = new System.Windows.Forms.Button();
            this.labelSerial = new System.Windows.Forms.Label();
            this.comboBoxSerial = new System.Windows.Forms.ComboBox();
            this.comboBoxRate = new System.Windows.Forms.ComboBox();
            this.labelRate = new System.Windows.Forms.Label();
            this.labelDate = new System.Windows.Forms.Label();
            this.labelPick = new System.Windows.Forms.Label();
            this.labelStop = new System.Windows.Forms.Label();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.buttonSend = new System.Windows.Forms.Button();
            this.textBoxSend = new System.Windows.Forms.TextBox();
            this.labelMessage = new System.Windows.Forms.Label();
            this.groupBoxDateRev = new System.Windows.Forms.GroupBox();
            this.textBoxRev = new System.Windows.Forms.TextBox();
            this.buttonClear = new System.Windows.Forms.Button();
            this.groupBoxDateSend = new System.Windows.Forms.GroupBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.连接说明ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.串口设置ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.关于ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.作者JluTigerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.学校吉林大学ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.数据格式ASCIIToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.退出ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBoxControl = new System.Windows.Forms.GroupBox();
            this.panelMiddleMiddle = new System.Windows.Forms.Panel();
            this.labelRateTip = new System.Windows.Forms.Label();
            this.comboBoxSet = new System.Windows.Forms.ComboBox();
            this.labelTip = new System.Windows.Forms.Label();
            this.panelImage = new System.Windows.Forms.Panel();
            this.groupBoxSet = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanelSetting = new System.Windows.Forms.TableLayoutPanel();
            this.buttonSet2 = new System.Windows.Forms.Button();
            this.buttonSet3 = new System.Windows.Forms.Button();
            this.buttonSet4 = new System.Windows.Forms.Button();
            this.buttonSet1 = new System.Windows.Forms.Button();
            this.tableLayoutPanelControl = new System.Windows.Forms.TableLayoutPanel();
            this.buttonRight = new System.Windows.Forms.Button();
            this.buttonLeft = new System.Windows.Forms.Button();
            this.buttonDown = new System.Windows.Forms.Button();
            this.buttonUp = new System.Windows.Forms.Button();
            this.panelTop = new System.Windows.Forms.Panel();
            this.panelTopRight = new System.Windows.Forms.Panel();
            this.panelBottom = new System.Windows.Forms.Panel();
            this.labelMes = new System.Windows.Forms.Label();
            this.panelMiddle = new System.Windows.Forms.Panel();
            this.groupBoxSerial.SuspendLayout();
            this.tableLayoutPanelSet.SuspendLayout();
            this.groupBoxDateRev.SuspendLayout();
            this.groupBoxDateSend.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.groupBoxControl.SuspendLayout();
            this.panelMiddleMiddle.SuspendLayout();
            this.groupBoxSet.SuspendLayout();
            this.tableLayoutPanelSetting.SuspendLayout();
            this.tableLayoutPanelControl.SuspendLayout();
            this.panelTop.SuspendLayout();
            this.panelTopRight.SuspendLayout();
            this.panelBottom.SuspendLayout();
            this.panelMiddle.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxSerial
            // 
            this.groupBoxSerial.BackColor = System.Drawing.Color.White;
            this.groupBoxSerial.Controls.Add(this.tableLayoutPanelSet);
            this.groupBoxSerial.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBoxSerial.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBoxSerial.Location = new System.Drawing.Point(0, 0);
            this.groupBoxSerial.Margin = new System.Windows.Forms.Padding(2);
            this.groupBoxSerial.Name = "groupBoxSerial";
            this.groupBoxSerial.Padding = new System.Windows.Forms.Padding(2);
            this.groupBoxSerial.Size = new System.Drawing.Size(296, 338);
            this.groupBoxSerial.TabIndex = 0;
            this.groupBoxSerial.TabStop = false;
            this.groupBoxSerial.Text = "串口设置";
            // 
            // tableLayoutPanelSet
            // 
            this.tableLayoutPanelSet.ColumnCount = 2;
            this.tableLayoutPanelSet.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelSet.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelSet.Controls.Add(this.comboBoxStop, 1, 4);
            this.tableLayoutPanelSet.Controls.Add(this.comboBoxPick, 1, 3);
            this.tableLayoutPanelSet.Controls.Add(this.comboBoxDate, 1, 2);
            this.tableLayoutPanelSet.Controls.Add(this.buttonSerial, 1, 5);
            this.tableLayoutPanelSet.Controls.Add(this.labelSerial, 0, 0);
            this.tableLayoutPanelSet.Controls.Add(this.comboBoxSerial, 1, 0);
            this.tableLayoutPanelSet.Controls.Add(this.comboBoxRate, 1, 1);
            this.tableLayoutPanelSet.Controls.Add(this.labelRate, 0, 1);
            this.tableLayoutPanelSet.Controls.Add(this.labelDate, 0, 2);
            this.tableLayoutPanelSet.Controls.Add(this.labelPick, 0, 3);
            this.tableLayoutPanelSet.Controls.Add(this.labelStop, 0, 4);
            this.tableLayoutPanelSet.Controls.Add(this.buttonUpdate, 0, 5);
            this.tableLayoutPanelSet.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelSet.Location = new System.Drawing.Point(2, 26);
            this.tableLayoutPanelSet.Name = "tableLayoutPanelSet";
            this.tableLayoutPanelSet.RowCount = 6;
            this.tableLayoutPanelSet.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanelSet.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanelSet.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanelSet.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanelSet.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanelSet.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanelSet.Size = new System.Drawing.Size(292, 310);
            this.tableLayoutPanelSet.TabIndex = 7;
            // 
            // comboBoxStop
            // 
            this.comboBoxStop.BackColor = System.Drawing.SystemColors.ControlLight;
            this.comboBoxStop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.comboBoxStop.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxStop.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.comboBoxStop.FormattingEnabled = true;
            this.comboBoxStop.Items.AddRange(new object[] {
            "1",
            "1.5",
            "2"});
            this.comboBoxStop.Location = new System.Drawing.Point(149, 207);
            this.comboBoxStop.Name = "comboBoxStop";
            this.comboBoxStop.Size = new System.Drawing.Size(140, 32);
            this.comboBoxStop.TabIndex = 7;
            // 
            // comboBoxPick
            // 
            this.comboBoxPick.BackColor = System.Drawing.SystemColors.ControlLight;
            this.comboBoxPick.Dock = System.Windows.Forms.DockStyle.Fill;
            this.comboBoxPick.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxPick.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.comboBoxPick.FormattingEnabled = true;
            this.comboBoxPick.Items.AddRange(new object[] {
            "None",
            "Even",
            "Odd",
            "Mask",
            "Space"});
            this.comboBoxPick.Location = new System.Drawing.Point(149, 156);
            this.comboBoxPick.Name = "comboBoxPick";
            this.comboBoxPick.Size = new System.Drawing.Size(140, 32);
            this.comboBoxPick.TabIndex = 7;
            // 
            // comboBoxDate
            // 
            this.comboBoxDate.BackColor = System.Drawing.SystemColors.ControlLight;
            this.comboBoxDate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.comboBoxDate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxDate.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.comboBoxDate.FormattingEnabled = true;
            this.comboBoxDate.Items.AddRange(new object[] {
            "5",
            "6",
            "7",
            "8"});
            this.comboBoxDate.Location = new System.Drawing.Point(149, 105);
            this.comboBoxDate.Name = "comboBoxDate";
            this.comboBoxDate.Size = new System.Drawing.Size(140, 32);
            this.comboBoxDate.TabIndex = 7;
            // 
            // buttonSerial
            // 
            this.buttonSerial.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonSerial.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonSerial.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.buttonSerial.ForeColor = System.Drawing.Color.ForestGreen;
            this.buttonSerial.Location = new System.Drawing.Point(149, 258);
            this.buttonSerial.Name = "buttonSerial";
            this.buttonSerial.Size = new System.Drawing.Size(140, 49);
            this.buttonSerial.TabIndex = 4;
            this.buttonSerial.Text = "打开串口";
            this.buttonSerial.UseVisualStyleBackColor = true;
            this.buttonSerial.Click += new System.EventHandler(this.buttonSerial_Click);
            // 
            // labelSerial
            // 
            this.labelSerial.AutoSize = true;
            this.labelSerial.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelSerial.Location = new System.Drawing.Point(3, 0);
            this.labelSerial.Name = "labelSerial";
            this.labelSerial.Size = new System.Drawing.Size(140, 51);
            this.labelSerial.TabIndex = 0;
            this.labelSerial.Text = "（1）端口号：";
            this.labelSerial.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // comboBoxSerial
            // 
            this.comboBoxSerial.BackColor = System.Drawing.SystemColors.ControlLight;
            this.comboBoxSerial.Dock = System.Windows.Forms.DockStyle.Fill;
            this.comboBoxSerial.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSerial.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.comboBoxSerial.ForeColor = System.Drawing.SystemColors.WindowText;
            this.comboBoxSerial.FormattingEnabled = true;
            this.comboBoxSerial.Location = new System.Drawing.Point(149, 3);
            this.comboBoxSerial.Name = "comboBoxSerial";
            this.comboBoxSerial.Size = new System.Drawing.Size(140, 32);
            this.comboBoxSerial.TabIndex = 3;
            // 
            // comboBoxRate
            // 
            this.comboBoxRate.BackColor = System.Drawing.SystemColors.ControlLight;
            this.comboBoxRate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.comboBoxRate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxRate.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.comboBoxRate.FormattingEnabled = true;
            this.comboBoxRate.Items.AddRange(new object[] {
            "4800",
            "9600",
            "19200",
            "38400",
            "115200"});
            this.comboBoxRate.Location = new System.Drawing.Point(149, 54);
            this.comboBoxRate.Name = "comboBoxRate";
            this.comboBoxRate.Size = new System.Drawing.Size(140, 32);
            this.comboBoxRate.TabIndex = 2;
            // 
            // labelRate
            // 
            this.labelRate.AutoSize = true;
            this.labelRate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelRate.Location = new System.Drawing.Point(3, 51);
            this.labelRate.Name = "labelRate";
            this.labelRate.Size = new System.Drawing.Size(140, 51);
            this.labelRate.TabIndex = 1;
            this.labelRate.Text = "（2）波特率：";
            this.labelRate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelDate
            // 
            this.labelDate.AutoSize = true;
            this.labelDate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelDate.Location = new System.Drawing.Point(3, 102);
            this.labelDate.Name = "labelDate";
            this.labelDate.Size = new System.Drawing.Size(140, 51);
            this.labelDate.TabIndex = 5;
            this.labelDate.Text = "（3）数据位：";
            this.labelDate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelPick
            // 
            this.labelPick.AutoSize = true;
            this.labelPick.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelPick.Location = new System.Drawing.Point(3, 153);
            this.labelPick.Name = "labelPick";
            this.labelPick.Size = new System.Drawing.Size(140, 51);
            this.labelPick.TabIndex = 6;
            this.labelPick.Text = "（4）校验位：";
            this.labelPick.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelStop
            // 
            this.labelStop.AutoSize = true;
            this.labelStop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelStop.Location = new System.Drawing.Point(3, 204);
            this.labelStop.Name = "labelStop";
            this.labelStop.Size = new System.Drawing.Size(140, 51);
            this.labelStop.TabIndex = 7;
            this.labelStop.Text = "（5）停止位：";
            this.labelStop.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonUpdate.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.buttonUpdate.ForeColor = System.Drawing.Color.ForestGreen;
            this.buttonUpdate.Location = new System.Drawing.Point(3, 258);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(140, 49);
            this.buttonUpdate.TabIndex = 8;
            this.buttonUpdate.Text = "刷新串口";
            this.buttonUpdate.UseVisualStyleBackColor = true;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // buttonSend
            // 
            this.buttonSend.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonSend.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.buttonSend.ForeColor = System.Drawing.Color.ForestGreen;
            this.buttonSend.Location = new System.Drawing.Point(629, 38);
            this.buttonSend.Name = "buttonSend";
            this.buttonSend.Size = new System.Drawing.Size(126, 36);
            this.buttonSend.TabIndex = 5;
            this.buttonSend.Text = "发送";
            this.buttonSend.UseVisualStyleBackColor = true;
            this.buttonSend.Click += new System.EventHandler(this.buttonSend_Click);
            // 
            // textBoxSend
            // 
            this.textBoxSend.Location = new System.Drawing.Point(6, 38);
            this.textBoxSend.Name = "textBoxSend";
            this.textBoxSend.Size = new System.Drawing.Size(616, 31);
            this.textBoxSend.TabIndex = 6;
            // 
            // labelMessage
            // 
            this.labelMessage.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelMessage.Dock = System.Windows.Forms.DockStyle.Right;
            this.labelMessage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelMessage.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelMessage.ForeColor = System.Drawing.Color.Black;
            this.labelMessage.Location = new System.Drawing.Point(108, 0);
            this.labelMessage.Name = "labelMessage";
            this.labelMessage.Size = new System.Drawing.Size(956, 26);
            this.labelMessage.TabIndex = 7;
            this.labelMessage.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // groupBoxDateRev
            // 
            this.groupBoxDateRev.Controls.Add(this.textBoxRev);
            this.groupBoxDateRev.Controls.Add(this.buttonClear);
            this.groupBoxDateRev.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBoxDateRev.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBoxDateRev.Location = new System.Drawing.Point(0, 0);
            this.groupBoxDateRev.Name = "groupBoxDateRev";
            this.groupBoxDateRev.Size = new System.Drawing.Size(768, 224);
            this.groupBoxDateRev.TabIndex = 8;
            this.groupBoxDateRev.TabStop = false;
            this.groupBoxDateRev.Text = "接收数据";
            // 
            // textBoxRev
            // 
            this.textBoxRev.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.textBoxRev.Enabled = false;
            this.textBoxRev.Location = new System.Drawing.Point(6, 30);
            this.textBoxRev.Multiline = true;
            this.textBoxRev.Name = "textBoxRev";
            this.textBoxRev.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxRev.Size = new System.Drawing.Size(749, 144);
            this.textBoxRev.TabIndex = 2;
            // 
            // buttonClear
            // 
            this.buttonClear.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonClear.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.buttonClear.ForeColor = System.Drawing.Color.ForestGreen;
            this.buttonClear.Location = new System.Drawing.Point(629, 180);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(126, 38);
            this.buttonClear.TabIndex = 1;
            this.buttonClear.Text = "清空";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // groupBoxDateSend
            // 
            this.groupBoxDateSend.Controls.Add(this.buttonSend);
            this.groupBoxDateSend.Controls.Add(this.textBoxSend);
            this.groupBoxDateSend.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBoxDateSend.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBoxDateSend.Location = new System.Drawing.Point(0, 246);
            this.groupBoxDateSend.Name = "groupBoxDateSend";
            this.groupBoxDateSend.Size = new System.Drawing.Size(768, 92);
            this.groupBoxDateSend.TabIndex = 9;
            this.groupBoxDateSend.TabStop = false;
            this.groupBoxDateSend.Text = "发送数据";
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.menuStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.连接说明ToolStripMenuItem,
            this.关于ToolStripMenuItem,
            this.退出ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.menuStrip1.Size = new System.Drawing.Size(1068, 32);
            this.menuStrip1.TabIndex = 10;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 连接说明ToolStripMenuItem
            // 
            this.连接说明ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.串口设置ToolStripMenuItem});
            this.连接说明ToolStripMenuItem.Name = "连接说明ToolStripMenuItem";
            this.连接说明ToolStripMenuItem.Size = new System.Drawing.Size(94, 28);
            this.连接说明ToolStripMenuItem.Text = "连接说明";
            // 
            // 串口设置ToolStripMenuItem
            // 
            this.串口设置ToolStripMenuItem.Name = "串口设置ToolStripMenuItem";
            this.串口设置ToolStripMenuItem.Size = new System.Drawing.Size(164, 30);
            this.串口设置ToolStripMenuItem.Text = "串口设置";
            this.串口设置ToolStripMenuItem.Click += new System.EventHandler(this.串口设置ToolStripMenuItem_Click);
            // 
            // 关于ToolStripMenuItem
            // 
            this.关于ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.作者JluTigerToolStripMenuItem,
            this.学校吉林大学ToolStripMenuItem,
            this.数据格式ASCIIToolStripMenuItem});
            this.关于ToolStripMenuItem.Name = "关于ToolStripMenuItem";
            this.关于ToolStripMenuItem.Size = new System.Drawing.Size(58, 28);
            this.关于ToolStripMenuItem.Text = "关于";
            // 
            // 作者JluTigerToolStripMenuItem
            // 
            this.作者JluTigerToolStripMenuItem.Name = "作者JluTigerToolStripMenuItem";
            this.作者JluTigerToolStripMenuItem.Size = new System.Drawing.Size(273, 30);
            this.作者JluTigerToolStripMenuItem.Text = "作者：JluTiger";
            // 
            // 学校吉林大学ToolStripMenuItem
            // 
            this.学校吉林大学ToolStripMenuItem.Name = "学校吉林大学ToolStripMenuItem";
            this.学校吉林大学ToolStripMenuItem.Size = new System.Drawing.Size(273, 30);
            this.学校吉林大学ToolStripMenuItem.Text = "学校：JiLin University";
            // 
            // 数据格式ASCIIToolStripMenuItem
            // 
            this.数据格式ASCIIToolStripMenuItem.Name = "数据格式ASCIIToolStripMenuItem";
            this.数据格式ASCIIToolStripMenuItem.Size = new System.Drawing.Size(273, 30);
            this.数据格式ASCIIToolStripMenuItem.Text = "数据格式：ASCII";
            // 
            // 退出ToolStripMenuItem
            // 
            this.退出ToolStripMenuItem.Name = "退出ToolStripMenuItem";
            this.退出ToolStripMenuItem.Size = new System.Drawing.Size(58, 28);
            this.退出ToolStripMenuItem.Text = "退出";
            this.退出ToolStripMenuItem.Click += new System.EventHandler(this.退出ToolStripMenuItem_Click);
            // 
            // groupBoxControl
            // 
            this.groupBoxControl.Controls.Add(this.panelMiddleMiddle);
            this.groupBoxControl.Controls.Add(this.panelImage);
            this.groupBoxControl.Controls.Add(this.groupBoxSet);
            this.groupBoxControl.Controls.Add(this.tableLayoutPanelControl);
            this.groupBoxControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxControl.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBoxControl.Location = new System.Drawing.Point(0, 0);
            this.groupBoxControl.Name = "groupBoxControl";
            this.groupBoxControl.Size = new System.Drawing.Size(1064, 233);
            this.groupBoxControl.TabIndex = 11;
            this.groupBoxControl.TabStop = false;
            this.groupBoxControl.Text = "控制区";
            // 
            // panelMiddleMiddle
            // 
            this.panelMiddleMiddle.Controls.Add(this.labelRateTip);
            this.panelMiddleMiddle.Controls.Add(this.comboBoxSet);
            this.panelMiddleMiddle.Controls.Add(this.labelTip);
            this.panelMiddleMiddle.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelMiddleMiddle.Location = new System.Drawing.Point(210, 185);
            this.panelMiddleMiddle.Name = "panelMiddleMiddle";
            this.panelMiddleMiddle.Size = new System.Drawing.Size(592, 45);
            this.panelMiddleMiddle.TabIndex = 7;
            // 
            // labelRateTip
            // 
            this.labelRateTip.Dock = System.Windows.Forms.DockStyle.Left;
            this.labelRateTip.Location = new System.Drawing.Point(0, 0);
            this.labelRateTip.Name = "labelRateTip";
            this.labelRateTip.Size = new System.Drawing.Size(121, 45);
            this.labelRateTip.TabIndex = 2;
            this.labelRateTip.Text = "控制调节：";
            this.labelRateTip.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // comboBoxSet
            // 
            this.comboBoxSet.BackColor = System.Drawing.SystemColors.ControlLight;
            this.comboBoxSet.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSet.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.comboBoxSet.FormattingEnabled = true;
            this.comboBoxSet.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6"});
            this.comboBoxSet.Location = new System.Drawing.Point(127, 6);
            this.comboBoxSet.Name = "comboBoxSet";
            this.comboBoxSet.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.comboBoxSet.Size = new System.Drawing.Size(121, 32);
            this.comboBoxSet.TabIndex = 1;
            // 
            // labelTip
            // 
            this.labelTip.Dock = System.Windows.Forms.DockStyle.Right;
            this.labelTip.Font = new System.Drawing.Font("微软雅黑", 7.5F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelTip.Location = new System.Drawing.Point(276, 0);
            this.labelTip.Name = "labelTip";
            this.labelTip.Size = new System.Drawing.Size(316, 45);
            this.labelTip.TabIndex = 3;
            this.labelTip.Text = "默认为1,表示发送一次指令，大约行进3cm。";
            this.labelTip.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelImage
            // 
            this.panelImage.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelImage.BackgroundImage")));
            this.panelImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelImage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelImage.Location = new System.Drawing.Point(210, 27);
            this.panelImage.Name = "panelImage";
            this.panelImage.Size = new System.Drawing.Size(592, 203);
            this.panelImage.TabIndex = 6;
            // 
            // groupBoxSet
            // 
            this.groupBoxSet.Controls.Add(this.tableLayoutPanelSetting);
            this.groupBoxSet.Dock = System.Windows.Forms.DockStyle.Right;
            this.groupBoxSet.Location = new System.Drawing.Point(802, 27);
            this.groupBoxSet.Name = "groupBoxSet";
            this.groupBoxSet.Size = new System.Drawing.Size(259, 203);
            this.groupBoxSet.TabIndex = 5;
            this.groupBoxSet.TabStop = false;
            this.groupBoxSet.Text = "自定义动作";
            // 
            // tableLayoutPanelSetting
            // 
            this.tableLayoutPanelSetting.ColumnCount = 2;
            this.tableLayoutPanelSetting.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelSetting.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelSetting.Controls.Add(this.buttonSet2, 1, 0);
            this.tableLayoutPanelSetting.Controls.Add(this.buttonSet3, 0, 1);
            this.tableLayoutPanelSetting.Controls.Add(this.buttonSet4, 0, 1);
            this.tableLayoutPanelSetting.Controls.Add(this.buttonSet1, 0, 0);
            this.tableLayoutPanelSetting.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelSetting.Location = new System.Drawing.Point(3, 27);
            this.tableLayoutPanelSetting.Name = "tableLayoutPanelSetting";
            this.tableLayoutPanelSetting.RowCount = 2;
            this.tableLayoutPanelSetting.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelSetting.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelSetting.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanelSetting.Size = new System.Drawing.Size(253, 173);
            this.tableLayoutPanelSetting.TabIndex = 0;
            // 
            // buttonSet2
            // 
            this.buttonSet2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.buttonSet2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonSet2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSet2.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.buttonSet2.ForeColor = System.Drawing.Color.ForestGreen;
            this.buttonSet2.Location = new System.Drawing.Point(129, 3);
            this.buttonSet2.Name = "buttonSet2";
            this.buttonSet2.Size = new System.Drawing.Size(121, 80);
            this.buttonSet2.TabIndex = 6;
            this.buttonSet2.Text = "自定义2";
            this.buttonSet2.UseVisualStyleBackColor = false;
            // 
            // buttonSet3
            // 
            this.buttonSet3.BackColor = System.Drawing.Color.WhiteSmoke;
            this.buttonSet3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonSet3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSet3.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.buttonSet3.ForeColor = System.Drawing.Color.ForestGreen;
            this.buttonSet3.Location = new System.Drawing.Point(3, 89);
            this.buttonSet3.Name = "buttonSet3";
            this.buttonSet3.Size = new System.Drawing.Size(120, 81);
            this.buttonSet3.TabIndex = 4;
            this.buttonSet3.Text = "自定义3";
            this.buttonSet3.UseVisualStyleBackColor = false;
            // 
            // buttonSet4
            // 
            this.buttonSet4.BackColor = System.Drawing.Color.WhiteSmoke;
            this.buttonSet4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonSet4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSet4.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.buttonSet4.ForeColor = System.Drawing.Color.ForestGreen;
            this.buttonSet4.Location = new System.Drawing.Point(129, 89);
            this.buttonSet4.Name = "buttonSet4";
            this.buttonSet4.Size = new System.Drawing.Size(121, 81);
            this.buttonSet4.TabIndex = 3;
            this.buttonSet4.Text = "自定义4";
            this.buttonSet4.UseVisualStyleBackColor = false;
            // 
            // buttonSet1
            // 
            this.buttonSet1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.buttonSet1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonSet1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSet1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.buttonSet1.ForeColor = System.Drawing.Color.ForestGreen;
            this.buttonSet1.Location = new System.Drawing.Point(3, 3);
            this.buttonSet1.Name = "buttonSet1";
            this.buttonSet1.Size = new System.Drawing.Size(120, 80);
            this.buttonSet1.TabIndex = 2;
            this.buttonSet1.Text = "自定义1";
            this.buttonSet1.UseVisualStyleBackColor = false;
            // 
            // tableLayoutPanelControl
            // 
            this.tableLayoutPanelControl.ColumnCount = 3;
            this.tableLayoutPanelControl.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanelControl.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanelControl.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanelControl.Controls.Add(this.buttonRight, 2, 1);
            this.tableLayoutPanelControl.Controls.Add(this.buttonLeft, 0, 1);
            this.tableLayoutPanelControl.Controls.Add(this.buttonDown, 1, 2);
            this.tableLayoutPanelControl.Controls.Add(this.buttonUp, 1, 0);
            this.tableLayoutPanelControl.Dock = System.Windows.Forms.DockStyle.Left;
            this.tableLayoutPanelControl.Location = new System.Drawing.Point(3, 27);
            this.tableLayoutPanelControl.Name = "tableLayoutPanelControl";
            this.tableLayoutPanelControl.RowCount = 3;
            this.tableLayoutPanelControl.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanelControl.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanelControl.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanelControl.Size = new System.Drawing.Size(207, 203);
            this.tableLayoutPanelControl.TabIndex = 0;
            // 
            // buttonRight
            // 
            this.buttonRight.BackColor = System.Drawing.Color.WhiteSmoke;
            this.buttonRight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonRight.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRight.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.buttonRight.ForeColor = System.Drawing.Color.ForestGreen;
            this.buttonRight.Location = new System.Drawing.Point(141, 70);
            this.buttonRight.Name = "buttonRight";
            this.buttonRight.Size = new System.Drawing.Size(63, 61);
            this.buttonRight.TabIndex = 2;
            this.buttonRight.Text = "右转";
            this.buttonRight.UseVisualStyleBackColor = false;
            this.buttonRight.Click += new System.EventHandler(this.buttonRight_Click);
            // 
            // buttonLeft
            // 
            this.buttonLeft.BackColor = System.Drawing.Color.WhiteSmoke;
            this.buttonLeft.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonLeft.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLeft.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.buttonLeft.ForeColor = System.Drawing.Color.ForestGreen;
            this.buttonLeft.Location = new System.Drawing.Point(3, 70);
            this.buttonLeft.Name = "buttonLeft";
            this.buttonLeft.Size = new System.Drawing.Size(63, 61);
            this.buttonLeft.TabIndex = 3;
            this.buttonLeft.Text = "左转";
            this.buttonLeft.UseVisualStyleBackColor = false;
            this.buttonLeft.Click += new System.EventHandler(this.buttonLeft_Click);
            // 
            // buttonDown
            // 
            this.buttonDown.BackColor = System.Drawing.Color.WhiteSmoke;
            this.buttonDown.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonDown.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDown.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.buttonDown.ForeColor = System.Drawing.Color.ForestGreen;
            this.buttonDown.Location = new System.Drawing.Point(72, 137);
            this.buttonDown.Name = "buttonDown";
            this.buttonDown.Size = new System.Drawing.Size(63, 63);
            this.buttonDown.TabIndex = 4;
            this.buttonDown.Text = "后退";
            this.buttonDown.UseVisualStyleBackColor = false;
            this.buttonDown.Click += new System.EventHandler(this.buttonDown_Click);
            // 
            // buttonUp
            // 
            this.buttonUp.BackColor = System.Drawing.Color.WhiteSmoke;
            this.buttonUp.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonUp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonUp.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.buttonUp.ForeColor = System.Drawing.Color.ForestGreen;
            this.buttonUp.Location = new System.Drawing.Point(72, 3);
            this.buttonUp.Name = "buttonUp";
            this.buttonUp.Size = new System.Drawing.Size(63, 61);
            this.buttonUp.TabIndex = 1;
            this.buttonUp.Text = "前进";
            this.buttonUp.UseVisualStyleBackColor = false;
            this.buttonUp.Click += new System.EventHandler(this.buttonUp_Click);
            // 
            // panelTop
            // 
            this.panelTop.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelTop.Controls.Add(this.panelTopRight);
            this.panelTop.Controls.Add(this.groupBoxSerial);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 32);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(1068, 342);
            this.panelTop.TabIndex = 12;
            // 
            // panelTopRight
            // 
            this.panelTopRight.Controls.Add(this.groupBoxDateRev);
            this.panelTopRight.Controls.Add(this.groupBoxDateSend);
            this.panelTopRight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelTopRight.Location = new System.Drawing.Point(296, 0);
            this.panelTopRight.Name = "panelTopRight";
            this.panelTopRight.Size = new System.Drawing.Size(768, 338);
            this.panelTopRight.TabIndex = 10;
            // 
            // panelBottom
            // 
            this.panelBottom.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelBottom.Controls.Add(this.labelMes);
            this.panelBottom.Controls.Add(this.labelMessage);
            this.panelBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelBottom.Location = new System.Drawing.Point(0, 611);
            this.panelBottom.Name = "panelBottom";
            this.panelBottom.Size = new System.Drawing.Size(1068, 30);
            this.panelBottom.TabIndex = 6;
            // 
            // labelMes
            // 
            this.labelMes.Dock = System.Windows.Forms.DockStyle.Left;
            this.labelMes.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelMes.ForeColor = System.Drawing.Color.ForestGreen;
            this.labelMes.Location = new System.Drawing.Point(0, 0);
            this.labelMes.Name = "labelMes";
            this.labelMes.Size = new System.Drawing.Size(102, 26);
            this.labelMes.TabIndex = 8;
            this.labelMes.Text = "提示信息：";
            this.labelMes.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // panelMiddle
            // 
            this.panelMiddle.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelMiddle.Controls.Add(this.groupBoxControl);
            this.panelMiddle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMiddle.Location = new System.Drawing.Point(0, 374);
            this.panelMiddle.Name = "panelMiddle";
            this.panelMiddle.Size = new System.Drawing.Size(1068, 237);
            this.panelMiddle.TabIndex = 6;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1068, 641);
            this.Controls.Add(this.panelMiddle);
            this.Controls.Add(this.panelBottom);
            this.Controls.Add(this.panelTop);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BleControlCar";
            this.Load += new System.EventHandler(this.Main_Load);
            this.groupBoxSerial.ResumeLayout(false);
            this.tableLayoutPanelSet.ResumeLayout(false);
            this.tableLayoutPanelSet.PerformLayout();
            this.groupBoxDateRev.ResumeLayout(false);
            this.groupBoxDateRev.PerformLayout();
            this.groupBoxDateSend.ResumeLayout(false);
            this.groupBoxDateSend.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBoxControl.ResumeLayout(false);
            this.panelMiddleMiddle.ResumeLayout(false);
            this.groupBoxSet.ResumeLayout(false);
            this.tableLayoutPanelSetting.ResumeLayout(false);
            this.tableLayoutPanelControl.ResumeLayout(false);
            this.panelTop.ResumeLayout(false);
            this.panelTopRight.ResumeLayout(false);
            this.panelBottom.ResumeLayout(false);
            this.panelMiddle.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.IO.Ports.SerialPort serialPort;
        private System.Windows.Forms.GroupBox groupBoxSerial;
        private System.Windows.Forms.ComboBox comboBoxSerial;
        private System.Windows.Forms.ComboBox comboBoxRate;
        private System.Windows.Forms.Label labelRate;
        private System.Windows.Forms.Label labelSerial;
        private System.Windows.Forms.Button buttonSerial;
        private System.Windows.Forms.Button buttonSend;
        private System.Windows.Forms.TextBox textBoxSend;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelSet;
        private System.Windows.Forms.ComboBox comboBoxStop;
        private System.Windows.Forms.ComboBox comboBoxPick;
        private System.Windows.Forms.ComboBox comboBoxDate;
        private System.Windows.Forms.Label labelDate;
        private System.Windows.Forms.Label labelPick;
        private System.Windows.Forms.Label labelStop;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.Label labelMessage;
        private System.Windows.Forms.GroupBox groupBoxDateRev;
        private System.Windows.Forms.GroupBox groupBoxDateSend;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.TextBox textBoxRev;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 连接说明ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 关于ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 串口设置ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 作者JluTigerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 学校吉林大学ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 数据格式ASCIIToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 退出ToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBoxControl;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelControl;
        private System.Windows.Forms.Button buttonRight;
        private System.Windows.Forms.Button buttonLeft;
        private System.Windows.Forms.Button buttonDown;
        private System.Windows.Forms.Button buttonUp;
        private System.Windows.Forms.Label labelRateTip;
        private System.Windows.Forms.Label labelTip;
        private System.Windows.Forms.ComboBox comboBoxSet;
        private System.Windows.Forms.GroupBox groupBoxSet;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelSetting;
        private System.Windows.Forms.Button buttonSet2;
        private System.Windows.Forms.Button buttonSet3;
        private System.Windows.Forms.Button buttonSet4;
        private System.Windows.Forms.Button buttonSet1;
        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Panel panelTopRight;
        private System.Windows.Forms.Panel panelBottom;
        private System.Windows.Forms.Label labelMes;
        private System.Windows.Forms.Panel panelMiddle;
        private System.Windows.Forms.Panel panelMiddleMiddle;
        private System.Windows.Forms.Panel panelImage;
    }
}

