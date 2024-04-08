using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp6
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (serialPort1.IsOpen)
                {
                    //이미 연결되서 아무것도 안함
                }
                else
                {
                    serialPort1.Open();
                }
                serialPort1.Write("2"); //아두이노로 전송
                listBox1.Items.Add(serialPort1.ReadLine()); //spi통신으로 데이터 읽어와서 리스트박스에 저장
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message); //오류 메세지 박스 출력
            }
        }

        private byte[] StringToByte(string _str)
        {
            byte[] tmpBytes = Encoding.UTF8.GetBytes(_str);
            return tmpBytes;
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
        private void serialPort1_DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {

        }
    }
}
