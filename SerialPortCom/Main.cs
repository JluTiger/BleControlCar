using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.IO.Ports;
using System.Threading;

namespace SerialPortCom
{
    public partial class Main : Form
    {
        SerialPort s = new SerialPort(); // 实例化一个串口对象

        public Main()
        {
            InitializeComponent();
            System.Windows.Forms.Control.CheckForIllegalCrossThreadCalls = false;
            
        }

        private void Init_Port_config()
        {
            comboBoxRate.SelectedIndex = 1;
            comboBoxDate.SelectedIndex = 3;
            comboBoxPick.SelectedIndex = 0;
            comboBoxStop.SelectedIndex = 0;
            buttonSerial.Text = "打开串口";
        }

        private void Main_Load(object sender, EventArgs e)
        {
            Init_Port_config();
            comboBoxSet.SelectedIndex = 0;
            string[] ports = SerialPort.GetPortNames();
            if (ports.Length==0)
            {
                labelMessage.Text = "本机没有串口，请在连接串口之后点击:刷新串口。";
                return;
            }else{
                comboBoxSerial.Items.AddRange(ports);
                comboBoxSerial.SelectedItem = comboBoxSerial.Items[0]; 
                labelMessage.Text = "成功检测到串口，已更新。";
            }

            Control.CheckForIllegalCrossThreadCalls = false;
            s.DataReceived += new SerialDataReceivedEventHandler(dataReceived);

        }

        //接收数据
        private void dataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            if (s.IsOpen)
            {
                DateTime dateTimeNow = DateTime.Now;
                
                try
                {
                    String input = s.ReadLine();
                    textBoxRev.Text += string.Format("{0}", dateTimeNow)+input + "\r\n";
                    textBoxRev.Focus();
                    textBoxRev.SelectionStart = textBoxRev.TextLength;
                    textBoxRev.ScrollToCaret();
                }
                catch (System.Exception ex)
                {
                    MessageBox.Show(ex.Message, "提示：");
                    return;
                }

                textBoxRev.SelectionStart = textBoxRev.Text.Length;
                //textBoxRev.ScrollToCaret();//滚动到光标处
                s.DiscardInBuffer(); //清空SerialPort控件的Buffer 


            }
        }



        private void buttonSerial_Click(object sender, EventArgs e)
        {
            try
            {
                if (!s.IsOpen)
                {

                    string strSerialName = comboBoxSerial.SelectedItem.ToString();
                    string strBaudRate = comboBoxRate.SelectedItem.ToString();
                    string strDataBit = comboBoxDate.SelectedItem.ToString();
                    string strCheckBit = comboBoxPick.SelectedItem.ToString();
                    string strStopBit = comboBoxStop.SelectedItem.ToString();

                    Int32 iBaudRate = Convert.ToInt32(strBaudRate);
                    Int32 iDataBit = Convert.ToInt32(strDataBit);

                    s.PortName = strSerialName; //串口号
                    s.BaudRate = iBaudRate; //波特率
                    s.DataBits = iDataBit; //数据位

                    switch(strStopBit) //停止位
                    {
                        case "1":
                            s.StopBits = StopBits.One;
                            break;
                        case "1.5":
                            s.StopBits = StopBits.OnePointFive;
                            break;
                        case "2":
                            s.StopBits = StopBits.Two;
                            break;
                        default:
                            MessageBox.Show("Error：停止位参数不正确!", "Error");
                            break;
                    }

                    switch (strCheckBit)             //校验位
                    {
                        case "None":
                            s.Parity = Parity.None;
                            break;
                        case "Odd":
                            s.Parity = Parity.Odd;
                            break;
                        case "Even":
                            s.Parity = Parity.Even;
                            break;
                        default:
                            MessageBox.Show("Error：校验位参数不正确!", "Error");
                            break;
                    }

                    s.Open(); //打开串口

                    buttonSerial.Text = "关闭串口";
                    comboBoxSerial.Enabled = false;
                    comboBoxRate.Enabled = false;
                    comboBoxDate.Enabled = false;
                    comboBoxPick.Enabled = false;
                    comboBoxStop.Enabled = false;
                    labelMessage.Text ="串口通信已建立！";
                }
                else
                {
                    s.Close();
                    buttonSerial.Text = "打开串口";
                    comboBoxSerial.Enabled = true;
                    comboBoxRate.Enabled = true;
                    comboBoxDate.Enabled = true;
                    comboBoxPick.Enabled = true;
                    comboBoxStop.Enabled = true;
                    labelMessage.Text = "串口通信已断开！";
                }
            }catch(Exception ee)
            {
                MessageBox.Show("请检查串口是否连接！","出现错误：");
                labelMessage.Text = "请检查串口是否连接！";
            }
        }


