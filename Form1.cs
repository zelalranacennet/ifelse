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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(textBox1.Text =="a"&& textBox2.Text =="1")
            {
                Form3 yeni = new Form3();
                yeni.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Hatalı Giriş Yaptınız Tekrar Deneyin");
                textBox1.Clear();
                textBox2.Clear();

            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
