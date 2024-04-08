using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp12
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {

            }
            else
            {
                serialPort1.Open();
            }
            serialPort1.Write("2");
            listBox1.Items.Add(serialPort1.ReadLine());
        }

        private byte[] StringToByte(string _str)
        {
            byte[] tmpBytes = Encoding.UTF8.GetBytes(_str);
            return tmpBytes;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {

            }
            else
            {
                serialPort1.Open();
            }
            String str = textBox1.Text;
            serialPort1.Write("1");
            serialPort1.Write(str);
            MessageBox.Show("보내기 완료");
        }
        private void serialPort1_DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {

            /*if (serialPort1.IsOpen)
            {
                string data = serialPort1.ReadLine();
                Invoke(new Action(() =>
                {
                    listBox1.Items.Add(data);
                }));
            }*/
        }

    }
}