        private void buttonSend_Click(object sender, EventArgs e)
        {
            if (!s.IsOpen)
            {
                MessageBox.Show("请先打开串口！","提示：");
                return;
            }

            String sendBuff = textBoxSend.Text;
            //以字符串ASCII发送数据
            s.WriteLine(sendBuff);

            //还可以使用16进制发送
            /**
            char[] values = strSend.ToCharArray();
            foreach (char letter in values)
            {
                int value = Convert.ToInt32(letter);
                string hexIutput = String.Format("{0:X}", value);
                serialPort.Write(hexIutput);
            }
            **/
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            if (s.IsOpen)
            {
                MessageBox.Show("请先关闭串口连接之后再刷新！","提示：");
            }
            else
            {
                comboBoxSerial.Text = "";
                comboBoxSerial.Items.Clear();
                string[] str = SerialPort.GetPortNames();
                if (str.Length == 0)
                {
                    MessageBox.Show("未监测到有效端口！", "提示：", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    labelMessage.Text = "本机没有串口，请在连接串口之后点击:刷新串口。";
                }
                else
                {
                    //添加串口
                    foreach (string s in str)
                    {
                        comboBoxSerial.Items.Add(s);
                    }
                    labelMessage.Text = "成功检测到串口，已更新。";
                    comboBoxSerial.SelectedItem = comboBoxSerial.Items[0];
                }
            }
      
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            textBoxRev.Text = "";
        }

        private void 串口设置ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("蓝牙连接端口：COM6/COM7；\r\n波特率：9600bps；\r\n数据位：8bit；\r\n校验位：None；\r\n停止位：1bit.","串口设置提示：");
        }

        private void 退出ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("是否确认退出？", "提示：", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == DialogResult.OK)
            {
                if (s.IsOpen)
                {
                    s.Close();
                }
                this.Close();
            }  
        }

        //获取速率设置的值
        private int getSetRate()
        {
            string m = comboBoxSet.SelectedItem.ToString();
            return int.Parse(m);
        } 


        private void buttonUp_Click(object sender, EventArgs e)
        {
            if (!s.IsOpen)
            {
                MessageBox.Show("请先建立串口通信连接！","提示：",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return;
            }

            for(int i = 0; i < getSetRate(); i++)
            {
                String sendBuff = "$1,0,0,0,0,0,0,0,0,0,0,0,0#"; //前进指令
                //以字符串ASCII发送数据
                s.WriteLine(sendBuff);
            }
            
        }

        private void buttonDown_Click(object sender, EventArgs e)
        {
            if (!s.IsOpen)
            {
                MessageBox.Show("请先建立串口通信连接！", "提示：", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            for (int i = 0; i < getSetRate(); i++)
            {
                String sendBuff = "$2,0,0,0,0,0,0,0,0,0,0,0,0#"; //前进指令
                //以字符串ASCII发送数据
                s.WriteLine(sendBuff);
            }
        }

        private void buttonLeft_Click(object sender, EventArgs e)
        {
            if (!s.IsOpen)
            {
                MessageBox.Show("请先建立串口通信连接！", "提示：", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            for (int i = 0; i < getSetRate(); i++)
            {
                String sendBuff = "$3,0,0,0,0,0,0,0,0,0,0,0,0#"; //前进指令
                //以字符串ASCII发送数据
                s.WriteLine(sendBuff);
            }
        }

        private void buttonRight_Click(object sender, EventArgs e)
        {
            if (!s.IsOpen)
            {
                MessageBox.Show("请先建立串口通信连接！", "提示：", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            for (int i = 0; i < getSetRate(); i++)
            {
                String sendBuff = "$4,0,0,0,0,0,0,0,0,0,0,0,0#"; //前进指令
                //以字符串ASCII发送数据
                s.WriteLine(sendBuff);
            }
        }
    }
}
