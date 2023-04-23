namespace seriport_uygulamam
{
    partial class seriportform
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
            this.components = new System.ComponentModel.Container();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.portcomboBox1 = new System.Windows.Forms.ComboBox();
            this.baudcomboBox2 = new System.Windows.Forms.ComboBox();
            this.baglanbuton = new System.Windows.Forms.Button();
            this.portlabel = new System.Windows.Forms.Label();
            this.baudratelabel = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.geridonbuton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // serialPort1
            // 
            this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort1_DataReceived);
            // 
            // portcomboBox1
            // 
            this.portcomboBox1.FormattingEnabled = true;
            this.portcomboBox1.Location = new System.Drawing.Point(164, 25);
            this.portcomboBox1.Name = "portcomboBox1";
            this.portcomboBox1.Size = new System.Drawing.Size(158, 21);
            this.portcomboBox1.TabIndex = 0;
            this.portcomboBox1.SelectedIndexChanged += new System.EventHandler(this.portcomboBox1_SelectedIndexChanged);
            // 
            // baudcomboBox2
            // 
            this.baudcomboBox2.FormattingEnabled = true;
            this.baudcomboBox2.Items.AddRange(new object[] {
            "300",
            "600",
            "1200",
            "2400",
            "4800",
            "9600",
            "14400",
            "19200",
            "28800",
            "38400",
            "57600",
            "115200"});
            this.baudcomboBox2.Location = new System.Drawing.Point(164, 92);
            this.baudcomboBox2.Name = "baudcomboBox2";
            this.baudcomboBox2.Size = new System.Drawing.Size(158, 21);
            this.baudcomboBox2.TabIndex = 1;
            this.baudcomboBox2.SelectedIndexChanged += new System.EventHandler(this.baudcomboBox2_SelectedIndexChanged);
            // 
            // baglanbuton
            // 
            this.baglanbuton.Location = new System.Drawing.Point(367, 59);
            this.baglanbuton.Name = "baglanbuton";
            this.baglanbuton.Size = new System.Drawing.Size(113, 23);
            this.baglanbuton.TabIndex = 2;
            this.baglanbuton.Text = "BAĞLAN";
            this.baglanbuton.UseVisualStyleBackColor = true;
            this.baglanbuton.Click += new System.EventHandler(this.baglanbuton_Click);
            // 
            // portlabel
            // 
            this.portlabel.AutoSize = true;
            this.portlabel.Location = new System.Drawing.Point(209, 9);
            this.portlabel.Name = "portlabel";
            this.portlabel.Size = new System.Drawing.Size(82, 13);
            this.portlabel.TabIndex = 3;
            this.portlabel.Text = "PORT SECİNİZ";
            this.portlabel.Click += new System.EventHandler(this.portlabel_Click);
            // 
            // baudratelabel
            // 
            this.baudratelabel.AutoSize = true;
            this.baudratelabel.Location = new System.Drawing.Point(192, 64);
            this.baudratelabel.Name = "baudratelabel";
            this.baudratelabel.Size = new System.Drawing.Size(111, 13);
            this.baudratelabel.TabIndex = 4;
            this.baudratelabel.Text = "BAUDRATE SECİNİZ";
            this.baudratelabel.Click += new System.EventHandler(this.baudratelabel_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(88, 137);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(354, 195);
            this.textBox1.TabIndex = 5;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(88, 364);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(354, 20);
            this.textBox2.TabIndex = 6;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(448, 361);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(113, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "GONDER";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // geridonbuton
            // 
            this.geridonbuton.Location = new System.Drawing.Point(13, 9);
            this.geridonbuton.Name = "geridonbuton";
            this.geridonbuton.Size = new System.Drawing.Size(75, 23);
            this.geridonbuton.TabIndex = 8;
            this.geridonbuton.Text = "Geri Dön";
            this.geridonbuton.UseVisualStyleBackColor = true;
            this.geridonbuton.Click += new System.EventHandler(this.geridonbuton_Click);
            // 
            // seriportform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(570, 461);
            this.Controls.Add(this.geridonbuton);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.baudratelabel);
            this.Controls.Add(this.portlabel);
            this.Controls.Add(this.baglanbuton);
            this.Controls.Add(this.baudcomboBox2);
            this.Controls.Add(this.portcomboBox1);
            this.Name = "seriportform";
            this.Text = "Seri Port Ekranı";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.ComboBox portcomboBox1;
        private System.Windows.Forms.ComboBox baudcomboBox2;
        private System.Windows.Forms.Button baglanbuton;
        private System.Windows.Forms.Label portlabel;
        private System.Windows.Forms.Label baudratelabel;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button geridonbuton;
    }
}