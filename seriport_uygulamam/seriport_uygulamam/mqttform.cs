using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using uPLibrary.Networking.M2Mqtt;
using uPLibrary.Networking.M2Mqtt.Messages;


namespace seriport_uygulamam
{
    public partial class mqttform : Form
    {
        public mqttform()
        {
            InitializeComponent(); 

    }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void mqttbaglanbuton_Click(object sender, EventArgs e)
        {

            mqttform2 mqttform2 = new mqttform2();
            mqttform2.username = usernametext.Text;
            mqttform2.password = passwordtext.Text;
            mqttform2.host = hosttext.Text;
            mqttform2.Show();
            this.Hide();

        }




        private void mqttform_Load(object sender, EventArgs e)
        {
            // ilk başta şifreyi gizli göstermek için kullanılır.
            passwordtext.PasswordChar = '*';


        }

        private void geridonbuton2_Click(object sender, EventArgs e)
        {
            Application.OpenForms["Form1"].Show();
            this.Hide();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            
                //checkBox işaretli ise
                if (checkBox1.Checked)
                {
                    //karakteri göster.
                    passwordtext.PasswordChar = '\0';
                }
                //değilse karakterlerin yerine * koy.
                else
                {
                    passwordtext.PasswordChar = '*';
                }
            
        }

        private void passwordtext_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
