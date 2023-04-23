using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Nutrition_project_v1._0
{
    public partial class Form1 : Form
    {
        double fa;
        double sonuc;
        double bmh;
        double bkı;
        double energy;
        double boy;
        double kilo;
        string ab = "mesaj";

        public Form1()
        {
            InitializeComponent();
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            label8.Text = bmh.ToString();
            label14.Text = energy.ToString();
            label12.Text = bkı.ToString();


        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //1-Çok Hafif
            //2-Hafif
            //3-Orta
            

            if (comboBox1.SelectedItem.ToString() == "Çok Hafif")
            {

                comboBox2.Items.Clear();
                comboBox2.Items.Add(1.0);
                comboBox2.Items.Add(1.1);
                comboBox2.Items.Add(1.2);
            }
            if (comboBox1.SelectedItem.ToString() == "Hafif")
            {
                comboBox2.Items.Clear();
                comboBox2.Items.Add(1.3);
                comboBox2.Items.Add(1.4);

            }
            if (comboBox1.SelectedItem.ToString() == "Orta")
            {
                comboBox2.Items.Clear();
                comboBox2.Items.Add(1.5);
                comboBox2.Items.Add(1.6);

            }
           
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem.ToString() == "Çok Hafif")
            {
                if (comboBox2.SelectedIndex == 0)
                    fa = 1;
               
                if (comboBox2.SelectedIndex == 1)
                    fa = 1.1;     // label11.Text = fa.ToString();
                if (comboBox2.SelectedIndex == 2)
                    fa = 1.2;
            }
            if (comboBox1.SelectedItem.ToString() == "Hafif")
            {
                if (comboBox2.SelectedIndex == 0)
                    fa = 1.3;
                if (comboBox2.SelectedIndex == 1)
                    fa = 1.4;

            }
            if (comboBox1.SelectedItem.ToString() == "Orta")
            {
                if (comboBox2.SelectedIndex == 0) fa = 1.5;

                if (comboBox2.SelectedIndex == 1) fa = 1.6;

            }
            // label8.Text = fa.ToString(); //runtime change the label8
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked == true)
            {

            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true) {

                Form2 f2 = new Form2();

                f2.Show();
                double boy5;
                int kilo5;
                boy5= Convert.ToDouble(textBox2.Text);
                kilo5 = Convert.ToInt32(textBox3.Text);
                bmh = 0.95 * 24 * kilo5;                
                bkı = ((kilo5) / ((boy5)*(boy5)))*10*10*10*10;
                energy = bmh*fa;              
                



            }
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {
            
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }
    }
}
