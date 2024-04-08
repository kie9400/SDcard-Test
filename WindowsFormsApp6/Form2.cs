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
    public partial class Form2 : Form
    {
        Form f1 = new Form1();
        Form f3 = new Form3();
        Form f4 = new Form4();
        Form f5 = new Form5();

        public Form2()
        {
            InitializeComponent();
            //this.AddOwnedForm(f1);      
        }

        private void button1_Click(object sender, EventArgs e)
        {
            f1.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            f3.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            f4.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            f5.ShowDialog();
        }
    }
}
