using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ifelse
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(comboBox1.Text == "mavi")
                
            {
                textBox1.Text = "Mutluluğun Rengi Mavi";
                label4.Text = textBox1.Text;
                groupBox1.BackColor = Color.Blue;
            }
            if(comboBox1.Text=="sarı")
            {
                textBox1.Text = "İyimserliğin Rengidir Sarı";
                label4.Text = textBox1.Text;
                groupBox1.BackColor = Color.Yellow;
            }
            if(comboBox1.Text=="yeşil")
            {
                textBox1.Text = "Bereketin Rengi Yeşil";
                    label4.Text = textBox1.Text;
                groupBox1.BackColor= Color.Green;
            }
            if(comboBox1.Text=="kırmızı")
            {
                textBox1.Text = "Tutkunun Rengi Kırmızı";
                label4.Text = textBox1.Text;
                groupBox1.BackColor = Color.Red;
            }
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }
    }
}
