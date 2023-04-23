using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace seriport_uygulamam
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!radioButton1.Checked && !radioButton2.Checked)
            {
                MessageBox.Show("Lütfen Bir Seçim Yapiniz");
            }

            else if (radioButton1.Checked) {
                seriportform seriportform = new seriportform();
              
               
                seriportform.Show();
                this.Hide();
            }

            else if (radioButton2.Checked)
            {  
                mqttform mqttform = new mqttform();
                
                mqttform.Show();
                this.Hide();

            }

        }

        private void silinecekbox_TextChanged(object sender, EventArgs e)
        {
    
        }


        // bu fonksiyon sayesinde formlar arası geçiş sorunları aza indirilir (kullanılırsa iyi olur)





    }
}
