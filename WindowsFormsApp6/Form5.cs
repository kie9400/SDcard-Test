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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (serialPort1.IsOpen)
                {
                    //아무것도안함
                }
                else
                {
                    serialPort1.Open();
                }
                serialPort1.Write("1");
                listBox1.Items.Add(serialPort1.ReadLine());
                listBox1.Items.Add(serialPort1.ReadLine());
                listBox1.Items.Add(serialPort1.ReadLine());
                listBox1.Items.Add(serialPort1.ReadLine());
                listBox1.Items.Add(serialPort1.ReadLine());
            }
            catch (Exception ex)
            {
                MessageBox.Show("통신 오류: " + ex.Message);
            }
            finally
            {
                if (serialPort1.IsOpen)
                    serialPort1.Close();
            }
        }

        private void serialPort1_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            listBox1.Items.Add("SD카드 목록");
        }
    }

}
