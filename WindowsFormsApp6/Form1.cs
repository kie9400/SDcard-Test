using System;
using System.Drawing;
using System.Windows.Forms;
using System.IO.Ports;
using System.IO;
using System.Threading.Tasks;
using System.Drawing.Imaging;
using System.Threading;
using System.Linq;
using System.Text;

namespace WindowsFormsApp6
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //serialPort1.Open();
        }

        private void button1_Click(object sender, EventArgs e)
        {       
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = openFileDialog1.Filter = "Image files (*.jpg, *.bmp) | *.jpg; *.bmp";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                if (!serialPort1.IsOpen) //아두이노와 시리얼 통신이 연결되어있지 않은가?
                {
                    MessageBox.Show("아두이노와 연결이 되지 않았습니다."); //연결상태
                    return; //메서드를 종료합니다.
                }
                string fileName = openFileDialog.FileName;
                pictureBox1.Image = Bitmap.FromFile(openFileDialog.FileName);
                // 이미지 파일 읽기
                byte[] imageBytes = System.IO.File.ReadAllBytes(fileName);
                // 아두이노로 이미지 데이터 전송
                // 프로그레시브 바 업데이트
                progressBar1.Value = 0;
                progressBar1.Maximum = imageBytes.Length;
                // 전송이 완료될 때까지 대기             
                int bytesSent = 0;
                const int BUFFER_SIZE = 256;
                try
                {
                    while (bytesSent < imageBytes.Length)
                    {
                        int bytesRemaining = imageBytes.Length - bytesSent;
                        int bytesToSend = Math.Min(bytesRemaining, BUFFER_SIZE);
                        int num = bytesRemaining;
                        serialPort1.Write(imageBytes, bytesSent, bytesToSend);
                        bytesSent += bytesToSend;
                        listBox1.Items.Add(bytesSent);
                        label2.Text = bytesSent.ToString() + " byte / " + imageBytes.Length + " byte";
                        progressBar1.Value = bytesSent;
                    }
                    progressBar1.Value = progressBar1.Maximum;
                    // 전송 완료 메시지 표시
                    MessageBox.Show("이미지 전송이 완료되었습니다.");
                    progressBar1.Value = 0;
                }
                catch (IOException ex)
                {
                    MessageBox.Show("이미지 전송 실패 : Test Fail\n " + ex.Message);
                }
            }
        }
         
        /*private void button3_Click(object sender, EventArgs e)
        {
            serialPort1.WriteLine("1");
            // 아두이노로부터 응답 수신
            string response = serialPort1.ReadLine();
            label2.Text = response;
            listBox1.Items.Add(response.ToString());
        }*/

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                if (true == serialPort1.IsOpen)
                {
                    serialPort1.Close();
                }
            }
            catch (Exception f)
            {
                MessageBox.Show(f.ToString());
            }
        }

        private void comboBox1_Click(object sender, EventArgs e)
        {
            comboBox1.Items.Clear();
            foreach(var item in SerialPort.GetPortNames())
            {
                comboBox1.Items.Add(item);
            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            if (comboBox1.Text == "") return;
            try
            {
                if (serialPort1.IsOpen)
                {
                    serialPort1.Close();
                }
                else
                {
                    serialPort1.PortName = comboBox1.Text;
                    serialPort1.Open();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            button2.Text = serialPort1.IsOpen ? "해제" : "연결";
            comboBox1.Enabled = !serialPort1.IsOpen;
        }
    }
 }
