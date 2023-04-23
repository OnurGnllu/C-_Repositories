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
 
    public partial class mqttform2 : Form
    {
        MqttClient mqttClient;


        public mqttform2()
        {

            InitializeComponent();
        }



  

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void subscribebuton_Click(object sender, EventArgs e)
        {
            mqttClient.Subscribe(new string[] { topicnametext.Text }, new byte[] { MqttMsgBase.QOS_LEVEL_AT_LEAST_ONCE });
        }

        private void publishbuton_Click(object sender, EventArgs e)
        {
            Task.Run(() =>
            {
                if (mqttClient != null && mqttClient.IsConnected)
                {
                    mqttClient.Publish(topicnametext.Text, Encoding.UTF8.GetBytes(messagetext.Text));
                }
            });



        }

        private void MqttClient_MqttMsgPublishReceived(object sender, uPLibrary.Networking.M2Mqtt.Messages.MqttMsgPublishEventArgs e)
        {
           
            var message = Encoding.UTF8.GetString(e.Message);
            listBox1.Invoke((MethodInvoker)(() => listBox1.Items.Add(message)));
        }

        private void mqttform2_Load(object sender, EventArgs e)
        {
           
            
           Task.Run(() =>
           {
              
                mqttClient = new MqttClient(host);
                mqttClient.MqttMsgPublishReceived += MqttClient_MqttMsgPublishReceived;
                mqttClient.Connect("onurgn", username, password);

            });

        }

        private void geridonbuton3_Click(object sender, EventArgs e)
        {
            Application.OpenForms["mqttform"].Show();
            this.Hide();
        }
    }
}
