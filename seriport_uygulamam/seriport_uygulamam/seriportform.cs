using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace seriport_uygulamam
{
    public partial class seriportform : Form
    {
        public seriportform()
        {
            InitializeComponent();
        }

        private void portlabel_Click(object sender, EventArgs e)
        {

        }

        private void portcomboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            foreach (var Seriport in SerialPort.GetPortNames())
            {
                portcomboBox1.Items.Add(Seriport);
            }
        }

        private void baglanbuton_Click(object sender, EventArgs e)
        {
            serialPort1.PortName = portcomboBox1.Text;
            int baudrates = Convert.ToInt32(baudcomboBox2.SelectedItem); //baudrate i string den integer a cevirdik.
            serialPort1.BaudRate = baudrates;
            serialPort1.Parity = Parity.Even;
            serialPort1.StopBits = StopBits.One;
            serialPort1.DataBits = 8;
            serialPort1.Open();
        }

        private void baudcomboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void baudratelabel_Click(object sender, EventArgs e)
        {

        }

        private void geridonbuton_Click(object sender, EventArgs e)
        {
            Application.OpenForms["Form1"].Show();
            this.Hide();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        
        


        private void button1_Click(object sender, EventArgs e)
        {
            
            if (serialPort1.IsOpen)
            {
                serialPort1.Write(textBox2.Text);
                textBox2.Clear();

            }
        }
        public delegate void veriGoster(String s);

        public void texteYaz(String s)
        {
            textBox1.Text += s;
        }

        //Seri porttan veri almak için bu komut kullanılır.
        private void serialPort1_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            String gelenveri = serialPort1.ReadExisting();
            // textBox1.Text += gelenveri; bu şekilde kullanılamıyor.
            textBox1.Invoke(new veriGoster(texteYaz), gelenveri);

        }

        // bu fonksiyon sayesinde formlar arası geçiş sorunları aza indirilir (kullanılırsa iyi olur)



    }
}
