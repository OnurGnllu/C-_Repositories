namespace seriport_uygulamam
{
    partial class mqttform2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.topicnametext = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.subscribebuton = new System.Windows.Forms.Button();
            this.publishbuton = new System.Windows.Forms.Button();
            this.messagetext = new System.Windows.Forms.TextBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.geridonbuton3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // topicnametext
            // 
            this.topicnametext.Location = new System.Drawing.Point(109, 38);
            this.topicnametext.Name = "topicnametext";
            this.topicnametext.Size = new System.Drawing.Size(279, 20);
            this.topicnametext.TabIndex = 0;
            this.topicnametext.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "TOPIC";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // subscribebuton
            // 
            this.subscribebuton.Location = new System.Drawing.Point(425, 34);
            this.subscribebuton.Name = "subscribebuton";
            this.subscribebuton.Size = new System.Drawing.Size(114, 23);
            this.subscribebuton.TabIndex = 3;
            this.subscribebuton.Text = "Subscribe";
            this.subscribebuton.UseVisualStyleBackColor = true;
            this.subscribebuton.Click += new System.EventHandler(this.subscribebuton_Click);
            // 
            // publishbuton
            // 
            this.publishbuton.Location = new System.Drawing.Point(568, 314);
            this.publishbuton.Name = "publishbuton";
            this.publishbuton.Size = new System.Drawing.Size(95, 35);
            this.publishbuton.TabIndex = 4;
            this.publishbuton.Text = "Publish";
            this.publishbuton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.publishbuton.UseVisualStyleBackColor = true;
            this.publishbuton.Click += new System.EventHandler(this.publishbuton_Click);
            // 
            // messagetext
            // 
            this.messagetext.Location = new System.Drawing.Point(109, 326);
            this.messagetext.Name = "messagetext";
            this.messagetext.Size = new System.Drawing.Size(430, 20);
            this.messagetext.TabIndex = 5;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(109, 64);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(430, 251);
            this.listBox1.TabIndex = 6;
            // 
            // geridonbuton3
            // 
            this.geridonbuton3.Location = new System.Drawing.Point(41, 3);
            this.geridonbuton3.Name = "geridonbuton3";
            this.geridonbuton3.Size = new System.Drawing.Size(75, 23);
            this.geridonbuton3.TabIndex = 7;
            this.geridonbuton3.Text = "Geri Dön";
            this.geridonbuton3.UseVisualStyleBackColor = true;
            this.geridonbuton3.Click += new System.EventHandler(this.geridonbuton3_Click);
            // 
            // mqttform2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(780, 361);
            this.Controls.Add(this.geridonbuton3);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.messagetext);
            this.Controls.Add(this.publishbuton);
            this.Controls.Add(this.subscribebuton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.topicnametext);
            this.Name = "mqttform2";
            this.Text = "MQTT Haberleşme Ekranı";
            this.Load += new System.EventHandler(this.mqttform2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox topicnametext;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button subscribebuton;
        private System.Windows.Forms.Button publishbuton;
        private System.Windows.Forms.TextBox messagetext;
        public System.Windows.Forms.ListBox listBox1;
        public string username;
        public string password;
        public string host;
        private System.Windows.Forms.Button geridonbuton3;
    }
}