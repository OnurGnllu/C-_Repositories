namespace seriport_uygulamam
{
    partial class mqttform
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
            this.hosttext = new System.Windows.Forms.TextBox();
            this.porttext = new System.Windows.Forms.TextBox();
            this.usernametext = new System.Windows.Forms.TextBox();
            this.passwordtext = new System.Windows.Forms.TextBox();
            this.mqttbaglanbuton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.geridonbuton2 = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // hosttext
            // 
            this.hosttext.Location = new System.Drawing.Point(124, 39);
            this.hosttext.Name = "hosttext";
            this.hosttext.Size = new System.Drawing.Size(175, 20);
            this.hosttext.TabIndex = 0;
            this.hosttext.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // porttext
            // 
            this.porttext.Location = new System.Drawing.Point(354, 40);
            this.porttext.Name = "porttext";
            this.porttext.Size = new System.Drawing.Size(137, 20);
            this.porttext.TabIndex = 1;
            // 
            // usernametext
            // 
            this.usernametext.Location = new System.Drawing.Point(124, 101);
            this.usernametext.Name = "usernametext";
            this.usernametext.Size = new System.Drawing.Size(175, 20);
            this.usernametext.TabIndex = 2;
            // 
            // passwordtext
            // 
            this.passwordtext.Location = new System.Drawing.Point(124, 152);
            this.passwordtext.Name = "passwordtext";
            this.passwordtext.Size = new System.Drawing.Size(175, 20);
            this.passwordtext.TabIndex = 3;
            this.passwordtext.TextChanged += new System.EventHandler(this.passwordtext_TextChanged);
            // 
            // mqttbaglanbuton
            // 
            this.mqttbaglanbuton.Location = new System.Drawing.Point(515, 124);
            this.mqttbaglanbuton.Name = "mqttbaglanbuton";
            this.mqttbaglanbuton.Size = new System.Drawing.Size(115, 23);
            this.mqttbaglanbuton.TabIndex = 4;
            this.mqttbaglanbuton.Text = "BAĞLAN";
            this.mqttbaglanbuton.UseVisualStyleBackColor = true;
            this.mqttbaglanbuton.Click += new System.EventHandler(this.mqttbaglanbuton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(39, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "Host";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(319, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(11, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "/";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(36, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "Username";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(39, 156);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "Password";
            // 
            // geridonbuton2
            // 
            this.geridonbuton2.Location = new System.Drawing.Point(31, 3);
            this.geridonbuton2.Name = "geridonbuton2";
            this.geridonbuton2.Size = new System.Drawing.Size(75, 23);
            this.geridonbuton2.TabIndex = 9;
            this.geridonbuton2.Text = "Geri Dön";
            this.geridonbuton2.UseVisualStyleBackColor = true;
            this.geridonbuton2.Click += new System.EventHandler(this.geridonbuton2_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(124, 190);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(88, 17);
            this.checkBox1.TabIndex = 10;
            this.checkBox1.Text = "Şifreyi Göster";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // mqttform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(687, 277);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.geridonbuton2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.mqttbaglanbuton);
            this.Controls.Add(this.passwordtext);
            this.Controls.Add(this.usernametext);
            this.Controls.Add(this.porttext);
            this.Controls.Add(this.hosttext);
            this.Name = "mqttform";
            this.Text = "MQTT Giriş Ekranı";
            this.Load += new System.EventHandler(this.mqttform_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button mqttbaglanbuton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.TextBox hosttext;
        public System.Windows.Forms.TextBox porttext;
        public System.Windows.Forms.TextBox usernametext;
        public System.Windows.Forms.TextBox passwordtext;
        private System.Windows.Forms.Button geridonbuton2;
        private System.Windows.Forms.CheckBox checkBox1;
    }
}