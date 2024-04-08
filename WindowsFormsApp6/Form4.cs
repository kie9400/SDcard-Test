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


namespace WindowsFormsApp6
{
    public partial class Form4 : Form
    {
        private SerialPort mySerial; 

        private byte[] StringToByte(string _str)
        {
            byte[] tmpBytes = Encoding.UTF8.GetBytes(_str);
            return tmpBytes;
        }

        public Form4()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            mySerial = new SerialPort();
            comboBox1.DataSource = SerialPort.GetPortNames();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (mySerial.IsOpen) // 특정 포트가 이미 열려 있다면 설정이 되지 않기 때문에 우선 닫는다.
            {
                mySerial.Close();
            }
            if (!mySerial.IsOpen)  //시리얼포트가 닫혀있을 때만
            {
                mySerial.PortName = comboBox1.Text;  // 선택된 combobox 의 이름으로 포트명을 지정하자
                mySerial.BaudRate = 9600;  //아두이노에서 사용할 전송률를 지정하자
                mySerial.DataBits = 8;
                mySerial.StopBits = StopBits.One;
                mySerial.Parity = Parity.None;

            }
            else
            {
                MessageBox.Show("이미 열려 있습니다.");
            }
        }

        

        private void button1_Click(object sender, EventArgs e)
        {
            mySerial.Encoding = Encoding.UTF8;
            String str = txt1.Text;
            byte[] datas = StringToByte(str + "\n"); // 줄바꿈 기호인 \n 은 끝에 꼭 들어가야 합니다.
            mySerial.Write(datas, 0, datas.Length);
            MessageBox.Show("보내기 완료");
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void 포트닫기_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text == "") return;
            try
            {
                if (mySerial.IsOpen)
                {
                    mySerial.Close();
                }
                else
                {
                    mySerial.PortName = comboBox1.Text;
                    mySerial.Open();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            포트닫기.Text = mySerial.IsOpen ? "해제" : "연결";
            comboBox1.Enabled = !mySerial.IsOpen;
        }

    }
}
